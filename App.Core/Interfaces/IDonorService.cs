using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Interfaces
{
    public interface IDonorService
    {
        List<Donor> GetAll();
        Task<List<Donor>> GetAllAsync();
        Donor GetById(string id);
        void Add(Donor donor);
        void Update(Donor donor);
        void Delete(string id);
    }
}
