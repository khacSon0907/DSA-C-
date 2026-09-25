namespace BinarySearch;

public class BinarySearch
{
    private int[] array;
    private int size;

    public BinarySearch()
    {
        this.size = 10;
        this.array = new int[this.size];
        genarateIntArray();
    }

    public BinarySearch(int size)
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

    public int binarySearch(int target)
    {
        int left = 0;
        int right = this.size - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (array[mid] == target)
            {
                return mid;
            }

            if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }

    public override string ToString()
    {
        return "Danh sach phan tu : [" 
               + string.Join(", ", this.array) + "]";
    }
}