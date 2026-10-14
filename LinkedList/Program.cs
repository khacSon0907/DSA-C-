using System;

namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        LinkedList list1 = new LinkedList();

        // Nhap danh sach
        list1.Input();

        Console.WriteLine("\nDanh sach ban dau:");
        list1.ShowList();

        // Tim kiem
        Console.Write("\nNhap x can tim: ");
        int x = int.Parse(Console.ReadLine());

        Node found = list1.SearchX(x);

        if (found != null)
            Console.WriteLine("Tim thay: " + found.Data);
        else
            Console.WriteLine("Khong tim thay!");

        // Max
        Node max = list1.GetMax();

        if (max != null)
            Console.WriteLine("Gia tri lon nhat: " + max.Data);
        else
            Console.WriteLine("Danh sach rong!");

        // Min
        Node min = list1.GetMin();

        if (min != null)
            Console.WriteLine("Gia tri nho nhat: " + min.Data);

        // Danh sach chan
        Console.WriteLine("\nDanh sach so chan:");
        list1.GetEvenList().ShowList();

        // Danh sach le
        Console.WriteLine("Danh sach so le:");
        list1.GetOddList().ShowList();

        // Noi hai danh sach
        LinkedList list2 = new LinkedList();
        list2.AddLast(100);
        list2.AddLast(200);

        LinkedList list3 = LinkedList.JoinList(list1, list2);

        Console.WriteLine("\nDanh sach sau khi noi:");
        list3.ShowList();

        Console.WriteLine("So node list3: " + list3.count);
    }
}
