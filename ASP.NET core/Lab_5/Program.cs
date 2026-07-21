using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A-1. Create an ArrayList for StudentName and perform following operations:
                    a. Add() - To Add new student in list
                    b. Remove() - To Remove Student with specified element
                    // RemoveAt() - To Remove Student with specified index
                    c. RemoveRange() - To Remove student with specified range.
                    d. Clear() - To clear all the student from the list.*/

            /* ArrayList al = new ArrayList();
             al.Add("Pratyush");
             al.Add("Mitesh");
             al.Add("Utsav(-1)");
             al.Add("Ayush");
             al.Add("Renish");

             void display()
             {
                 foreach (string i in al)
                 {
                     Console.WriteLine(i);
                 }
             }

             Console.WriteLine("Your ArrayList is : ");
             display();

            // RemoveAt() - To Remove Student with specified index

             al.Remove("Pratyush");
             Console.WriteLine("\nafter Remove(1) : ");
             display();

             al.RemoveRange(1,3);
             Console.WriteLine("\nafter RemoveRange(1,3) : ");
             display();

             al.Clear();
             Console.WriteLine("\nafter clear : ");
             display();*/

            //===============================================================================================


            /*A-2. Create a List for StudentName and perform following operations:
                    a. Add() - To Add new student in list
                    b. Remove() - To Remove Student with specified index
                    c. RemoveRange() - To Remove student with specified range.
                    d. Clear() - To clear all the student from the list.*/

            /*List<string> al = new List<string>();
            al.Add("Pratyush");
            al.Add("Mitesh");
            al.Add("Utsav(-1)");
            al.Add("Ayush");
            al.Add("Renish");

            void display()
            {
                foreach (string i in al)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Your List is : ");
            display();

            al.Remove("Pratyush");
            Console.WriteLine("\nafter Remove(1) : ");
            display();

            al.RemoveRange(1, 3);
            Console.WriteLine("\nafter RemoveRange(1,3) : ");
            display();

            al.Clear();
            Console.WriteLine("\nafter clear : ");
            display();*/

            //===============================================================================================


            /*A-3. Create a Stack which takes integer values and perform following operations:
                    a. Push() - To Add new item in stack
                    b. Pop() - To Remove item from the stack
                    c. Peek() – To Return the top item from the stack.
                    d. Contains() - To Checks whether an item exists in the stack or not.
                    e. Clear() - To clear items from stack.*/

            /*Stack<int> al = new Stack<int>();
            al.Push(1);
            al.Push(2);
            al.Push(3);
            al.Push(4);
            al.Push(5);
            al.Push(6);
            al.Push(7);

            Console.Write("Your stack is : ");
            foreach (int i in al)
            {
                Console.Write(i+", ");
            }
            
            Console.WriteLine("\nafter pop : " + al.Pop());
            Console.WriteLine("after peek : "+al.Peek());
            Console.WriteLine("after contains(4) : " + al.Contains(4));

            al.Clear();

            Console.WriteLine("after clear Your stack is : ");
            foreach (int i in al)
            {
                Console.WriteLine(i);
            }*/

            //===============================================================================================



            /*A-4. Create a Queue which takes integer values and perform following operations:
                    a. Enqueue() - Adds an item into the queue.
                    b. Dequeue() - Returns an item from the beginning of the queue and
                     removes it from the queue.
                    c. Peek() - Returns an first item from the queue without removing it.
                    d. Contains() - Checks whether an item is in the queue or not
                    e. Clear() - Removes all the items from the queue.*/


            /*Queue<int> al = new Queue<int>();
            al.Enqueue(1);
            al.Enqueue(2);
            al.Enqueue(3);
            al.Enqueue(4);
            al.Enqueue(5);
            al.Enqueue(6);
            al.Enqueue(7);

            Console.Write("Your Queue is : ");
            foreach (int i in al)
            {
                Console.Write(i+", ");
            }
            
            Console.WriteLine("\nafter Dequeue : " + al.Dequeue());
            Console.WriteLine("after peek : "+al.Peek());
            Console.WriteLine("after contains(4) : " + al.Contains(4));

            al.Clear();

            Console.WriteLine("after clear Your stack is : ");
            foreach (int i in al)
            {
                Console.WriteLine(i);
            }*/

            //===============================================================================================



            /*A-5. Create a Dictionary collection class object and preform following operations:
                    a. Add: Adds a key-value pair.
                    b. Remove: Removes a key-value pair by key.
                    c. ContainsKey: Checks if a key exists in the hashtable.
                    d. ContainsValue: Checks if a value exists in the hashtable.
                    e. Clear: Removes all key-value pairs.*/


            /*Dictionary<int,string> al = new Dictionary<int,string>();
            al.Add(1,"Pratyush");
            al.Add(2, "Mitesh");
            al.Add(3, "Utsav(-1)");
            al.Add(4, "Ayush");
            al.Add(5, "Renish");

            void display()
            {
                foreach (int i in al.Keys)
                {
                    Console.WriteLine(al[i]);
                }
            }
            Console.WriteLine("Your Dictionary is : ");
            display();

            al.Remove(1);
            Console.WriteLine("\nafter Remove(1) : ");
            display();

            Console.WriteLine("\nafter ContainsKey(1) : "+ al.ContainsKey(1));
            Console.WriteLine("\nafter ContainsValue("Mitesh") : " + al.ContainsValue("Mitesh"));

            al.Clear();
            Console.WriteLine("\nafter clear : ");
            display();*/

            //===============================================================================================



            /*A-6. Create a Hashtable collection class object and preform following operations:
                    a. Add: Adds a key-value pair.
                    b. Remove: Removes a key-value pair by key.
                    c. ContainsKey: Checks if a key exists in the hashtable.
                    d. ContainsValue: Checks if a value exists in the hashtable.
                    e. Clear: Removes all key-value pairs.*/


            /*Hashtable al = new Hashtable();
            al.Add(1,"Pratyush");
            al.Add(2, "Mitesh");
            al.Add(3, "Utsav(-1)");
            al.Add(4, "Ayush");
            al.Add(5, "Renish");

            void display()
            {
                foreach (int i in al.Keys)
                {
                    Console.WriteLine(al[i]);
                }
            }
            Console.WriteLine("Your Hashtable is : ");
            display();

            al.Remove(1);
            Console.WriteLine("\nafter Remove(1) : ");
            display();

            Console.WriteLine("\nafter ContainsKey(1) : "+ al.ContainsKey(1));
            Console.WriteLine("\nafter ContainsValue('Mitesh') : " + al.ContainsValue("Mitesh"));

            al.Clear();
            Console.WriteLine("\nafter clear : ");
            display();*/

            //===============================================================================================


        }
    }
}
