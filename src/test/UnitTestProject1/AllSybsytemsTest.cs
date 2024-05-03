using Facade.Conceptual;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class SubsystemTests
    {
        [TestMethod]
        public void TestSubsystem1Operations()
        {
            var subsystem = new Subsystem1();

            Assert.AreEqual("Subsystem1: Ready!\n", subsystem.operation1());  // Перевірка операції 1
            Assert.AreEqual("Subsystem1: Go!\n", subsystem.operationN());  // Перевірка операції N
        }

        [TestMethod]
        public void TestSubsystem2Operations()
        {
            var subsystem = new Subsystem2();

            Assert.AreEqual("Subsystem2: Get ready!\n", subsystem.operation1());  // Перевірка операції 1
            Assert.AreEqual("Subsystem2: Fire!\n", subsystem.operationZ());  // Перевірка операції Z
        }
    }
}
