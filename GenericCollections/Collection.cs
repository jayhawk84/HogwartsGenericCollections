using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections
{
    class Collection
    {
        public static List<string> CreateList()
        {
            List<string> collectionItem = new List<string>();
            foreach (string house in new string[]
            { "Gryffindor", "Slytherin", "Ravenclaw", "Hufflepuff", "Dragontamers" })
            {
                collectionItem.Add(house);
            }
            return collectionItem;
        }
        public static void PrintList(List<string> items)
        {
            Console.WriteLine("Here is a list of Hogwarts Houses.");
            foreach (var x in items)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
        }

        public static LinkedList<string> CreateLinkedList()
        {
            LinkedList<string> collectionItem = new LinkedList<string>();
            foreach (string position in new string[]
            { "Chaser one", "Chaser two", "Chaser three", "Beater one", "Beater two", "Keeper", "Seeker" })
            {
                collectionItem.AddLast(position);
            }
            collectionItem.AddLast("Best Player");
            return collectionItem;
        }
        public static void PrintLinkedList(LinkedList<string> items)
        {
            Console.WriteLine("Every house has a quidditch team.  Here are the various positions in a linked list.");
            foreach (var x in items)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
        }
        public static Queue<string> CreateQueue()
        {
            Queue<string> collectionItem = new Queue<string>();

            foreach (string featuredCharacter in new string[]
            { "Harry Potter", "Hermione Granger", "Ronald Weasley", "Lord Voldemort", "Rubeus Hagrid", "Albus Dumbledore", "Severus Snape" })
            {
                collectionItem.Enqueue(featuredCharacter);
            }
            return collectionItem;
        }
        public static void PrintQueue(Queue<string> items)
        {
            Console.WriteLine("Here is a Queue of prominent characters in the Harry Potter saga.");
            foreach (var x in items)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
        }

        public static Stack<string> CreateStack()
        {
            Stack<string> collectionItem = new Stack<string>();
            foreach (string magicFood in new string[]
            { "Bertie Bott\'s Every Flavour Beans", "Chocolate Frogs", "Pumpkin Pasties", "Cauldron Cakes","Treacle Tart" })
            {
                collectionItem.Push(magicFood);
            }
            return collectionItem;
        }
        public static void PrintStack(Stack<string> items)
        {
            Console.WriteLine("Stack of magic food follows.");
            foreach (var x in items)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
        }

        public static Dictionary<string, string> CreateDictionary()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>()
            {
                ["Gryffindor House"] = "Nearly Headless Nick",
                ["Slytherin House"] = "the Bloody Baron",
                ["Ravenclaw House"] = "the Grey Lady",
                ["Hufflepuff House"] = "the Fat Friar",
                ["History of Magic"] = "Professor Binns",
                ["Hogwarts Bathroom"] = "Moaning Myrtle"

            };
            return keyValuePairs;
        }
        public static void PrintDictionary(Dictionary<string, string> keyValuePairs)
        {
            Console.WriteLine("Dictionary of ghosts");
            foreach (KeyValuePair<string, string> element in keyValuePairs)
            {
                string entity = element.Key;
                string ghost = element.Value;
                Console.WriteLine($"The {entity} ghost is {ghost}");
            }
            Console.WriteLine("\n");
        }
        public static SortedList<int, string> CreateSortedList()
        {
            SortedList<int, string> keyValuePairs = new SortedList<int, string>()
            {
                {5, "Gryffindor " },
                {1, "I " },
                {3, "the " },
                {4, "newest " },
                {2, "am " },
                {6, "seeker." }
            };
            return keyValuePairs;
        }
        public static void PrintSortedList(SortedList<int, string> keyValuePairs)
        {
            Console.WriteLine("Sorted list of what I see in the Mirror of Erised");
            foreach (KeyValuePair<int, string> element in keyValuePairs)
            {
                double number = element.Key;
                string word = element.Value;
                Console.Write(word);
            }
            Console.WriteLine("\n");
        }
        public static void PrintEverything()
        {
            PrintList(CreateList());
            PrintLinkedList(CreateLinkedList());
            PrintQueue(CreateQueue());
            PrintStack(CreateStack());
            PrintDictionary(CreateDictionary());
            PrintSortedList(CreateSortedList());
        }
    }
}
