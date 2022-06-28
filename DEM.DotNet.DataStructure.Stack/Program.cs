// See https://aka.ms/new-console-template for more information

using Trainning = DEM.DotNet.DataStructure.Stack;

Trainning.Stack stack = new Trainning.Stack();

stack.Push(5);
stack.Push(3);
stack.Push(10);

stack.Traverse();

Console.WriteLine(stack.Pop());

stack.Traverse();

Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Peek());
stack.Traverse();
