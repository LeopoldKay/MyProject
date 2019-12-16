using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models.Repositories
{
    public interface IDataRepository
    {
        List<Director> GetDirectors();
        List<MovieSelect> GetMovies();
        List<Actor> GetActors();
        //List<Cast> GetCasting();
    }
}
