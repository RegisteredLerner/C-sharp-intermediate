using System;

namespace SpaceMission
{
  class Program
  {
        static void Main(string[] args)
        {
            string[] spaceInventory;
            spaceInventory = new[]{"Space Suits","Oxygen Tanks","Food Supplies",
                "Medical Kits","Communication Devices","Fuel Canisters",
                "Navigation Tools","Repair Tools"};
            int[] itemQuantities = { 10, 8, 15, 5, 6, 9, 4, 7 };
            if (spaceInventory.Length == 8)
            {
                Console.WriteLine("Space Inventory is ready to go!");
            }
            else if (spaceInventory.Length > 8)
            {
                Console.WriteLine("Too many items!");
            }
            else
            {
                Console.WriteLine("Add more items!");
            }
            Console.WriteLine($"Second item of space inventory is {spaceInventory[1]}" +
            $"and its quantity is {itemQuantities[1]}");
            int index = Array.IndexOf(spaceInventory, "Repair Tools");
            spaceInventory[index] = "Scientific Instruments";
            itemQuantities[index] = 5;
            int find = Array.IndexOf(itemQuantities, 5);
            Console.WriteLine($"The first item with quantity 5 is at position {find+1}.");
            Array.Reverse(spaceInventory);
            Console.WriteLine(spaceInventory[0]);
            Console.WriteLine(spaceInventory[7]);
            Array.Sort(spaceInventory);
            Console.WriteLine(spaceInventory[0]);
            Console.WriteLine(spaceInventory[7]);

        }
  }
}