using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Interfaces
{
    public interface IBloodRequestService
    {
        List<BloodRequest> GetAll();
        BloodRequest GetById(string id);
        void Add(BloodRequest request);
        void Update(BloodRequest request);
        void Delete(string id);
    }
}
