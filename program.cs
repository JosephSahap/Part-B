using System;

class Program
{
    static void Main()
    {
        string[,] ourAnimals = new string[8, 6];
        int petCount = 4;
        ourAnimals[0, 0] = "ID #: d1";
        ourAnimals[0, 1] = "Species: dog";
        ourAnimals[0, 2] = "Age: 2";
        ourAnimals[0, 3] = "Nickname: lola";
        ourAnimals[0, 4] = "Physical description: medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
        ourAnimals[0, 5] = "Personality: loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
        
        ourAnimals[1, 0] = "ID #: d2";
        ourAnimals[1, 1] = "Species: dog";
        ourAnimals[1, 2] = "Age: 9";
        ourAnimals[1, 3] = "Nickname: loki";
        ourAnimals[1, 4] = "Physical description: large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
        ourAnimals[1, 5] = "Personality: loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";

        ourAnimals[2, 0] = "ID #: c3";
        ourAnimals[2, 1] = "Species: cat";
        ourAnimals[2, 2] = "Age: 1";
        ourAnimals[2, 3] = "Nickname: Puss";
        ourAnimals[2, 4] = "Physical description: small white female weighing about 8 pounds. litter box trained.";
        ourAnimals[2, 5] = "Personality: friendly";

        ourAnimals[3, 0] = "ID #: c4";
        ourAnimals[3, 1] = "Species: cat";
        ourAnimals[3, 2] = "Age: ?";
        ourAnimals[3, 3] = "Nickname: ";
        ourAnimals[3, 4] = "Physical description: ";
        ourAnimals[3, 5] = "Personality: ";

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1 - List all pets");
            Console.WriteLine("2 - Add a new pet");
            Console.WriteLine("3 - Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                for (int i = 0; i < petCount; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                        Console.WriteLine(ourAnimals[i, j]);
                }
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "2" && petCount < 8)
            {
                string species = "";
                while (species != "dog" && species != "cat")
                {
                    Console.Write("Enter 'dog' or 'cat': ");
                    species = Console.ReadLine().ToLower();
                }

                string id = species.Substring(0, 1) + (petCount + 1);
                Console.Write("Enter age or ? if unknown: ");
                string age = Console.ReadLine();
                Console.Write("Enter physical description: ");
                string description = Console.ReadLine();
                Console.Write("Enter personality: ");
                string personality = Console.ReadLine();
                Console.Write("Enter nickname: ");
                string nickname = Console.ReadLine();

                ourAnimals[petCount, 0] = "ID #: " + id;
                ourAnimals[petCount, 1] = "Species: " + species;
                ourAnimals[petCount, 2] = "Age: " + age;
                ourAnimals[petCount, 3] = "Nickname: " + (nickname == "" ? "tbd" : nickname);
                ourAnimals[petCount, 4] = "Physical description: " + (description == "" ? "tbd" : description);
                ourAnimals[petCount, 5] = "Personality: " + (personality == "" ? "tbd" : personality);
                petCount++;

                Console.WriteLine("Pet added! Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "3")
                break;
            else
                Console.WriteLine("Invalid choice! Press Enter to try again.");
        }
    }
}
