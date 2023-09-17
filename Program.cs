using System;
using System.Runtime.InteropServices;
namespace HelloWorld { 
class Program
{
static void Main()
{
    int[] array = new int[10];
    int n = array.Length;
    Console.WriteLine("Enter " + n + " numbers in the array.");
    for (int i = 0; i < n ; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Bubblesort(array, n);
    Console.WriteLine("The numbers are sorted");
    for (int i = 0; i < n ; i++)
    {
        Console.Write("|" + array[i]);
    }

    Console.WriteLine("");
    Console.WriteLine("Enter the number you are searching for");
    int searchN = 0;
    searchN = Convert.ToInt32(Console.ReadLine());
    int result = BinarySearch(array,searchN);
    if (result == -1)
    {
        Console.WriteLine("Number is not found");
    }
    else
    {   
        result = result + 1;
        Console.WriteLine("Number is found in " + result + " of the array");
    }
}

static int BinarySearch(int[] array,int searchn)
{
    int first = 0;
    int last = array.Length - 1;
    while (first <= last)
    {
        int mid = (first + last)/2;
        if (searchn == array[mid])
        {
            return mid;
        }
        else if (searchn > array[mid])
        {
            first = mid + 1;
        }
        else
        { 
            last = mid - 1;
        }
    }
    return -1;
}

static void Bubblesort(int[] array,int n)
{
    int temp = 0;
    int counter = 0;
    int swaps = 0;
    bool swapped = false;
    while (swapped == false)
    {
        while (counter < n - 1)
        {
            if (array[counter] > array[counter+1])
            {
                temp = array[counter];
                array[counter] = array[counter+1];
                array[counter+1] = temp;
                swaps++;
            }
            counter = counter + 1;
        }
        if (swaps == 0)
        {
            swapped = true;
        }
        else 
        {
            counter = 0;
            swaps = 0;
        }
    }
}
}
} 