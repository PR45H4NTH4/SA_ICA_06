using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceRobot s1 = new ServiceRobot("SR-100", 10, "V1.0", "Helping patients");
            s1.Display();

            ServiceRobot s2 = (ServiceRobot)s1.Clone();
            s2.batteryCapacity = 12;
            s2.Display();



            IndustrialRobot i1 = new IndustrialRobot("IR-200", 15, "V2.0", "Welding");
            i1.Display();

            IndustrialRobot i2 = (IndustrialRobot)i1.Clone();
            i2.batteryCapacity = 18;
            i2.Display();



            EntertainmentRobot e1 = new EntertainmentRobot("ER-300", 8, "V3.0", "Dancing");
            e1.Display();

            EntertainmentRobot e2 = (EntertainmentRobot)e1.Clone();
            e2.batteryCapacity = 10;
            e2.Display();


            Console.ReadLine();
        }
    }
}