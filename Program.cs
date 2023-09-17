using System;
namespace HelloWorld { 
class Program { 
static void Main(string[] args)
{
    int[] array = new int[9];
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
}
}
} 

