using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NSubstitute;
using FlowerShop;
using Moq;


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();
            // Arrange 
            // IOrderDAO orderMock = Mock.Create<IOrderDAO>();
            //Mock<IVendorBriefRepository> mock = new Mock<IVendorBriefRepository>();
            Mock<IOrderDAO> orderMock = new Mock<IOrderDAO>();
            Mock<IClient> clientMock = new Mock<IClient>();
            Order x = new Order(orderMock, clientMock, false);
            //IOrderDAO orderMock = Mock.Create<IOrderDAO>();
            Mock.Arrange(() => orderMock.SetDeliver(x).Returns(true));

            // Act 
            x.Deliver();

            //Assert
            Assert.IsTrue(x.Deliver());



        }
    }
}