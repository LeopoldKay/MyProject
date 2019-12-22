using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using MyProject.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        private IDataRepository dataRepository;
        

        public HomeController(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }

        public ViewResult Index()
        {
          return View();
        }

       
        public Director DirData2(int id)
        {
           
            var dirData = dataRepository.GetDirectorTest().FirstOrDefault(x => x.Id == id);
            return dirData;

        }

        public ViewResult ShowMovies()
        {
           
            ViewData["Characters"] = dataRepository.GetMovies();
            return View();
        }

        public ViewResult Description()
        {

           ViewData["Description"] = dataRepository.Description();
            return View();
        }

        public ViewResult ShowActors()
        {

            ViewData["Actors"] = dataRepository.GetActors();
            return View();
        }

        public ViewResult ShowDirectors()
        {

            ViewData["Directors"] = dataRepository.GetDirectors();
            return View();
        }

        public ViewResult ShowGenres()
        {

            ViewData["Genres"] = dataRepository.Genres();
            return View();
        }

        public ViewResult TestMethod()
        {
            var director = dataRepository.GetDirectors().FirstOrDefault(x => x.DirectorName == "Locas");
            ViewBag.name = director.DirectorName;
            return View();
        }
    }
}
