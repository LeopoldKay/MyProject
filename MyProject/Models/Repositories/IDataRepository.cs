using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models.Repositories
{
    public interface IDataRepository
    {
        List<DirSelect> GetDirectors();
        List<MovieSelect> GetMovies();
        List<ActorSelect> GetActors();
        List<DescSelect> Description();
        List<GenreSelect> Genres();
        List<Director> GetDirectorTest();
    }
}
