int[] intArray = { 1, 2, 3, 7, 20, 30, 54};
Console.WriteLine(BinarySearch(intArray, 54));

int BinarySearch(int[] intArray, int value)
{
    int start = 0;
    int end = intArray.Length;

    while(start < end)
    {
        int midpoint = (start + end) / 2;
        if(intArray[midpoint] == value)
        {
            return intArray[midpoint];
        }
        else if (intArray[midpoint] < value)
        {
            start = midpoint + 1;
        }
        else
        {
            end = midpoint;
        }
    }
    return -1;
}
