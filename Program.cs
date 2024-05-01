using System;

namespace Pattern_Facade
public class Program
{
    private static void Main(string[] args)
    {
        var additionContext = new Context(new AdditionStrategy());
        Console.WriteLine("3 + 5 = " + additionContext.ExecuteStrategy(3, 5));

        var multiplicationContext = new Context(new MultiplicationStrategy());
        Console.WriteLine("3 * 5 = " + multiplicationContext.ExecuteStrategy(3, 5));
    }
}
