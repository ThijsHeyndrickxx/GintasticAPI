using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GintasticAPI.Data
{
    public class GintonicDataInitializer
    {
        private readonly GintonicContext _dbContext;
        public GintonicDataInitializer(GintonicContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void InitializeData()
        {
            _dbContext.Database.EnsureDeleted();
            _dbContext.Database.EnsureCreated();
            
        }
    }
}
