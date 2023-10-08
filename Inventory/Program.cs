using System;
using System.Collections.Generic;

class Inventory
{
    private List<string> items;

    public Inventory()
    {
        items = new List<string>();
    }

    public void AddItem(string itemName)
    {
        items.Add(itemName);
    }

    public void UseItem(string itemName)
    {
        if (items.Contains(itemName))
        {
            Console.WriteLine($"Using {itemName}...");
            items.Remove(itemName);
        }
        else
        {
            Console.WriteLine($"{itemName} not found in the inventory.");
        }
    }

    public void GetItems()
    {
        Console.WriteLine("Inventory Items:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Inventory System!");

        Inventory playerInventory = new Inventory();

        while (true)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Use Item");
            Console.WriteLine("3. View Inventory");
            Console.WriteLine("4. Exit");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the item name to add: ");
                    string itemToAdd = Console.ReadLine();
                    playerInventory.AddItem(itemToAdd);
                    break;
                case 2:
                    Console.Write("Enter the item name to use: ");
                    string itemToUse = Console.ReadLine();
                    playerInventory.UseItem(itemToUse);
                    break;
                case 3:
                    playerInventory.GetItems();
                    break;
                case 4:
                    Console.WriteLine("Exiting the Inventory System. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}
