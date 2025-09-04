using System;
using Microsoft.Win32.SafeHandles;

namespace DatingProfile
{
  class Program
  {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila",30,"New York","USA","he/him");
            string[] hobby ={"listening to audiobooks and podcasts",
                "playing rec sports like bowling",
                "writing a speculative fiction movie",
                "reading advice columns" };
            sam.SetHobbies(hobby);
            Console.WriteLine(sam.ViewProfile());
        }       
  }
}
