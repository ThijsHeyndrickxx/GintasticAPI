using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GintasticAPI.DTOs
{
    public class GintonicDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set;}

        [Required]

        public string Taste { get; set;}
    }
}
