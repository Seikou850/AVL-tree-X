using System;
using Binary_Search_Tree;

namespace AVLTreeLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("|---------------------------------------------------------|");
            System.Console.WriteLine("|      Type from 1 to 10 the words you want to add.       |");
            System.Console.WriteLine("|---------------------------------------------------------|");
            Console.Write("Type number here: ");

            string buffer = "";
            var numWords = Convert.ToInt32(Console.ReadLine());
            AVLTree<string> tree = new AVLTree<string>();

            string[] words = new string[11]
                { "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth", "" };

            for (int i = 0; i < numWords; i++)
            {
                Console.Write("Add the " + words[i] + " word of the list: ");
                words[numWords] = Console.ReadLine();
                tree.InsertItem(words[numWords]);
            }

            tree.Height(); // Prints the height of the tree

            tree.InOrder(ref buffer);
            Console.WriteLine("Items store in the AVL tree are the following: ");
            Console.WriteLine(buffer);

            string bufferX = "Items in order: ";
            tree.Display(ref bufferX);
            Console.WriteLine(bufferX);

            Console.Write("Type here the word you want to check if it is present on the tree: ");
            string checkWord = Console.ReadLine();

            Console.Write("Item present: ");
            var present = tree.Contains(checkWord);
            Console.WriteLine(present);
            

            // string products = words[numWords];
            // occurrences(products);
        }
    }
}