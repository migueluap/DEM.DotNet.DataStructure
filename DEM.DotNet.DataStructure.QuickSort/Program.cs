 int [] myList = { 3, 15, 7, 19, 11, 1};
Console.WriteLine(string.Join(",", myList));

QuickSort(0, myList.Length - 1);

Console.WriteLine(string.Join(",", myList));



void Swap(int i1, int i2)
{ 
    int temp = myList[i1];
    myList[i1] = myList[i2];
    myList[i2] = temp;
}

int Partition(int IndexStart, int IndexEnd)
{
    int pivot = 0;
    int indexPivot = 0;
    int n = 0;

    //take the last pivot
    pivot = myList[IndexEnd];

    //put pivot index with the index start
    indexPivot = IndexStart;

    //go through the list
    for (n = IndexStart; n < IndexEnd; n++)
    {
        if (myList[n] <= pivot)
        {
            Swap(n, indexPivot);
            indexPivot++;
        }
    }

    Swap(indexPivot, IndexEnd);

    return indexPivot;
}

void QuickSort(int IndexStart, int IndexEnd)
{
    int indexPivot = 0;

    if (IndexStart >= IndexEnd)
        return;

    indexPivot = Partition(IndexStart, IndexEnd);

    //inductive case
    QuickSort(IndexStart, indexPivot - 1);
    QuickSort(indexPivot + 1, IndexEnd);
}