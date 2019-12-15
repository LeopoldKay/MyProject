using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
//using MyProject.Controllers;
using MyProject.Models;
using MyProject.Models.Repositories;
using System.Collections.Generic;
//using Microsoft.AspNetCore.Mvc.Rendering;


namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          
           
            Mock<IDirectorRepository> directorRepository = new Mock<IDirectorRepository>();
            directorRepository.Setup(x => x.GetDirectors()).Returns(new List<Director>() { new Director() });
            //var homeController = new HomeController(directorRepository.Object);

          //var viewResult = homeController.DirData();
        }
    }
}
