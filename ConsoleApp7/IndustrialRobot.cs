using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class IndustrialRobot : RobotPrototype
    {
        public string industrialTask;

        public IndustrialRobot(string modelName, int batteryCapacity, string softwareVersion, string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.industrialTask = industrialTask;
        }

        public override RobotPrototype Clone()
        {
            return new IndustrialRobot(modelName, batteryCapacity,
                softwareVersion, industrialTask);
        }

        public override void Display()
        {
            Console.WriteLine("Industrial Robot");
            Console.WriteLine("Model Name: " + modelName);
            Console.WriteLine("Battery Capacity: " + batteryCapacity + " hours");
            Console.WriteLine("Software Version: " + softwareVersion);
            Console.WriteLine("Industrial Task: " + industrialTask);
        }
    }
}