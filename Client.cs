using System;

namespace Facade.Conceptual
{


    class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }
}   