using System;

class RangeOfArray
{
    public int[] Array;
    public int StartIndex;
    public int EndIndex;

    public RangeOfArray(int start, int end)
    {
        if (start > end)
        {
            throw new ArgumentException("The initial index must be less than or equal to the final index.");
        }

        StartIndex = start;
        EndIndex = end;
        int size = end - start + 1;
        Array = new int[size];
    }

    public int this[int index]
    {
        get
        {
            if (IsInRange(index))
            {
                return Array[index - StartIndex];
            }
            else
            {
                throw new IndexOutOfRangeException("The index is outside the range of the array.");
            }
        }
        set
        {
            if (IsInRange(index))
            {
                Array[index - StartIndex] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("The index is outside the range of the array.");
            }
        }
    }

    private bool IsInRange(int index)
    {
        return index >= StartIndex && index <= EndIndex;
    }
}

class Program
{
    static void Main()
    {
        RangeOfArray Array = new RangeOfArray(6, 10);

        for (int i = 6; i <= 10; i++)
        {
            Array[i] = i * 2;
        }

        for (int i = 6; i <= 10; i++)
        {
            Console.WriteLine($"Element {i}: {Array[i]}");
        }
        Console.ReadKey();
    }
    
}
