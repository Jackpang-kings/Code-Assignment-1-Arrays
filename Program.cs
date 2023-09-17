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
        int mid = first + last/2;
        if (array[mid] == searchn)
        {
            return mid;
        }
        else if (array[mid] < searchn)
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
}
} 

