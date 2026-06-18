using App.Core.Interfaces;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace App.Core.Services
{
    public class DonorService : IDonorService
    {
        private readonly string _conn = DbConfig.ConnectionString;

        public List<Donor> GetAll()
        {
            var list = new List<Donor>();
            using (var con = new SqlConnection(_conn))
            using (var cmd = new SqlCommand("SELECT * FROM Donors ORDER BY FullName", con))
            {
                con.Open();
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(Map(r));
            }
            return list;
        }

        public async Task<List<Donor>> GetAllAsync()
        {
            var list = new List<Donor>();
            using (var con = new SqlConnection(_conn))
            using (var cmd = new SqlCommand("SELECT * FROM Donors ORDER BY FullName", con))
            {
                await con.OpenAsync();
                using (var r = await cmd.ExecuteReaderAsync())
                    while (await r.ReadAsync()) list.Add(Map(r));
            }
            return list;
        }

        public Donor GetById(string id)
        {
            using (var con = new SqlConnection(_conn))
            using (var cmd = new SqlCommand("SELECT * FROM Donors WHERE DonorId=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                using (var r = cmd.ExecuteReader())
                    return r.Read() ? Map(r) : null;
            }
        }

        public void Add(Donor d)
        {
            using (var con = new SqlConnection(_conn))
            using (var cmd = new SqlCommand(@"
                INSERT INTO Donors(DonorId,FullName,BloodGroup,DateOfBirth,Phone,Email,Address,LastDonated,IsActive)
                VALUES(@id,@name,@bg,@dob,@phone,@email,@addr,@last,@active)", con))
            {
                SetParams(cmd, d);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Donor d)
        {
            using (var con = new SqlConnection(_conn))
            using (var cmd = new SqlCommand(@"
                UPDATE Donors SET FullName=@name,BloodGroup=@bg,DateOfBirth=@dob,
                Phone=@phone,Email=@email,Address=@addr,LastDonated=@last,IsActive=@active
                WHERE DonorId=@id", con))
            {
                SetParams(cmd, d);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string id)
        {
            using (var con = new SqlConnection(_conn))
            using (var cmd = new SqlCommand("DELETE FROM Donors WHERE DonorId=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void SetParams(SqlCommand cmd, Donor d)
        {
            cmd.Parameters.AddWithValue("@id", d.DonorId);
            cmd.Parameters.AddWithValue("@name", d.FullName);
            cmd.Parameters.AddWithValue("@bg", d.BloodGroup);
            cmd.Parameters.AddWithValue("@dob", d.DateOfBirth);
            cmd.Parameters.AddWithValue("@phone", (object)d.Phone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@email", (object)d.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@addr", (object)d.Address ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@last", (object)d.LastDonated ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@active", d.IsActive);
        }

        private Donor Map(SqlDataReader r) => new Donor
        {
            DonorId = r["DonorId"].ToString(),
            FullName = r["FullName"].ToString(),
            BloodGroup = r["BloodGroup"].ToString(),
            DateOfBirth = Convert.ToDateTime(r["DateOfBirth"]),
            Phone = r["Phone"] == DBNull.Value ? null : r["Phone"].ToString(),
            Email = r["Email"] == DBNull.Value ? null : r["Email"].ToString(),
            Address = r["Address"] == DBNull.Value ? null : r["Address"].ToString(),
            LastDonated = r["LastDonated"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["LastDonated"]),
            IsActive = Convert.ToBoolean(r["IsActive"])
        };
    }
}