using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyProject.Controllers;
using MyProject.Models;
using MyProject.Models.Repositories;
using System;
using System.Collections.Generic;

namespace TextProject
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            Mock<IDataRepository> characterRepository = new Mock<IDataRepository>();
            characterRepository.Setup(x => x.GetDirectors()).Returns(new List<DirSelect>() { new DirSelect() {} });
            var homeController = new HomeController(characterRepository.Object);
            
            
            var dirList = homeController.ShowDirectors();
            var dirType = dirList.ViewData["Directors"];

            Assert.IsInstanceOfType(dirType, typeof(List<DirSelect>));

        }

        [TestMethod]
        public void TestMethod2()
        {
            Mock<IDataRepository> characterRepository = new Mock<IDataRepository>();
            characterRepository.Setup(x => x.GetMovies()).Returns(new List<MovieSelect>() { new MovieSelect() { } });
            var homeController = new HomeController(characterRepository.Object);


            var dirList = homeController.ShowMovies();
            var dirType = dirList.ViewData["Movies"];

            Assert.IsInstanceOfType(dirType, typeof(List<MovieSelect>));

        }

        [TestMethod]
        public void TestMethod3()
        {
            Mock<IDataRepository> characterRepository = new Mock<IDataRepository>();
            characterRepository.Setup(x => x.GetActors()).Returns(new List<ActorSelect>() { new ActorSelect() { } });
            var homeController = new HomeController(characterRepository.Object);


            var dirList = homeController.ShowActors();
            var dirType = dirList.ViewData["Actors"];

            Assert.IsInstanceOfType(dirType, typeof(List<ActorSelect>));

        }

        [TestMethod]
        public void TestMethod4()
        {
            Mock<IDataRepository> characterRepository = new Mock<IDataRepository>();
            characterRepository.Setup(x => x.Description()).Returns(new List<DescSelect>() { new DescSelect() { } });
            var homeController = new HomeController(characterRepository.Object);


            var dirList = homeController.Description();
            var dirType = dirList.ViewData["Description"];

            Assert.IsInstanceOfType(dirType, typeof(List<DescSelect>));

        }

        [TestMethod]
        public void TestMethod5()
        {
            Mock<IDataRepository> characterRepository = new Mock<IDataRepository>();
            characterRepository.Setup(x => x.Genres()).Returns(new List<GenreSelect>() { new GenreSelect() { } });
            var homeController = new HomeController(characterRepository.Object);


            var dirList = homeController.ShowGenres();
            var dirType = dirList.ViewData["Genres"];

            Assert.IsInstanceOfType(dirType, typeof(List<GenreSelect>));

        }


    }
}
