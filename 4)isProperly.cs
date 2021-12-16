using System;
using System.Collections.Generic;

namespace Brackets_isProperly
{
    class Program
    {

        class stack
        {
            public int top = -1;
            public char[] items = new char[100];


            public void push(char x)
            {
                if (top == 99)
                {
                    Console.WriteLine("Stack is full");
                }
                else
                {
                    items[++top] = x;
                }
            }

            char pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Underflow error");
                    return '\0';
                }
                else
                {
                    char element = items[top];
                    top--;
                    return element;
                }
            }

            bool isEmpty()
            {
                return (top == -1) ? true : false;
            }
        }



        static void Main(string[] args)
        {
            string seq1 = "(()())";
            string seq2 = "(())(";
            bool isPr1 = isProperly(seq1);
            if (isPr1 == true)
                Console.WriteLine($" {seq1}   Is Properly");
            else
                Console.WriteLine($" {seq1}   Is Wrong");

            bool isPr2 = isProperly(seq2);
            if (isPr2 == true)
                Console.WriteLine($" {seq2}   Is Properly");
            else
                Console.WriteLine($" {seq2}   Is Wrong");

        }


        static bool isProperly(string sequence)
        {
            Stack<char> br = new Stack<char>();

            for (int i = 0; i < sequence.Length; ++i)
            {

                if (sequence[i] == '(')
                    br.Push(sequence[i]);

                if (sequence[i] == ')')
                {
                    if (br.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        br.Pop();
                    }
                }
            }

            if (br.Count == 0)
                return true;
            else
            {

                return false;
            }
        }

    }
}
