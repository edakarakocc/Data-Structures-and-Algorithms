using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNode
{
    public class Node
    {
        public int Data;
        public Node Next;
    }

    public class LinkedList
    {
        public Node Head;
        public int size = 0;

        public void InsertFirst(int value)
        {
            Node newFırst = new Node { Data = value };

            if (Head == null)
                Head = newFırst;
            else
            {
                newFırst.Next = Head;
                Head = newFırst;
            }
            size++;
        }

        public void InsertLast(int value)
        {
            Node newLast = new Node { Data = value };

            if (Head == null)
                Head = newLast;
            else
            {
                Node oldLast = Head;
                while (oldLast != null)
                {
                    if (oldLast.Next != null)
                        oldLast = oldLast.Next;
                    else
                        break;
                }
                oldLast.Next = newLast;
            }
            size++;
        }

        public void RemoveNth(int n)
        {
            if(n<0 || n >= size)
            {
                Console.WriteLine("Invalid n value.");
                return;
            }

            int pos = size - 1 - n;

            if (pos == 0)
            {
                Head = Head.Next;
            }
            else
            {
                Node current = Head;
                for(int i = 0; i < pos - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
            }
            size--;
        }

        public void PrintList()
        {
            if (Head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            LinkedList example = new LinkedList();
            example.InsertFirst(10);
            example.InsertLast(20);
            example.InsertLast(30);
            example.InsertLast(40);
            example.InsertLast(45);
            example.PrintList();

            example.RemoveNth(2);
            example.PrintList();

            Console.ReadLine();
        }
    }

}