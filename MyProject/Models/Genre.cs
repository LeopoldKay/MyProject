using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public int MovieID { get; set; }
    }
}
