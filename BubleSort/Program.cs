using System;

namespace BubleSort;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== CHƯƠNG TRÌNH DEMO BUBBLE SORT ===");

        BubbleSort bs = new BubbleSort(8);
        Console.WriteLine("\n[1] Mảng ngẫu nhiên ban đầu:");
        Console.WriteLine(bs);

        Console.WriteLine("\n[2] Thực hiện sắp xếp nổi bọt tăng dần...");
        bs.SortAscending();
        Console.WriteLine(bs);

        Console.WriteLine("\n[3] Thực hiện sắp xếp nổi bọt giảm dần...");
        bs.SortDescending();
        Console.WriteLine(bs);

        Console.WriteLine("\nHoàn tất demo Bubble Sort!");
    }
}

