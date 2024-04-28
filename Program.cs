using System;

namespace Pattern_Facade
{
     public class Program
    {


        public class Facade
        {

            protected SubsystemBaltasar _subsystembaltasarik;

            protected SubsystemAskim _subsystemaskimik;

            public Facade(SubsystemBaltasar subsystembaltasarik, SubsystemAskim subsystemaskimik)
            {
                this._subsystembaltasarik = subsystembaltasarik;
                this._subsystemaskimik = subsystemaskimik;
            }
            public string Operation()
            {
                string result = "Start of Facade dialog between subsystems:\n";
                result += this._subsystembaltasarik.operationDev();
                result += this._subsystemaskimik.operationDesk();
                result += "\n";
                result += "Subsystem orders subsystem to perform the action:\n";
                result += this._subsystembaltasarik.operationOps();
                result += this._subsystemaskimik.operationtop();
                result += "\n";
                result += "End of Facade dialog between subsystems:\n";
                result += this._subsystembaltasarik.operationDone();
                result += this._subsystemaskimik.operationTooDone();

                return result;
            }
            
           
               
           
        }

        public class SubsystemBaltasar
        {
            public string operationDev()
            {
                return "SubsystemBaltasar: Do you need a good devops?\n";
            }

            public string operationOps()
            {
                return "SubsystemBaltasar: I'm ready to start at any second!\n";
            }
            public string operationDone()
            {
                return "SubsystemBaltasar: I'll wait for feedback. Bye!\n";
            }

        }

        public class SubsystemAskim
        {
            public string operationDesk()
            {
                return "SubsystemAskim: Yes, we have a shortage of specialists in this field\n";
            }

            public string operationtop()
            {
                return "SubsystemAskim: Great! I'll call you as soon as a vacancy opens\n";
            }
            public string operationTooDone()
            {
                return "SubsystemAskim: Awesome! See u soon.\n";
            }
        }


        class Client
        {
            public static void ClientCode(Facade facade)
            {
                Console.Write(facade.Operation());
            }
        }

        class Programs
        {
            static void Main(string[] args)
            {
                SubsystemBaltasar subsystembaltasarik = new SubsystemBaltasar();
                SubsystemAskim subsystemaskimik = new SubsystemAskim();
                Facade facade = new Facade(subsystembaltasarik, subsystemaskimik);
                Client.ClientCode(facade);
            }
        }
    }
}

