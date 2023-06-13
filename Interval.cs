using System;

public class Interval
{
    private int[] data; // Fixed size primitive array of int type

    public Interval(int size)
    {
        data = new int[size]; // Initializing the array with the specified size
    }

    public void Dataset1()
    {
        // Populating the array with int data
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = i + 1; // Assigning consecutive values to the array elements
        }
    }

    public void CheckInterval()
    {
        // Iterating over the array and checking if each integer is within the interval 1-10
        foreach (int num in data)
        {
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("Inside 1-10");
            }
            else
            {
                Console.WriteLine("Outside 1-10");
            }
        }
    }
}
