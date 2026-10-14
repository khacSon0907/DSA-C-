namespace BubleSort;

public class BubbleSort
{
    private int[] array;
    private int size;
    

    public BubbleSort()
    {
        this.size = 10;
        this.array = new int[this.size];
        genarateIntArray();
    }

    public BubbleSort(int size)
    {
        this.size = size;
        this.array = new int[this.size];
        genarateIntArray();
    }

    public void genarateIntArray()
    {
        Random rnd = new Random();

        for (int i = 0; i < this.size; i++)
        {
            this.array[i] = rnd.Next(0, 100);
        }

        // Sắp xếp tăng dần để Binary Search hoạt động
        Array.Sort(this.array);
    }

    public void Swap(int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    

    public override string ToString()
    {
        return "Danh sach phan tu : [" 
               + string.Join(", ", this.array) + "]";
    }
}