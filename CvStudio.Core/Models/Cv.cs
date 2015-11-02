using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvStudio.Core.Models
{
    public class Cv
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname1 { get; set; }

        public string Surname2 { get; set; }

        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        public string PhotoUrl { get; set; }

        public List<Experience> Experiences { get; set; }

        public List<Awards> Awards { get; set; }
        
        public List<Skill> Skills { get; set; }  
    }
}
