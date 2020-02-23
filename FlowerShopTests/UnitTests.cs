using NUnit.Framework;
using NSubstitute;
using Order;


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
            Order x = new Order("Daises","Ana", false);
            Order orderMock = Mock.Create<IOrderDAO>();
            Mock.Arrange(() => orderMock.SetDeliver("Daises").Returns(true));

            // Act 
            x.Deliver();

            //Assert
            Assert.IsTrue(x.Deliver());



        }
    }
}