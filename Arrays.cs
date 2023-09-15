using System;
namespace HelloWorld { 
class Program { 
static void Main(string[] args)
{ 
    Int32 array[9] = {};
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.Readline();
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(i + ",");
    } 
}

} 
} 
}
