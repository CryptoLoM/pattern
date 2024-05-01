using System;

namespace Facade
{
    public class MultiplicationStrategy : IStrategy
    {
        public double Execute(double a, double b)
        {
            return a * b;
        }
    }
}
