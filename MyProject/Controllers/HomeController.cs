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

        public ViewResult ShowMovies()
        {
           
            ViewData["Movies"] = dataRepository.GetMovies();
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

        //метод задания 13 часть 1:
        public Movie Movie13Task(int zap)
        {
            return dataRepository.MovieFor13().FirstOrDefault(x => x.Id == zap); ;
        }
    }
}
