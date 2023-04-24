using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        int numItems;
        List<string> itemNames = new List<string>();
        List<string> itemTypes = new List<string>();

        Console.Write("Enter the number of items in your bag: ");
        numItems = int.Parse(Console.ReadLine());

        for (int i = 0; i < numItems; i++) {
            Console.Write("Enter the name of item {0}: ", i + 1);
            string name = Console.ReadLine();

            Console.Write("Enter the type of item {0} (excluding \"ShowAll\"): ", i + 1);
            string type = Console.ReadLine();

            itemNames.Add(name);
            itemTypes.Add(type);
        }

        Console.WriteLine();
        string mode;
        do {
            Console.Write("Enter a search mode (type \"ShowAll\" to display all items): ");
            mode = Console.ReadLine();
            Console.WriteLine();

            if (mode.Equals("ShowAll")) {
                for (int i = 0; i < itemNames.Count; i++) {
                    Console.WriteLine("{0} ({1})", itemNames[i], itemTypes[i]);
                }
                Console.WriteLine();
            }
            else {
                bool found = false;
                for (int i = 0; i < itemNames.Count; i++) {
                    if (itemTypes[i].Equals(mode)) {
                        Console.WriteLine(itemNames[i]);
                        found = true;
                    }
                }
                if (!found) {
                    Console.WriteLine("End");
                    break;
                }
                Console.WriteLine();
            }
        } while (true);
    }
}

