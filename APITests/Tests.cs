using APIDemo;
using APIDemo.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APITests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void VerifyListOfUsers()
        {
            Demo demo = new Demo();
            var content = demo.GetUsers();
            Assert.AreEqual("7", content.data[0].id);
        }
    }
}
