using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementStackUsingQueues
{
    public class StackUsingQueue
    {
        private object[] StackQueue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;

        public StackUsingQueue(int size)
        {
            this.size = size;
            StackQueue = new object[size];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public void Push(object o)
        {
            if ((count == size) || (rear == size - 1))
            {
                throw new Exception("Stack is full.");
            }

            if (front == -1)
                front = 0;

            StackQueue[++rear] = o;
            count++;
        }

        public object Top()
        {
            if (IsEmpty())
                throw new Exception("Stack is empty.");

            object top_value = StackQueue[rear];
            Console.WriteLine("Top value: " + top_value);
            return top_value;
        }

        public object Pop()
        {
            if (IsEmpty())
                throw new Exception("Stack is empty.");

            object deleted_value = StackQueue[rear];
            StackQueue[rear] = null;
            rear--;
            count--;
            return deleted_value;
        }

        public void PrintStackQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are: ");
                for (int i = front; i <= rear; i++)
                    Console.WriteLine(StackQueue[i].ToString());
            }
        }
    }
      
    internal class Program
    {
        private static void Main(string[] args)
        {
            StackUsingQueue example = new StackUsingQueue(5);

            example.PrintStackQueue();
            Console.WriteLine();

            example.Push(1);
            example.Push(2);
            example.Push(3);
            example.Push(4);
            example.Push(5);
            example.PrintStackQueue();

            example.Top();
            Console.WriteLine();

            example.Pop();
            example.PrintStackQueue();
            example.Top();
            Console.WriteLine();

            example.Push(77);
            example.PrintStackQueue();
            example.Top();

            Console.ReadKey();
        }
    }
}