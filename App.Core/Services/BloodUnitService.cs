using App.Core.Interfaces;
using App.Core.Models;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace App.Core.Services
{
    public class BloodUnitService : IBloodUnitService
    {
        private readonly string _conn = DbConfig.ConnectionString;

        public List<BloodUnit> GetAll()
        {
            var list = new List<BloodUnit>();
            using (var con = new SqlConnection(_conn))
            using (var cmd = new SqlCommand("SELECT * FROM BloodUnits ORDER BY ExpiryDate", con))
            {
                con.Open();
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(Map(r));
            }
            return list;
        }

        public BloodUnit GetById(string id)
        {
            using (var con = new SqlConnection(_conn))
            using (var cmd = new SqlCommand("SELECT * FROM BloodUnits WHERE UnitId=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                using (var r = cmd.ExecuteReader())
                    return r.Read() ? Map(r) : null;
            }
        }

        public void Add(BloodUnit u)
        {
            using (var con = new SqlConnection(_conn))
            using (var cmd = new SqlCommand(@"
                INSERT INTO BloodUnits(UnitId,BloodGroup,CollectedOn,ExpiryDate,DonorId,Status,Quantity)
                VALUES(@id,@bg,@col,@exp,@donor,@status,@qty)", con))
            {
                SetParams(cmd, u);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(BloodUnit u)
        {
            using (var con = new SqlConnection(_conn))
            using (var cmd = new SqlCommand(@"
                UPDATE BloodUnits SET BloodGroup=@bg,CollectedOn=@col,ExpiryDate=@exp,
                DonorId=@donor,Status=@status,Quantity=@qty WHERE UnitId=@id", con))
            {
                SetParams(cmd, u);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string id)
        {
            using (var con = new SqlConnection(_conn))
            using (var cmd = new SqlCommand("DELETE FROM BloodUnits WHERE UnitId=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void SetParams(SqlCommand cmd, BloodUnit u)
        {
            cmd.Parameters.AddWithValue("@id", u.UnitId);
            cmd.Parameters.AddWithValue("@bg", u.BloodGroup);
            cmd.Parameters.AddWithValue("@col", u.CollectedOn);
            cmd.Parameters.AddWithValue("@exp", u.ExpiryDate);
            cmd.Parameters.AddWithValue("@donor", (object)u.DonorId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@status", u.Status);
            cmd.Parameters.AddWithValue("@qty", u.Quantity);
        }

        private BloodUnit Map(SqlDataReader r) => new BloodUnit
        {
            UnitId = r["UnitId"].ToString(),
            BloodGroup = r["BloodGroup"].ToString(),
            CollectedOn = Convert.ToDateTime(r["CollectedOn"]),
            ExpiryDate = Convert.ToDateTime(r["ExpiryDate"]),
            DonorId = r["DonorId"] == DBNull.Value ? null : r["DonorId"].ToString(),
            Status = r["Status"].ToString(),
            Quantity = Convert.ToInt32(r["Quantity"])
        };
    }
}