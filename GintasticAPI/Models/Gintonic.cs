using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GintasticAPI.Models
{
    public class Gintonic
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Taste { get; set; }

        [Required]
        public string Description { get; set; }

        public Gintonic()
        {
                
        }
        public Gintonic(string name, string taste, string description) : this()
        {
            Name = name;
            Taste = taste;
            Description = description;
        }
    }
}
