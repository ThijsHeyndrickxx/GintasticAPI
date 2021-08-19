using GintasticAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GintasticAPI.Data.Repositories
{
    public class GintonicRepository :IGintonicRepository
    {
        private readonly GintonicContext _context;
        private readonly DbSet<Gintonic> _gintonics;
        public GintonicRepository(GintonicContext dbContext)
        {
            _context = dbContext;
            _gintonics = dbContext.Gintonics;
        }
        public IEnumerable<Gintonic> GetAll()
        {
            return _gintonics.ToList();
        }
        public void Add(Gintonic gintonic)
        {
            _gintonics.Add(gintonic);
            
        }
        public void SaveChanges()
        {
            this._context.SaveChanges();
        }
    }
}
