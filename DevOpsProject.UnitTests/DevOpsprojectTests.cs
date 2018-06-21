using DevOpsProject.Libs.GatewayManager;
using DevOpsProject.Models;
using DevOpsProject.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;

namespace DevOpsProject.UnitTests
{
    [TestClass]
    public class DevOpsprojectTests
    {    
        [TestMethod]
        public void SuccesGetListAsync()
        {
            //arrange
            Mock<GatewayManager> Mockconnection = new Mock<GatewayManager>();
            List<DataBasePerson> expected = new List<DataBasePerson>()
            {
                new DataBasePerson
                {
                    Id = 1,
                    Name = "Danny",
                    Age = 23
                },
                new DataBasePerson
                {
                    Id = 2,
                    Name = "Danny2",
                    Age = 24
                },

            };

            Mockconnection.Setup(mock => mock.GetlistAsync<DataBasePerson>(It.IsAny<string>())).ReturnsAsync(expected);

            //act
            var controller = new DatabaseController(Mockconnection.Object);
            var result = controller.Index().Result as ViewResult;

            //assert
            Assert.AreEqual(expected, result.Model);
        }

        [TestMethod]
        public void FailGetListAsync()
        {
            string exmessage = "kapot";
            //arrange
            Mock<GatewayManager> Mockconnection = new Mock<GatewayManager>();
            Mockconnection.Setup(mock => mock.GetlistAsync<DataBasePerson>(It.IsAny<string>())).Throws(new Exception(exmessage));
            //act
            var controller = new DatabaseController(Mockconnection.Object);
            var result = controller.Index().Result as ViewResult;
            //assert
            Assert.AreEqual(exmessage, ((List<DataBasePerson>)result.Model)[0].Name);
        }

        [TestMethod]
        public void SuccesPostAsync()
        {
            //arrange
            HttpResponseMessage rm = new HttpResponseMessage();
            DataBasePerson p = new DataBasePerson
            {
                Id = 5,
                Name = "DB",
                Age = 6
            };
            Mock<GatewayManager> Mockconnection = new Mock<GatewayManager>();
            DatabaseController controller = new DatabaseController(Mockconnection.Object);

            Mockconnection.Setup(mock => mock.PostAsync<DataBasePerson>(It.IsAny<string>(), p)).ReturnsAsync(rm);
            //act
            var result = controller.Create(p).IsCompletedSuccessfully;
            //assert
            Assert.AreEqual(rm.IsSuccessStatusCode,result);
        }
        [TestMethod]
        public void FailPostAsync()
        {
            //arrange
            HttpResponseMessage rm = new HttpResponseMessage();
            DataBasePerson p = new DataBasePerson
            {
                Id = 5,
                Name = "DB",
                Age = 6
            };
            Mock<GatewayManager> Mockconnection = new Mock<GatewayManager>();
            DatabaseController controller = new DatabaseController(Mockconnection.Object);

            Mockconnection.Setup(mock => mock.PostAsync<DataBasePerson>(It.IsAny<string>(), p)).ReturnsAsync(rm);
            //act
            var result = controller.Create(p).IsFaulted;
            //assert
            Assert.AreNotEqual(rm.IsSuccessStatusCode, result);
        }
    }
}
