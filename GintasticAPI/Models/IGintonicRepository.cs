using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GintasticAPI.Models
{
    public interface IGintonicRepository
    {
        IEnumerable<Gintonic> GetAll();
        void Add(Gintonic gintonic);
        void SaveChanges();
    }
}
