namespace LinearSearch;

public class LinearSearch
{

    private int[] array;
    private int size;

    public LinearSearch()
    {
        this.size = 10; 
        this.array = new int[this.size];
        genarateIntArray();
    }

    public LinearSearch(int size)
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
            this.array[i] = rnd.Next(0,100);
        }
    }

    public int linearSearch(int target)
    {
        for (int i = 0; i < this.size; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    public override string ToString()
    {
        return "Danh sach phan tu : [" + string.Join(", ", this.array) + "]";
    }
}