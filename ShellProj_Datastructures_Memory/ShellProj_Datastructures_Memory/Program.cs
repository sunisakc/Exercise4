﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellProj_Datastructures_Memory
{
    class Program
    {
        /// <summary>
        /// The main method, will handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            bool run = true;
            while (true)
            {

                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();


            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}

            

            List<string> theList = new List<string>();
            //string[] name = new string[0];

            theList.Add("Anna");
            theList.Add("Plura");
            theList.Add("Bog");
            theList.Add("Delli");
            theList.Add("Mina");

            Console.WriteLine(theList);
            foreach (string name in theList)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("\nRemove(\"name from the list\")");
            theList.Remove("Mina");

            Console.WriteLine();
            foreach (string name in theList)
            {
                Console.WriteLine(name);
            }

            theList.Count();


            Console.WriteLine("\nCapacity: {0}", theList.Capacity);
            Console.WriteLine("Count: {0}", theList.Count);
            string inputItem = Console.ReadLine();
            char nav = inputItem[0];
            string value = inputItem.Substring(1);

            Console.WriteLine("Please add name to the list or remove name from the list"
                   + "\n+. Add name"
                   + "\n-. Remove name");
            char input = ' ';
            try
            {
                input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
            }
            catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
            {
                Console.Clear();
                Console.WriteLine("Please enter some input!");
            }
            
            switch (inputItem)
            {
                case "+":
                    theList.Add(Console.ReadLine());
                    //for (int i = 0; i < name.Length; i++)
                    //{
                    //    name[i] = Console.ReadLine();
                    //}
                    break;

                   
                case "-":
                    theList.Remove(Console.ReadLine());
                    break;
                case "0":

                    return;
                default:
                    Console.WriteLine("Please enter some valid input + or - ");
                    break;
            }

            
            
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */


        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            Stack<string> name = new Stack<string>();
            name.Push("Kalle");
            name.Push("Greta");
            name.Push("Stina");
            name.Push("Olle");

            Console.Write("ICA queue:");
            foreach (string qname in name)
                Console.Write(qname + " ");


            while (true)
            {

                Console.WriteLine("Please choose to add or remove name from the queuefrom 1, 2, 3, or 4 to reverstext input"
                    + "\n1. Please remove from queue"
                    + "\n2. Please add name to queue"
                    + "\n3. Check current queue"
                    + "\n4. Please input text to reverse"
                    + "\n0. Exit ");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':

                        Console.WriteLine("Please remove name '{0}", name.Pop());
                        Console.WriteLine("The next person to dequeue: {0}", name.Peek());
                        Console.WriteLine("The next person is '{0}'", name.Pop());

                        break;
                    case '2':
                        Console.Write("Add new person to the queue");
                        name.Push(Console.ReadLine());

                        break;

                    case '3':

                        Console.WriteLine("Current queue:");
                        foreach (string qname in name)
                            Console.Write(qname + "\n ");

                        break;

                    case '4':

                        Console.WriteLine("Reverse input Text");
                        Console.ReadLine();
                        foreach (string qname in name)
                            Console.Write(qname + "\n ");

                        break;

                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3)");
                        break;

                }
            }
        }
    

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})]
             * Example of incorrect: (()]), [), {[()}]
             */
        }

    }
}
