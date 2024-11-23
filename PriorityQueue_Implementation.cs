using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    public class PriorityQueue
    {
        private object[] Queue;
        private int front = -1;
        private int size = 0;
        private int count = 0;

        public PriorityQueue(int size)
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
            if (count == size)
                throw new Exception("Queue is full.");
            if (IsEmpty())
            {
                front++;
                Queue[front] = o;
            }
            else
            {
                int i;
                for (i = count - 1; i >= 0; i--)
                {
                    if ((int)o < (int)Queue[i])
                        Queue[i + 1] = Queue[i];
                    else
                        break;
                }
                Queue[i + 1] = o;
                front++;
            }
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
            front--;
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

            Console.WriteLine("Items in the Queue: ");
            for (int i = 0; i <= front; i++)
            {
                Console.WriteLine(Queue[i]);
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            PriorityQueue queue = new PriorityQueue(5);

            Console.WriteLine("Inserting elements onto the queue: ");
            queue.Insert(10);
            queue.Insert(20);
            queue.Insert(60);
            queue.Insert(30);
            queue.Insert(40);

            queue.PrintQueue();
            Console.WriteLine("\n");


            queue.Remove();
            queue.Remove();

            queue.PrintQueue();
            Console.WriteLine("\n");


            Console.WriteLine($"The first element of the Queue(Peek): {queue.Peek()}");
            Console.WriteLine("\n");

            Console.WriteLine($"Is the queue empty?: {queue.IsEmpty()}");

            queue.Remove();
            queue.Remove();
            queue.Remove();
            Console.WriteLine($"Is the queue empty?: {queue.IsEmpty()}");


            Console.ReadKey();
        }
    }
}
