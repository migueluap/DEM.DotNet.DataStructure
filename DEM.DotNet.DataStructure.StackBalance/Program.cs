// See https://aka.ms/new-console-template for more information
using Trainning = DEM.DotNet.DataStructure.StackBalance;


string expression = "";
char s = ' ';
Trainning.Stack stack = new Trainning.Stack();

Console.WriteLine("Give the expression to evaluate");
expression = Console.ReadLine();

foreach (char c in expression)
{
    if (c == '(' || c == '{' || c == '[')
        stack.Push(c);


    if (c == ')' || c == '}' || c == ']')
    {
        if (stack.EmptyStack())
        {
            Console.WriteLine("Excess Closing Symbols");
        }
        else
        {
            s = stack.Pop();

            if (s == '(' && c != ')')
            {
                Console.WriteLine("We are waiting )");
            }

            if (s == '{' && c != '}')
            {
                Console.WriteLine("We are waiting }");
            }

            if (s == '[' && c != ']')
            {
                Console.WriteLine("We are waiting ]");
            }
        }
    }
}

if (stack.EmptyStack() == false)
     Console.WriteLine("Excess opening symbols");
