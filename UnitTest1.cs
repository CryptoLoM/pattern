using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pattern_Facade;

namespace Test_Facade
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
}
