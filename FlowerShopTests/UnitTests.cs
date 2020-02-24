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
            
            // Arrange 
            //IOrderDAO o = new Order( 1049, Ana);
            
            IClient c = Substitute.For<IClient>();
            IOrderDAO e = Substitute.For<IOrderDAO>();
            IOrder s = new Order(e,c);
           
            
            //IOrderDAO orderMock = Mock.Create<IOrderDAO>();
            //x.Arrange(() => orderMock.SetDeliver(x).Returns(true));

            // Act 
            s.Deliver();

            //Assert
            e.Received().SetDelivered(s);



        }
    }
}