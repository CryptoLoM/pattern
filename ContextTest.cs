using Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.Remoting.Contexts;

namespace ContextTest
{


    public class ContextT
    {

        public void TestAdditionStrategy()
        {
            var context = new Facade.Context(new AdditionStrategy());
            Assert.AreEqual(8, context.ExecuteStrategy(3, 5));
        }


        public void TestMultiplicationStrategy()
        {
            var context = new Facade.Context(new MultiplicationStrategy());
            Assert.AreEqual(15, context.ExecuteStrategy(3, 5));
        }
    }
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