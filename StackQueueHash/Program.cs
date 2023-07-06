using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueHash
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================Stack====================================");
            Stack stack = new Stack();
            // Push, Pop, Peek

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            stack.Pop(); //removes the top element in the collections

            Console.WriteLine($"Top element in the stack {stack.Peek()}");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("=========================Queue===================================");

            // Queue --> FIFO (first in first out)
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            queue.Dequeue();//remove the first element- 10

            Console.WriteLine($"first element in the list {queue.Peek()}");
            Console.WriteLine($"total elements in the queue {queue.Count}");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("============================HashTable========================================");

            Hashtable hashtable = new Hashtable();
            hashtable.Add(91, "IND");
            hashtable.Add(63, "AUS");
            hashtable.Add(1, "USA");

            hashtable.Remove(63);

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

            Console.WriteLine("========================Hashtable Mobile===================================");

            Hashtable hashtable1 = new Hashtable();
            hashtable1.Add(9834533629, "Pratik");
            hashtable1.Add(8796759722, "Pankaj");
            hashtable1.Add(9890266208, "Sagar");

            //hashtable1.Remove();

            foreach (DictionaryEntry item in hashtable1)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
        }
    }
}
