using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public class ArrayTypedStack
    {
        int MAX;
        int top;
        object[] stack;

        public bool IsEmpty()
        {
            return (top < 0);
        }

        public ArrayTypedStack(int MAX)
        {
            stack = new object[MAX];
            this.MAX = MAX;
            top = -1;
        }

        public void Push(int data)
        {
            if (top < this.MAX-1)
            {
                stack[++top] = data;
            }
        }

        public object Pop()
        {
            object deleted_value = new object();

            if (!IsEmpty())
            {
                deleted_value = stack[top--];
            }
            return deleted_value;
        }

        public object Peek()
        {
            object top_value = new object();
            if (top >= 0)
            {
                top_value = stack[top];
            }
            return top_value;
        }

        public void PrintStack()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The Stack is empty.");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are: ");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i].ToString());
                }
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            ArrayTypedStack stack = new ArrayTypedStack(7);

            Console.WriteLine("Pushing elements onto the stack: ");
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            stack.Push(60);
            stack.Push(70);

            stack.PrintStack();
            Console.WriteLine("\n");

            Console.WriteLine($"Top element (Peek): {stack.Peek()}");
            Console.WriteLine("\n");

            stack.Pop();
            stack.Pop();
            stack.PrintStack();
            Console.WriteLine("\n");

            Console.WriteLine($"Is the stack empty?: {stack.IsEmpty()} ");
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine($"Is the stack empty?: {stack.IsEmpty()} ");
            Console.ReadKey();

        }
    }
}
