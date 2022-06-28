// See https://aka.ms/new-console-template for more information
using Trainning = DEM.DotNet.DataStructure.Queue;

Trainning.Queue queue = new Trainning.Queue();

queue.Enqueue(5);
queue.Enqueue(3);
queue.Enqueue(7);
queue.Enqueue(1);

queue.Traverse();

int value = queue.Dequeue();
Console.WriteLine("Value acquired {0}", value);
queue.Traverse();



queue.Enqueue(8);
queue.Traverse();

Console.WriteLine("Value observerd is {0}", queue.Peek());
queue.Traverse();