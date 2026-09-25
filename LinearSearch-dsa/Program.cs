using System;

namespace  LinearSearch;

class Program
{
    static void Main(string[] args)
    {
        LinearSearch a1 = new LinearSearch();
        Console.WriteLine(a1);
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int result = a1.linearSearch(n);
        if (result != -1)
        {
           Console.WriteLine($"Tim thay phan tu o vi tri thu : {result+1}");
        }
        else
        {
            Console.WriteLine("Khong tim thay phan tu");
        }
    }
}

