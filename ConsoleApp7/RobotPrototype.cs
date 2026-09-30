using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal abstract class RobotPrototype
    {
        public string modelName;
        public int batteryCapacity;
        public string softwareVersion;

        public RobotPrototype(string modelName, int batteryCapacity, string softwareVersion)
        {
            this.modelName = modelName;
            this.batteryCapacity = batteryCapacity;
            this.softwareVersion = softwareVersion;
        }

        public abstract RobotPrototype Clone();

        public abstract void Display();
    }
}
}
