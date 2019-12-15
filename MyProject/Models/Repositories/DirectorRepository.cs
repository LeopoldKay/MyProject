using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models.Repositories
{
    public class DirectorRepository : IDirectorRepository
    {
        public List<Director> GetDirectors()
        {
            var context = new NetCoreWebAppContext();
            return context.Directors.ToList();
        }
    }
}
