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
        private IDirectorRepository directorRepository;
        

        public HomeController(IDirectorRepository directorRepository)
        {
            this.directorRepository = directorRepository;
        }

        public ViewResult Index()
        {
           // ViewBag.view = "This is Test Index Page";
          return View();
        }

        public Director DirData(int id)
        {
            var dirData = directorRepository.GetDirectors().FirstOrDefault(x=>x.Id == id);
            return dirData;

        }
        public ViewResult DirData2(int id)
        {
            var dirData = directorRepository.GetDirectors().FirstOrDefault(x => x.Id == id);
            return View(dirData);

        }


        public ViewResult TestMethod()
        {
            var director = directorRepository.GetDirectors().FirstOrDefault(x => x.Id == 2);
            ViewBag.name = director.LastName;
            return View();
        }
    }
}
