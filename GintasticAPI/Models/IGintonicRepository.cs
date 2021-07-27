using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GintasticAPI.Models
{
    public interface IGintonicRepository
    {
        Gintonic GetBy(int id);
        bool TryGetGintonic(int id, out IGintonicRepository gintonic);
        IEnumerable<Gintonic> GetAll();
        void Add(Gintonic gintonic);
        void Delete(Gintonic gintonic);
        void Update(Gintonic gintonic);
        void SaveChanges();
    }
}
