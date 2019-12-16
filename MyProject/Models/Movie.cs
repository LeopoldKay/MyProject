using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DirectorID { get; set; }
        public int ActorID { get; set; }
    }
}
