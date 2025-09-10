using System;
using System.Collections.Generic;

public class InventoryManagement
{
    public static void Main(string[] args)
    {
        // Your code goes here
        List<string> inventoryList = new List<string>();
        inventoryList.Add("Printer");
        inventoryList.Add("Laptop");
        inventoryList.Add("Desk Chair");
        inventoryList.Add("Monitor");
        inventoryList.Add("Keyboard");
        Console.WriteLine(inventoryList.Count);
        bool hasDeskChair = inventoryList.Contains("Desk Chair");
        Console.WriteLine(hasDeskChair);
        bool removed = inventoryList.Remove("Printer");
        Console.WriteLine(removed);
        foreach (string inv in inventoryList)
        {
            Console.WriteLine(inv);
        }
        List<string> newItems = new List<string> { "Mouse", "Desk Lamp" };
        inventoryList.AddRange(newItems);
        inventoryList.RemoveRange(4, 2);
        List<string> topInventory = inventoryList.GetRange(0, 3);
        foreach (string top in topInventory)
        {
            Console.WriteLine(top);
        }

  }
}