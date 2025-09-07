using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);

            Satellite sputnik = new Satellite("Sputnik", 1957);
            Rover[] rovers = new Rover[] { lunokhod, apollo, sojourner };
            DirectAll(rovers);
            Object[] probes = new Object[] { lunokhod, apollo, sojourner, sputnik };
            foreach (Object obj in probes)
            {
                Console.WriteLine($"Tracking a {obj.GetType()}");
            }
            IDirectable[] directables = new IDirectable[] { lunokhod, apollo, sojourner, sputnik };
            DirectAl(directables);

        }
        public static void DirectAll(Rover[] roveryk)
        {
            foreach (Rover r in roveryk)
            {
                Console.WriteLine(r.GetInfo());
                Console.WriteLine(r.Explore());
                Console.WriteLine(r.Collect());
            }

        }
        public static void DirectAl(IDirectable[] directable)
        {
            foreach (IDirectable i in directable)
            {
                Console.WriteLine(i.GetInfo());
                Console.WriteLine(i.Explore());
                Console.WriteLine(i.Collect());
           }
        
        }
  }
}
