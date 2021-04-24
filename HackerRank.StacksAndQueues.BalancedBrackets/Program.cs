using System;
using System.Collections.Generic;

namespace HackerRank.StacksAndQueues.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isBalanced("{"));
            Console.WriteLine(isBalanced(")"));
            Console.WriteLine(isBalanced(")))"));
            Console.WriteLine(isBalanced("((("));
            Console.WriteLine(isBalanced("{[()]}"));
            Console.WriteLine(isBalanced("{[(])}"));
            Console.WriteLine(isBalanced("{{[[(())]]}}"));
        }

        static string isBalanced(string s)
        {
            var stack = new Stack<char>();
            foreach(var character in s)
            {
                if(character == '(' || character == '{' || character == '[')
                {
                    stack.Push(character);
                }
                else
                {
                    if(stack.Count == 0)
                    {
                        return "NO";
                    }

                    var popedCharacter = stack.Pop();
                    if(!(popedCharacter == '(' && character == ')' || popedCharacter == '{' && character == '}' || popedCharacter == '[' && character == ']'))
                    {
                        return "NO";
                    }
                }
            }

            return stack.Count == 0 ? "YES" : "NO";
        }
    }
}
