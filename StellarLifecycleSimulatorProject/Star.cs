using System;
using System.Security.Cryptography.X509Certificates;
namespace StarLifecycleSimulator
{
    public class Star
    {
        public string name;
        public string type;
        public int age;
        public double brightness;
        public Star(string name, string type)
        {
            this.name = name;
            this.age = 0;
            this.brightness = 1.0;
            this.type = type;
        }
        public Star(string name)
        {
            this.name = name;
            this.type = "Unknown";
            Console.WriteLine("Unknown type");
        }
        public void Shine()
        {
            Console.WriteLine($"Star {this.name} is shining with brightness {this.brightness}");
        }
        public void GrowOlder()
        {
            this.age += 1;
            this.brightness *= 0.9;
        }
        public void Supernova()
        {
            this.brightness = 0;
            Console.WriteLine($"Star {this.name} has exploded in supernova");
        }
    }
}