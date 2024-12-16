using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DequeImplementation
{
    public class Deque
    {
        object[] deque;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;

        public Deque(int size)
        {
            this.size = size;
            deque = new object[size];

        }

        public bool IsEmpty()
        {
            return (count==0);
        }

        public void InsertFirst(object o)
        {
            if (count == size)
                throw new Exception("Deque is full.");

            if (front == -1) 
            {
                front = 0;
                rear = 0;
            }
            else if (front == 0) 
            {
                front = size - 1;
            }
            else
            {
                front--;
            }

            deque[front] = o; 
            count++;
        }

        public void InsertLast(object o)
        {
            if (count == size)
                throw new Exception("Deque is full.");

            if (rear == -1)
            {
                front = 0;
                rear = 0;
            }

            if (rear == size - 1)
                rear = 0;
            else
                rear++;

            deque[rear] = o;
            count++;
        }

        public object DeleteFırst()
        {
            if (IsEmpty())
                throw new Exception("Deque is empty.");

            object deleted_value = deque[front];
            deque[front] = null;

            if (front == rear)
            {
                front = -1;
                rear = -1;
            }

            else if (front == size - 1)
                front = 0;
            else
                front++;

            count--;
            return deleted_value;
        }

        public object DeleteLast()
        {
            if (IsEmpty())
                throw new Exception("Deque is empty.");

            object deleted_value = deque[rear];
            deque[rear] = null;

            if (rear == front)
            {
                front = -1;
                rear = -1;
            }
            else if (rear == 0)
            {
                rear = size - 1;
            }
            else
                rear--;
            count--;
            return deleted_value;

        }

        public void PrintDeque()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Deque is empty.");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Deque are: ");
                int i = front;

                while (true)
                {
                    Console.WriteLine(deque[i] + " ");
                    if (i == rear)
                        break;
                    i = (i + 1) % size;
                }
                Console.WriteLine();
            }
        }

        internal class Program
        {
            private static void Main(string[] args)
            {
                Deque example = new Deque(5);
                Console.WriteLine("Is the deque empty?: " + example.IsEmpty());
                example.PrintDeque();
                Console.WriteLine();

                example.InsertFirst(10); //[10]
                example.PrintDeque();

                example.InsertLast(20); //[10,20]
                example.PrintDeque();

                example.InsertFirst(30); //[30,10,20]
                example.PrintDeque();

                example.InsertFirst(40); //[40,30,10,20]
                example.PrintDeque();

                example.InsertLast(50); //[40,30,10,20,50]
                example.PrintDeque();

                Console.WriteLine("Is the deque empty?: " + example.IsEmpty());

                example.DeleteFırst(); //[30,10,20,50]
                example.PrintDeque();

                example.DeleteLast(); //[30,10,20]
                example.PrintDeque();

                Console.ReadKey();
            }
        }

    }

}
