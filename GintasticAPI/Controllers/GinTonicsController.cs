using GintasticAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GintasticAPI.Controllers
{
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class GinTonicsController : ControllerBase
    {
       private readonly IGintonicRepository _gintonicRepository;
       public GinTonicsController(IGintonicRepository context)
        {
            _gintonicRepository = context;
        }
        
        [HttpGet]
        public IEnumerable<Gintonic> GetAll()
        {
            return _gintonicRepository.GetAll();
        }
        [HttpPost]
        public void Add([FromBody] Gintonic gintonic)
        {
            _gintonicRepository.Add(gintonic);
            _gintonicRepository.SaveChanges();
        }
    }
    
    

}
