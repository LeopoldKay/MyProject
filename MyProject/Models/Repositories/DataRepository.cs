using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models.Repositories
{
    public class DataRepository : IDataRepository
    {
        public List<DescSelect> Description()
        {
            var context = new NetCoreWebAppContext();
            var DescSelect = from dsc in context.Description
                             join mov in context.Movie on dsc.MovieID equals mov.Id
                             join dir in context.Directors on dsc.DirectorID equals dir.Id
                             join act in context.Actors on dsc.ActorID equals act.DirectorID
                             select new DescSelect { MovieName = mov.Name, DirectorName = dir.FirstName, DirectorLastName = dir.LastName, ActorName = act.FirstName, ActorLastName = act.LastName, Description = dsc.Description };
            return DescSelect.ToList();
        }

        public List<GenreSelect> Genres()
        {
            var context = new NetCoreWebAppContext();
            var genreSelect = from gen in context.Genres
                              join mov in context.Movie on gen.MovieID equals mov.Id
                              select new GenreSelect { GenreName = gen.GenreName, MovieName = mov.Name};
            return genreSelect.ToList();
        }

        public List<ActorSelect> GetActors()
        {
            var context = new NetCoreWebAppContext();
            var actorSelect = from act in context.Actors
                              join mov in context.Movie on act.MovieID equals mov.Id
                              select new ActorSelect { Movie = mov.Name, ActorName = act.FirstName, ActorLastName = act.LastName};
            return actorSelect.ToList();
        }

        
        public List<DirSelect> GetDirectors()
        {
            var context = new NetCoreWebAppContext();
            var directorSelect = from dir in context.Directors
                              join mov in context.Movie on dir.MovieID equals mov.Id
                              select new DirSelect { Movie = mov.Name,  DirectorName = dir.FirstName, DirectorLastName = dir.LastName };
            return directorSelect.ToList();
        }

        public List<MovieSelect> GetMovies()
        {
            var context = new NetCoreWebAppContext();
            var movieSelect = from m in context.Movie
                              join d in context.Directors on m.DirectorID equals d.Id
                              join a in context.Actors on m.ActorID equals a.Id
                              select new MovieSelect { Name = m.Name,  DirectorName = d.FirstName, DirectorLastName = d.LastName, ActorName = a.FirstName, ActorLastName = a.LastName  };
            return movieSelect.ToList();

        }


    }
}
