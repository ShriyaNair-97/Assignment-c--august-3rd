using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            Console.WriteLine("Enter Your First String :");
            str1 = Console.ReadLine();
            
            string str2;
            Console.WriteLine("Enter Your Second String :");
            str2 = Console.ReadLine();
            
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("String Functions to be performed \n 1.Concatenate the two strings\n 2.Length of two string\n" +
                " 3.Substrings for the input Strings\n 4.Replace the strings\n 5.To show the strings in 'UPPERCASE' \n " +
                "6.To show the strings in 'lowercase'\n 7.To trim the string entered \n" +
                " 8.To split the strings entered by the user\n 9.Press 9 to Exit");
            Console.WriteLine("Enter the index of the function you want to perform");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Concatenate the two strings");
                string strConcat = string.Concat(str1, str2);
                Console.WriteLine("The concatenated string :{0}", strConcat);
            }
            else if (x == 2)
            {
                Console.WriteLine("Find the length of two strings");
                int length1 = 0;
                foreach (char chr in str1)
                {
                    length1 += 1;

                }
                Console.Write("Length of the string first is : {0}\n", length1);
                int length2 = 0;
                foreach (char chr in str2)
                {
                    length2 += 1;

                }
                Console.Write("Length of the string second is : {0}\n", length2);
            }
            else if (x == 3)
            {
                Console.WriteLine("First string- Substring from index 4 = " + str1.Substring(4));
                Console.WriteLine("Second string- Substring from index 8 = " + str2.Substring(8));
            }
            else if (x == 4)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Replace words from two strings");
                Console.WriteLine("Replaced first string : " + str1.Replace("For", "This"));
                Console.WriteLine("Replaced second string : " + str2.Replace("those", "sing"));
            }
            else if (x == 5)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Changing the strings in 'UPPERCASE' the two strings");
                Console.WriteLine(str1.ToUpper());
                Console.WriteLine(str2.ToUpper());
            }
            else if (x == 6)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Changing the strings in 'lowercase' the two strings");
                Console.WriteLine(str1.ToLower());
                Console.WriteLine(str2.ToLower());
            }
            else if (x == 7)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Trim the two strings");
                string trim = ((str1.Trim() + " " +str2.Trim()));
                Console.WriteLine("The trimmed result is " + trim + ".");


            }
            else if (x == 8)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Split the two strings");
                string[] array = str1.Split('.');
                foreach (string value in array)
                {
                    Console.WriteLine($"{value}");
                }
                string[] array1 = str2.Split('.');
                foreach (string value in array1)
                {
                    Console.WriteLine($"{value}");
                }
            }
            else
            {
                Console.WriteLine("Enter any key to exit");
            }

        }
    }
}
