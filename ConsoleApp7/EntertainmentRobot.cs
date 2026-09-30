using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class EntertainmentRobot : RobotPrototype
    {
        public string entertainmentFeature;

        public EntertainmentRobot(string modelName, int batteryCapacity, string softwareVersion, string entertainmentFeature)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.entertainmentFeature = entertainmentFeature;
        }

        public override RobotPrototype Clone()
        {
            return new EntertainmentRobot(modelName, batteryCapacity,
                softwareVersion, entertainmentFeature);
        }

        public override void Display()
        {
            Console.WriteLine("Entertainment Robot");
            Console.WriteLine("Model Name: " + modelName);
            Console.WriteLine("Battery Capacity: " + batteryCapacity + " hours");
            Console.WriteLine("Software Version: " + softwareVersion);
            Console.WriteLine("Entertainment Feature: " + entertainmentFeature);
        }
    }
}