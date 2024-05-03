using Microsoft.VisualStudio.TestTools.UnitTesting;

using Facade.Conceptual;  

namespace Tests
{
    [TestClass]
    public class FacadeTests
    {
        [TestMethod]
        public void TestFacadeOperation()
        {
            // Організація
            var subsystem1 = new Subsystem1();
            var subsystem2 = new Subsystem2();
            var facade = new Facade.Conceptual.Facade(subsystem1, subsystem2);

            // Очікуване значення
            var expected = "Facade initializes subsystems:\n" +
                           "Subsystem1: Ready!\n" +
                           "Subsystem2: Get ready!\n" +
                           "Facade orders subsystems to perform the action:\n" +
                           "Subsystem1: Go!\n" +
                           "Subsystem2: Fire!\n";

            // Виконання
            var result = facade.Operation();

            // Перевірка
            Assert.AreEqual(expected, result);  // Перевіряємо, чи правильний результат
        }
    }
}
