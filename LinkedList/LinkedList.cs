namespace ConsoleApp1;

public class LinkedList
{
    private Node head;
    private Node tail;

    public int count;

    public bool IsEmpty => head == null;

    public LinkedList()
    {
        head = null;
        tail = null;
        count = 0;
    }

    // 1. Them node vao dau danh sach
    public void AddFirst(int value)
    {
        Node newNode = new Node(value);

        if (IsEmpty)
        {
            head = tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head = newNode;
        }

        count++;
    }

    // 2. Them node vao cuoi danh sach
    public void AddLast(int value)
    {
        Node newNode = new Node(value);

        if (IsEmpty)
        {
            head = tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }

        count++;
    }

    // 3. Hien thi danh sach
    public void ShowList()
    {
        Node current = head;

        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }

        Console.WriteLine("null");
    }

    // 4. Nhap danh sach
    public void Input()
    {
        Console.Write("Nhap so luong node: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap gia tri: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Them dau (1) hay cuoi (2): ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                AddFirst(x);
            }
            else if (choice == 2)
            {
                AddLast(x);
            }
            else
            {
                Console.WriteLine("Lua chon khong hop le!");
                i--;
            }
        }
    }

    // 5. Tim node co gia tri x
    public Node SearchX(int x)
    {
        Node current = head;

        while (current != null)
        {
            if (current.Data == x)
            {
                return current;
            }

            current = current.Next;
        }

        return null;
    }

    // 6. Tim node co gia tri lon nhat
    public Node GetMax()
    {
        if (IsEmpty)
        {
            return null;
        }

        Node maxNode = head;
        Node current = head.Next;

        while (current != null)
        {
            if (current.Data > maxNode.Data)
            {
                maxNode = current;
            }

            current = current.Next;
        }

        return maxNode;
    }

    // 7. Tim node co gia tri nho nhat
    public Node GetMin()
    {
        if (IsEmpty)
        {
            return null;
        }

        Node minNode = head;
        Node current = head.Next;

        while (current != null)
        {
            if (current.Data < minNode.Data)
            {
                minNode = current;
            }

            current = current.Next;
        }

        return minNode;
    }

    // 8. Tao danh sach chi chua so chan
    public LinkedList GetEvenList()
    {
        LinkedList result = new LinkedList();
        Node current = head;

        while (current != null)
        {
            if (current.Data % 2 == 0)
            {
                result.AddLast(current.Data);
            }

            current = current.Next;
        }

        return result;
    }

    // 9. Tao danh sach chi chua so le
    public LinkedList GetOddList()
    {
        LinkedList result = new LinkedList();
        Node current = head;

        while (current != null)
        {
            if (current.Data % 2 != 0)
            {
                result.AddLast(current.Data);
            }

            current = current.Next;
        }

        return result;
    }

    // 10. Noi list2 vao sau list1, tao list3
    public static LinkedList JoinList(
        LinkedList list1,
        LinkedList list2)
    {
        LinkedList list3 = new LinkedList();

        Node current = list1.head;

        while (current != null)
        {
            list3.AddLast(current.Data);
            current = current.Next;
        }

        current = list2.head;

        while (current != null)
        {
            list3.AddLast(current.Data);
            current = current.Next;
        }

        return list3;
    }
}
