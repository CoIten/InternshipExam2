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

            //Pushes an element to the stack
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

            //Pops an element from the stack
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
                // If character is a starting bracket, push it to the stack
                if (sequence[i] == '(')
                    br.Push(sequence[i]);

                // If character is an ending bracket, pop it from the stack
                if (sequence[i] == ')')
                {
                    // In case ending bracket 
                    // appears before a starting bracket
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

            // If stack is empty, brackets are in order
            if (br.Count == 0)
                return true;
            else
            {
                return false;
            }
        }

    }
}
