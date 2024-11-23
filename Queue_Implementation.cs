using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Implementation
{
    public class SimpleArrayTypedQueue
    {
        private object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;

        public SimpleArrayTypedQueue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }
        public void Insert(object o)
        {
            if ((count == size) || (rear == size - 1))
                throw new Exception ("Queue is full.");

            if (front == -1)
                front = 0;
            Queue[++rear] = o;
            count++;
        }

        public object Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty.");
            }

            object deleted_value = Queue[front];
            Queue[front] = null;
            front++;
            count--;
            return deleted_value;
        }

        public object Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty.");
            }
            object top_value = Queue[front];
            return top_value;
        }

        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Queue are: ");
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(Queue[i].ToString());
                }
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            SimpleArrayTypedQueue queue = new SimpleArrayTypedQueue(7);

            Console.WriteLine("Inserting elements onto the queue: ");
            queue.Insert(10);
            queue.Insert(20);
            queue.Insert(30);
            queue.Insert(40);
            queue.Insert(50);
            queue.Insert(60);
            queue.Insert(70);

            queue.PrintQueue();
            Console.WriteLine("\n");

            Console.WriteLine($"The first element of the Queue(Peek): {queue.Peek()}");
            Console.WriteLine("\n");

            queue.Remove();
            queue.Remove();
            queue.PrintQueue();
            Console.WriteLine("\n");
            Console.WriteLine($"Is the stack empty?: {queue.IsEmpty()} ");
            queue.Remove();
            queue.Remove();
            queue.Remove();
            queue.Remove();
            queue.Remove();
            Console.WriteLine($"Is the stack empty?: {queue.IsEmpty()} ");
            Console.ReadKey();

        }
    }
}

