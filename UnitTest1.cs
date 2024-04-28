using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Pattern_Facade.Program;
using System;



namespace Pattern_Facade_Tests
{
    [TestClass]
    public class SubsystemBaltasarTests
    {
        [TestMethod]
        public void TestOperationDev()
        {
            var subsystem = new SubsystemBaltasar();
            var expected = "SubsystemBaltasar: Do you need a good devops?\n";
            Assert.AreEqual(expected, subsystem.operationDev());
        }

        [TestMethod]
        public void TestOperationOps()
        {
            var subsystem = new SubsystemBaltasar();
            var expected = "SubsystemBaltasar: I'm ready to start at any second!\n";
            Assert.AreEqual(expected, subsystem.operationOps());
        }

        [TestMethod]
        public void TestOperationDone()
        {
            var subsystem = new SubsystemBaltasar();
            var expected = "SubsystemBaltasar: I'll wait for feedback. Bye!\n";
            Assert.AreEqual(expected, subsystem.operationDone());
        }
    }

    [TestClass]
    public class SubsystemAskimTests
    {
        [TestMethod]
        public void TestOperationDesk()
        {
            var subsystem = new SubsystemAskim();
            var expected = "SubsystemAskim: Yes, we have a shortage of specialists in this field\n";
            Assert.AreEqual(expected, subsystem.operationDesk());
        }

        [TestMethod]
        public void TestOperationTop()
        {
            var subsystem = new SubsystemAskim();
            var expected = "SubsystemAskim: Great! I'll call you as soon as a vacancy opens\n";
            Assert.AreEqual(expected, subsystem.operationtop());
        }

        [TestMethod]
        public void TestOperationTooDone()
        {
            var subsystem = new SubsystemAskim();
            var expected = "SubsystemAskim: Awesome! See u soon.\n";
            Assert.AreEqual(expected, subsystem.operationTooDone());
        }
    }
    public class Facade
    {
        public void StartOperation(string userRole)
        {
            if (string.IsNullOrEmpty(userRole))
            {
                throw new ArgumentException("User role cannot be null or empty.");
            }

            if (userRole != "Admin" && userRole != "User")
            {
                throw new ArgumentException("Invalid user role.");
            }
        }
    }

    [TestClass]
    public class FacadeExceptionTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "User role cannot be null or empty.")]
        public void TestFacadeOperation_ThrowsException()
        {
            var facade = new Facade();

            // Виклик, який призводить до винятка
            facade.StartOperation(string.Empty);  // Це кидає ArgumentException
        }
    }


}
