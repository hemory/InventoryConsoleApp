using System;
using System.Collections.Generic;

namespace Assessment2_Walkthrough
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = new List<string>
            {
                "broccoli",
                "tomatoes",
                "zucchini"
            };

            bool returnToMain = true;
            while (returnToMain)
            {


                Console.Write("[1]Add Items [2]Remove an item [3]View Inventory: ");
                string userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        Console.Write("Enter number of items to add: ");
                        int numberOfItems = int.Parse(Console.ReadLine());

                        for (int i = 0; i < numberOfItems; i++)
                        {
                            Console.Write("Enter item: ");
                            inventory.Add(Console.ReadLine());
                        }

                        bool validChoice = false;

                        while (validChoice == false)
                        {
                            Console.Write("Return to Main [y]es or [n]o: ");
                            string returnChoice = Console.ReadLine().ToLower();

                            if (returnChoice == "n")
                            {
                                returnToMain = false;
                                validChoice = true;
                            }
                            else if (returnChoice == "y")
                            {
                                validChoice = true;
                            }
                        }
                        
                        break;

                    case "2":
                        bool removeAgain = true;
                        while (removeAgain)
                        {
                            Console.Write("Enter item to remove: ");
                            string itemToRemove = Console.ReadLine();

                            bool isRemoved = inventory.Remove(itemToRemove);

                            if (isRemoved)
                            {
                                Console.WriteLine("Item was removed.");
                            }
                            else
                            {
                                Console.WriteLine("Unsuccessful removal");
                            }
                            
                            validChoice = false;

                            while (validChoice == false)
                            {
                                Console.Write("Remove another item [y]es or [n]o: ");
                                string choiceToRemove = Console.ReadLine().ToLower();

                                if (choiceToRemove == "n")
                                {
                                    validChoice = true;
                                    removeAgain = false;
                                }
                                else if (choiceToRemove == "y")
                                {
                                    validChoice = true;
                                }
                            }
                        }

                        validChoice = false;

                        while (validChoice == false)
                        {
                            Console.Write("Return to Main [y]es or [n]o: ");
                            string returnChoice = Console.ReadLine().ToLower();

                            if (returnChoice == "n")
                            {
                                returnToMain = false;
                                validChoice = true;
                            }
                            else if (returnChoice == "y")
                            {
                                validChoice = true;
                            }
                        }

                        break;

                    case "3":
                        foreach (var item in inventory)
                        {
                            Console.WriteLine(item);
                        }
                        
                        validChoice = false;

                        while (validChoice == false)
                        {
                            Console.Write("Return to Main [y]es or [n]o: ");
                            string returnChoice = Console.ReadLine().ToLower();

                            if (returnChoice == "n")
                            {
                                returnToMain = false;
                                validChoice = true;
                            }
                            else if (returnChoice == "y")
                            {
                                validChoice = true;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Please make a valid choice.");
                        break;
                }
            }

        }
    }
}