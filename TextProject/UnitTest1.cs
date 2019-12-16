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
            characterRepository.Setup(x => x.GetDirectors()).Returns(new List<Director>() { new Director() });
            var homeController = new HomeController(characterRepository.Object);

            var viewResult = homeController.DirData2(2);
            //var dirType = new Director();

            var character = viewResult.ViewData["dirData"];
            
            Assert.IsInstanceOfType(viewResult, typeof(Director));

        }

        private Type GetType(Director dirType)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TestMethod2()
        {
            Mock<IDataRepository> characterRepository = new Mock<IDataRepository>();
            characterRepository.Setup(x => x.GetDirectors()).Returns(new List<Director>() { new Director() });
            var homeController = new HomeController(characterRepository.Object);

            var viewResult = homeController.DirData(2).FirstName;
            string name = "Martin";

            Assert.AreSame(viewResult, name);

        }
    }
}
