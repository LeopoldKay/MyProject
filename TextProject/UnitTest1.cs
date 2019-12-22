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
            characterRepository.Setup(x => x.GetDirectorTest()).Returns(new List<Director>() { new Director() });
            var homeController = new HomeController(characterRepository.Object);

            var viewResult = homeController.DirData2(1);
            var dirType = new Director();

            //var character = viewResult.ViewData["dirData"];
            
            Assert.IsInstanceOfType(viewResult, typeof(Director));

        }

        [TestMethod]
        public void TestMethod2()
        {

            var repo = new DataRepository();
            var dirList =  repo.GetDirectors();
            

            Assert.IsInstanceOfType(dirList, typeof(List<DirSelect>));

        }


    }
}
