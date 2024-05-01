using System;


namespace Facade
{
    public class Context
    {
        private readonly IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public double ExecuteStrategy(double a, double b)
        {
            return _strategy.Execute(a, b);
        }
    }
}
