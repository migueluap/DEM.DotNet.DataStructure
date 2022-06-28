// See https://aka.ms/new-console-template for more information
using DEM.DotNet.DataStructure.HashTableOpenAdressing;

int quantity = 11;
Cell[] table = new Cell[quantity];


int n = 0;

for (n = 0; n < quantity; n++)
{
    table[n] = new Cell();
}

//Show();

Insert(23, "Hola");
Insert(51, "Manzana");
Insert(40, "Pero");
Insert(62, "Mango");

Show();


void Show()
{
    for (int i = 0; i < quantity; i++)
    {
        Console.WriteLine("{0} [{1},{2}]", i, table[i].Key, table[i].Value);
    }
}

int HashFunction(int key, int nroTentative)
{
    //Lineal probing
    int index = 0;
    //index = (key + nroTentative) % quantity;

    //Quadratic probing
    index = (key + nroTentative * nroTentative) % quantity;

    return index;
}

void Insert(int key, string valuee)
{
    int tentativeCount = 1;
    int index = 0;
    bool isBusy = false;

    while (isBusy == false)
    {
        index = HashFunction(key, tentativeCount);

        if (table[index].Estado == Estado.empty)
        {
            isBusy = true;
            table[index].Key = key;
            table[index].Value = valuee;
            table[index].Estado = Estado.busy;
        }
        else 
        {
            tentativeCount++;
        }
    }
}

