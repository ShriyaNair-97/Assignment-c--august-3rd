using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MyArray = { "Zebra", "Ant", "Owl", "Lion", "Tiger" };
            Console.WriteLine("\nDisplaying the names in MyArray by For loop");
            for (int i = 0; i < MyArray.Length; i++)
            {
                
                Console.WriteLine("\n",MyArray[i]);
            }
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("\nDisplaying the names in MyArray by ForEach loop");
            foreach (string a in MyArray)
            {
               
                Console.WriteLine("\n",a);
            }
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("\nDisplaying the names in MyArray by Do-While loop");
            int j = 0;
            do
            {
               
                Console.WriteLine(MyArray[j]);
                j++;
            } while (j <= MyArray.Length);
            Console.WriteLine("\n-------------------------------------");
            int k = 0;
            Console.WriteLine("\nDisplaying the names in MyArray by Do-While loop");
            while (k < MyArray.Length)
            {
              
                Console.WriteLine("\n",MyArray[k]);
                k++;
            }
            Console.WriteLine("\n-------------------------------------");
            Array.Sort(MyArray);
            Console.WriteLine("\nSorted List");
            for (int l = 0; l < MyArray.Length; l++)
            {
                Console.Write(MyArray[l] + " ");
            }
            Console.WriteLine("\n-------------------------------------");
            string[] Animal = { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };

            Array.Sort(Animal);

            Console.WriteLine("\nDisplaying the names in Animal by ForEach loop");
            foreach (string a1 in Animal)
            {
                Console.WriteLine("\n",a1);
            }
            Console.WriteLine("\n-------------------------------------");
            string[] Places = { "Africa", "New Zealand", "Jamaica", "India" };
            Array.Sort(Places);
            Console.WriteLine("\nDisplaying the names in Places by ForEach loop");
            foreach (string p in Places)
            {
            
                Console.WriteLine("\n",p);
            }
        }
    }
    }

