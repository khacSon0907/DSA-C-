namespace BubleSort;

public class BubbleSort
{
    private int[] array;
    private int size;

    public int[] ArrayData => array;
    public int Size => size;

    public BubbleSort()
    {
        this.size = 10;
        this.array = new int[this.size];
        GenerateIntArray();
    }

    public BubbleSort(int size)
    {
        this.size = size;
        this.array = new int[this.size];
        GenerateIntArray();
    }

    public BubbleSort(int[] customArray)
    {
        this.array = (int[])customArray.Clone();
        this.size = customArray.Length;
    }

    public void GenerateIntArray()
    {
        Random rnd = new Random();
        for (int i = 0; i < this.size; i++)
        {
            this.array[i] = rnd.Next(1, 100);
        }
    }

    public void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // Thuật toán sắp xếp nổi bọt tăng dần (có tối ưu cờ swapped)
    public void SortAscending()
    {
        int n = this.array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (this.array[j] > this.array[j + 1])
                {
                    Swap(ref this.array[j], ref this.array[j + 1]);
                    swapped = true;
                }
            }
            // Nếu không có phần tử nào hoán đổi, mảng đã sắp xếp
            if (!swapped)
                break;
        }
    }

    // Thuật toán sắp xếp nổi bọt giảm dần
    public void SortDescending()
    {
        int n = this.array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (this.array[j] < this.array[j + 1])
                {
                    Swap(ref this.array[j], ref this.array[j + 1]);
                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }
    }

    public override string ToString()
    {
        return "Danh sach phan tu: [" + string.Join(", ", this.array) + "]";
    }
}