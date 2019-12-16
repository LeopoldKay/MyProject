using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models.Repositories
{
    public class DataRepository : IDataRepository
    {
        public List<Actor> GetActors()
        {
            var context = new NetCoreWebAppContext();
            return context.Actors.ToList();
        }

        
        public List<Director> GetDirectors()
        {
            var context = new NetCoreWebAppContext();
            return context.Directors.ToList();
        }

        public List<MovieSelect> GetMovies()
        {
            var context = new NetCoreWebAppContext();
            var movieSelect = from d in context.Directors
                              from a in context.Actors
                              join md in context.Movie on d.Id equals md.DirectorID
                              join ma in context.Movie on a.Id equals ma.ActorID
                              select new MovieSelect { Name = md.Name,  DirectorName = d.FirstName, DirectorLastName = d.LastName, ActorName = a.FirstName, ActorLastName = a.LastName  };
            return movieSelect.ToList();

        }
    }
}
