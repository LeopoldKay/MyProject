﻿using Microsoft.AspNetCore.Mvc;
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

        public Director DirData(int id)
        {
            var dirData = dataRepository.GetDirectors().FirstOrDefault(x=>x.Id == id);
            return dirData;

        }
        public ViewResult DirData2(int id)
        {
           
            var dirData = dataRepository.GetDirectors().FirstOrDefault(x => x.Id == id);
            return View(dirData);

        }

        public ViewResult ShowMovies()
        {
           
            ViewData["Characters"] = dataRepository.GetMovies();
            return View();
        }

        public ViewResult TestMethod()
        {
            var director = dataRepository.GetDirectors().FirstOrDefault(x => x.Id == 2);
            ViewBag.name = director.LastName;
            return View();
        }
    }
}
