using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Interfaces
{
    public interface IBloodUnitService
    {
        List<BloodUnit> GetAll();
        BloodUnit GetById(string id);
        void Add(BloodUnit unit);
        void Update(BloodUnit unit);
        void Delete(string id);
    }
}
