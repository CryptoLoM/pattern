using Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StrategyAddTest
{

    public class AdditionStrategyTests
    {

        public void TestAddition()
        {
            var strategy = new AdditionStrategy();
            Assert.AreEqual(8, strategy.Execute(3, 5));
            Assert.AreEqual(0, strategy.Execute(0, 0));
        }
    }

}