using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Core.Interfaces;
using App.Core.Models;

using System.Data.SqlClient;

namespace App.Core.Services
{
    public class BloodRequestService : IBloodRequestService
    {
        private readonly string _conn = DbConfig.ConnectionString;

        public List<BloodRequest> GetAll()
        {
            var list = new List<BloodRequest>();
            using (var con = new SqlConnection(_conn))
            using (var cmd = new SqlCommand("SELECT * FROM BloodRequests ORDER BY RequestDate DESC", con))
            {
                con.Open();
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(Map(r));
            }
            return list;
        }

        public BloodRequest GetById(string id)
        {
            using (var con = new SqlConnection(_conn))
            using (var cmd = new SqlCommand("SELECT * FROM BloodRequests WHERE RequestId=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                using (var r = cmd.ExecuteReader())
                    return r.Read() ? Map(r) : null;
            }
        }

        public void Add(BloodRequest req)
        {
            using (var con = new SqlConnection(_conn))
            using (var cmd = new SqlCommand(@"
                INSERT INTO BloodRequests(RequestId,PatientName,BloodGroup,UnitsNeeded,RequestDate,RequiredBy,Status,Hospital,Notes)
                VALUES(@id,@patient,@bg,@units,@date,@reqby,@status,@hosp,@notes)", con))
            {
                SetParams(cmd, req);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(BloodRequest req)
        {
            using (var con = new SqlConnection(_conn))
            using (var cmd = new SqlCommand(@"
                UPDATE BloodRequests SET PatientName=@patient,BloodGroup=@bg,UnitsNeeded=@units,
                RequestDate=@date,RequiredBy=@reqby,Status=@status,Hospital=@hosp,Notes=@notes
                WHERE RequestId=@id", con))
            {
                SetParams(cmd, req);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string id)
        {
            using (var con = new SqlConnection(_conn))
            using (var cmd = new SqlCommand("DELETE FROM BloodRequests WHERE RequestId=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void SetParams(SqlCommand cmd, BloodRequest r)
        {
            cmd.Parameters.AddWithValue("@id", r.RequestId);
            cmd.Parameters.AddWithValue("@patient", r.PatientName);
            cmd.Parameters.AddWithValue("@bg", r.BloodGroup);
            cmd.Parameters.AddWithValue("@units", r.UnitsNeeded);
            cmd.Parameters.AddWithValue("@date", r.RequestDate);
            cmd.Parameters.AddWithValue("@reqby", (object)r.RequiredBy ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@status", r.Status);
            cmd.Parameters.AddWithValue("@hosp", (object)r.Hospital ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@notes", (object)r.Notes ?? DBNull.Value);
        }

        private BloodRequest Map(SqlDataReader r) => new BloodRequest
        {
            RequestId = r["RequestId"].ToString(),
            PatientName = r["PatientName"].ToString(),
            BloodGroup = r["BloodGroup"].ToString(),
            UnitsNeeded = Convert.ToInt32(r["UnitsNeeded"]),
            RequestDate = Convert.ToDateTime(r["RequestDate"]),
            RequiredBy = r["RequiredBy"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["RequiredBy"]),
            Status = r["Status"].ToString(),
            Hospital = r["Hospital"] == DBNull.Value ? null : r["Hospital"].ToString(),
            Notes = r["Notes"] == DBNull.Value ? null : r["Notes"].ToString()
        };
    }
}
