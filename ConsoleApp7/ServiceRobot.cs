using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class ServiceRobot : RobotPrototype
    {
        public string serviceTask;

        public ServiceRobot(string modelName, int batteryCapacity, string softwareVersion, string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.serviceTask = serviceTask;
        }

        public override RobotPrototype Clone()
        {
            return new ServiceRobot(modelName, batteryCapacity,
                softwareVersion, serviceTask);
        }

        public override void Display()
        {
            Console.WriteLine("Service Robot");
            Console.WriteLine("Model Name: " + modelName);
            Console.WriteLine("Battery Capacity: " + batteryCapacity + " hours");
            Console.WriteLine("Software Version: " + softwareVersion);
            Console.WriteLine("Service Task: " + serviceTask);
        }
    }
}
