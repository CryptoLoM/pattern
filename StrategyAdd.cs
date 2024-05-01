using System;


namespace Facade
{
    public class AdditionStrategy : IStrategy
    {
        public double Execute(double a, double b)
        {
            return a + b;
        }
    }
}
