using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTemperatures
{
    public class DailyQueue
    {
        private int[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;

        public DailyQueue(int size)
        {
            this.size = size;
            Queue = new int[size];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public void Insert(int o)
        {
            if ((count == size) || (rear == size - 1))
                throw new Exception("Queue is full.");
            if (front == -1)
                front = 0;
            Queue[++rear] = o;
            count++;
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

        public void TillWarmer()
        {
            if (IsEmpty())
                throw new Exception("Queue is empty.");

            for(int i = 0; i < size; i++)
            {
                bool foundWarmer = false;
                for(int j = i + 1; j < size; j++)
                {
                    if (Queue[j] > Queue[i])
                    {
                        Queue[i] = j - i;
                        foundWarmer = true;
                        break;
                    }
                }
                if (!foundWarmer)
                    Queue[i] = 0;
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            DailyQueue temperatures = new DailyQueue(8);
            temperatures.Insert(73);
            temperatures.Insert(74);
            temperatures.Insert(75);
            temperatures.Insert(71);
            temperatures.Insert(69);
            temperatures.Insert(72);
            temperatures.Insert(76);
            temperatures.Insert(73);
            temperatures.PrintQueue();
            Console.WriteLine();

            temperatures.TillWarmer();
            temperatures.PrintQueue();

            Console.ReadKey();
        }
    }
}