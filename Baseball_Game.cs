/*
You are keeping score for a baseball game with strange rules. The game consists of several rounds, where the scores of past rounds may affect future rounds' scores.

At the beginning of the game, you start with an empty record. You are given a list of strings ops, where ops[i] is the ith operation you must apply to the record and is one of the following:

An integer x - Record a new score of x.
"+" - Record a new score that is the sum of the previous two scores. It is guaranteed there will always be two previous scores.
"D" - Record a new score that is double the previous score. It is guaranteed there will always be a previous score.
"C" - Invalidate the previous score, removing it from the record. It is guaranteed there will always be a previous score.
Return the sum of all the scores on the record. The test cases are generated so that the answer fits in a 32-bit integer.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    public class ScoreStack
    {
        private int size;
        private int top;
        private int[] score;

        public ScoreStack(int size)
        {
            this.size = size;
            score = new int[size];
            top = -1;
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }

        public void Push(int data)
        {
            if (top < this.size - 1)
            {
                score[++top] = data;
            }
            else
                Console.WriteLine("Stack is full.");
        }

        public object Pop()
        {
            if (!IsEmpty())
            {
                return score[top--];
            }
            else
            {
                Console.WriteLine("Stack is empty.");
                return 0;
            }
        }

        public void SumLastTwo()
        {
            if (top >= 1)
            {
                int sum = score[top] + score[top - 1];
                Push(sum);
            }
            else
                Console.WriteLine("There must be at least two scores.");           
        }

        public void DoubleLast()
        {
            if (top >= 0)
                Push(score[top] * 2);
            else
                Console.WriteLine("There must be a previous score to double.");
        }

        public void InvalidateLast()
        {
            if (!IsEmpty())
                Pop();
            else
                Console.WriteLine("No scores to invalidate.");
        }

        public int GetSum()
        {
            int total = 0;
            for (int i = 0; i <= top; i++)
                total += score[i];
            return total;
        }

        public void Operations(string[] ops)
        {
            foreach(string operation in ops)
            {
                if (int.TryParse(operation, out int number))
                    Push(number);
                else if (operation == "+")
                    SumLastTwo();
                else if (operation == "D")
                    DoubleLast();
                else if (operation == "C")
                    InvalidateLast();
                else
                    Console.WriteLine($"Invalid operation: {operation}");
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            ScoreStack scoreStack = new ScoreStack(5);
            string[] operations = { "5", "2", "C", "D", "+" };
            scoreStack.Operations(operations);

            Console.WriteLine("Total score: " + scoreStack.GetSum());
            Console.ReadKey();
        }
    }
}