// See https://aka.ms/new-console-template for more information
using Trainning = DEM.DotNet.DataStructure.HashTableSeparateChain;

int size = 7;
Trainning.LinkedList[] table = new  Trainning.LinkedList[size];

for (int n = 0; n < size; n++)
    table[n] = new Trainning.LinkedList();

Show();
Console.WriteLine("------------");

Insert(57, "Hola");
Insert(45, "Manzana");
Insert(42, "Pera");
Insert(83, "Azul");
Insert(30, "Rojo");
Insert(94, "C#");
Insert(73, "C++");
Insert(97, "Saludos");

Show();

Console.WriteLine("------------");








void Show()
{
    int n = 0;
    for (n = 0; n < size; n++)
    {
        Console.Write("({0})", n);
        table[n].Traverse();
        Console.WriteLine();
    }
}

int HashFunction(int key)
{
    int index = 0;
    index = key % size;
    return index;
}

void Insert(int key, string value) 
{
    int index = HashFunction(key);
    table[index].Add(key, value);

}