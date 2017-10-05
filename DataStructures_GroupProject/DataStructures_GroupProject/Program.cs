//This program was prepared by Tomiris Mollinet
//IS 403 Section 001
// Description: This program will ask the user which type of data structure they want to work with. Then it will allow them to add, delete, display, search, add many, clear, and exit
//as prompted to or from the specific data type. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_GroupProject
{
    //make class named program
    class Program
    {
        //begin main class
        static void Main(string[] args)
        {
            //initialize variables
            int answer = 0;
            int choice = 0;
            int i = 0;
            string delete;
            int size;
            int j;
            string response;

            //create stack, queue, and dictionary
            Stack<string> myStack = new Stack<string>();
            Queue<string> myQueue = new Queue<string>();
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            TimeSpan timeElapsed;


            //check to see if the answer (beginning at 0) is 4. If it is, exit the loop and the program. If not, keep going
            while (answer != 4)
                {
                
                //Display menu
                Console.Write("\nChoose from the following:\n1.Stack\n2.Queue\n3.Dictionary\n4.Exit\n\n");

                //take user input for the answer to the main menu
                answer = Convert.ToInt32(Console.ReadLine());

                //begin this part if the user puts a 1 into the main menu
                if (answer == 1)
                {
                    //set choice to 0 
                    choice = 0;

                    //enter while loop. this loop ends when choice isn't 7. They can press seven to end it
                    while (choice != 7)
                    {
                        //Display sub menu
                        Console.WriteLine("\n\nChoose from the following:\n\n1. Add one item to Stack\n2.Add Huge List of Items to Stack\n3.Display Stack\n4.Delete from Stack\n5.Clear Stack\n6.Search Stack\n7.Return to Main Menu\n");

                        //take user input for choice
                        choice = Convert.ToInt32(Console.ReadLine());

                        //display if choice is 1
                        if (choice == 1)
                        {

                            //push the user input to the stack
                            Console.WriteLine("\nWhat would you like to add?\n");
                            myStack.Push(Console.ReadLine());
                        }

                        //display if choice is 2
                        else if (choice == 2)

                        {
                            //clear entire stack then fill stack with numbers from 1 to 2000 and the words "New Entry"
                            myStack.Clear();
                            for (i = 0; i< 2000; i++)
                            {
                                myStack.Push("New Entry " + (i + 1));
                            }
                           
                        }
                        //display if choice is 3
                        else if (choice == 3)
                        {

                            //Read stack in a foreach loop
                            Console.WriteLine();
                            foreach(string item in myStack)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        //display if choice is 4
                        else if (choice == 4)
                        {

                            //make a temporary stack to be filled with the other stack while we pop them off
                            Stack<string> tempStack = new Stack<string>();

                            //get user input for what they want to delete. Then loop through the main stack and pop them off, adding them to the temporary stack. 
                            Console.WriteLine("\nWhich item would you like to delete?\n");
                            delete = Console.ReadLine();
                            size = myStack.Count;
                            for (i = 0; i < size; i++)
                            {
                                if (delete == myStack.Peek())
                                {
                                    myStack.Pop();
                                }
                                else
                                {
                                    tempStack.Push(myStack.Pop());
                                }
                            }

                            //loop through the temporary stack and pop items off, adding them to the main stack again. 
                            int length = tempStack.Count;
                            for (j = 0; j < length; j++)
                            {
                                myStack.Push(tempStack.Pop());
                            }
                        }
                        //display if choice is 5
                        //clear the stack
                        else if (choice == 5)
                        {
                            myStack.Clear();
                        }
                        //display if choice is 6
                        else if (choice == 6)
                        {

                            //search through the stack and display the time it took to search or not find it.
                            Console.WriteLine("\nWhat would you like to search for?\n");
                            string searchText = Console.ReadLine();
                            sw.Start();
                                if(myStack.Contains(searchText))
                                {
                                    Console.WriteLine("\nYou found it!!!\n");
                                }
                                else
                                {
                                    Console.WriteLine("\nItem was not found\n");
                                }
                            sw.Stop();
                            timeElapsed = sw.Elapsed;
                            Console.WriteLine("Total elapsed time: " + timeElapsed);
                            }
                        //display if choice is 7 or something else
                        else
                        {
                            choice = 7;
                        }

                    }
                }

                //if the answer is 2, do this
                else if (answer == 2)
                {
                    //start the while loop
                    choice = 0;
                    while (choice != 7)
                    {

                        //Show menu
                        Console.WriteLine("\n\nChoose from the following:\n\n1. Add one item to Queue\n2.Add Huge List of Items to Queue\n3.Display Queue\n4.Delete from Queue\n5.Clear Queue\n6.Search Queue\n7.Return to Main Menu\n");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {

                            //add things to queue
                            Console.WriteLine("\nWhat would you like to add?\n");
                            myQueue.Enqueue(Console.ReadLine());
                        }
                        else if (choice == 2)

                        {
                            //clear things from queue then add 2000 items
                            myQueue.Clear();
                            for (i = 0; i < 2000; i++)
                            {
                                myQueue.Enqueue("New Entry " + (i + 1));
                            }

                        }
                        else if (choice == 3)
                        {
                            //display queue
                            Console.WriteLine();
                            foreach (string item in myQueue)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else if (choice == 4)
                        {

                            //delete something the user inputs to queue
                            Queue<string> tempQueue = new Queue<string>();
                            Console.WriteLine("\nWhich item would you like to delete?\n");
                            delete = Console.ReadLine();
                            size = myQueue.Count;

                            //for loop to check out queue and find the one they want to delete then delete it
                            for (i = 0; i < size; i++)
                            {
                                if (delete == myQueue.Peek())
                                {
                                    myQueue.Dequeue();
                                }
                                else
                                {
                                    tempQueue.Enqueue(myQueue.Dequeue());
                                }
                            }
                            int length = tempQueue.Count;
                            for (j = 0; j < length; j++)
                            {
                                myQueue.Enqueue(tempQueue.Dequeue());
                            }
                        }

                        //clear queue
                        else if (choice == 5)
                        {
                            myQueue.Clear();
                        }
                        
                        else if (choice == 6)
                        {
                            //search for the thing the user inputs in the queue
                            Console.WriteLine("\nWhat would you like to search for?\n");
                            string searchText = Console.ReadLine();
                            sw.Start();
                            if (myQueue.Contains(searchText))
                            {
                                Console.WriteLine("\nYou found it!!!\n");
                            }
                            else
                            {
                                Console.WriteLine("\nItem was not found\n");
                            }
                            sw.Stop();
                            timeElapsed = sw.Elapsed;
                            Console.WriteLine("Total elapsed time: " + timeElapsed);
                        }
                        else
                        {
                            choice = 7;
                        }

                    }
                }

                //do this if the main menu choice is 3
                else if (answer == 3)
                {
                    choice = 0;
                    while (choice != 7)
                    {

                        //display menu
                        Console.WriteLine("\n\nChoose from the following:\n\n1. Add one item to Dictionary\n2.Add Huge List of Items to Dictionary\n3.Display Dictionary\n4.Delete from Dictionary\n5.Clear Dictionary\n6.Search Dictionary\n7.Return to Main Menu\n");
                        choice = Convert.ToInt32(Console.ReadLine());

                        //add to dictionary
                        if (choice == 1)
                        {
                            Console.WriteLine("\nWhat would you like to add?\n");
                            response = Console.ReadLine();
                            myDictionary.Add(response, 1);
                        }

                        //clear dictionary and then add 2000 items to it
                        else if (choice == 2)

                        {
                            myDictionary.Clear();
                            for (i = 0; i < 2000; i++)
                            {
                                myDictionary.Add(("New Entry " + (i+1)), 1);
                            }

                        }

                        //display queue
                        else if (choice == 3)
                        {
                            Console.WriteLine();
                            foreach (KeyValuePair<string, int> entry in myDictionary)
                            {
                                Console.WriteLine(entry.Key);
                            }
                        }

                        //delete dictionary item that user inputs 
                        else if (choice == 4)
                        {
                            Dictionary<string, int> tempDictionary = new Dictionary<string, int>();
                            Console.WriteLine("\nWhich item would you like to delete?\n");
                            delete = Console.ReadLine();
                            size = myDictionary.Count;
                                if (myDictionary.ContainsKey(delete))
                                {
                                    myDictionary.Remove(delete);
                                }
                                else
                                {
                                    Console.WriteLine("Item does not exist in the dictionary");
                                }
                         }

                        //clear dictionary
                        else if (choice == 5)
                        {
                            myDictionary.Clear();
                        }

                        //search for users input in dictionary
                        else if (choice == 6)
                        {
                            Console.WriteLine("\nWhat would you like to search for?\n");
                            string searchText = Console.ReadLine();
                            sw.Start();
                            if (myDictionary.ContainsKey(searchText))
                            {
                                Console.WriteLine("\nYou found it!!!\n");
                            }
                            else
                            {
                                Console.WriteLine("\nItem was not found\n");
                            }
                            sw.Stop();
                            timeElapsed = sw.Elapsed;
                            Console.WriteLine("Total elapsed time: " + timeElapsed);
                        }
                        else
                        {
                            choice = 7;
                        }

                    }
                }

                //set answer to 4 if they put anything else
                else
                {
                    answer = 4;
                }
            }

        }
    }
}
