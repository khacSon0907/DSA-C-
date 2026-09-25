# Binary Search – Thuật toán tìm kiếm nhị phân

## 1. Giới thiệu

**Binary Search (Tìm kiếm nhị phân)** là một thuật toán tìm kiếm hiệu quả trong cấu trúc dữ liệu và giải thuật (DSA). Thuật toán hoạt động bằng cách chia đôi phạm vi tìm kiếm sau mỗi lần so sánh, từ đó giảm nhanh số lượng phần tử cần kiểm tra.

Binary Search yêu cầu mảng phải được **sắp xếp** trước khi thực hiện tìm kiếm.

## 2. Đề bài

Cho một mảng số nguyên gồm `n` phần tử đã được sắp xếp theo thứ tự tăng dần và một giá trị `target` cần tìm.

Yêu cầu:

* Xác định vị trí đầu (`left`) và vị trí cuối (`right`) của mảng.
* Tính vị trí giữa (`mid`) của phạm vi tìm kiếm.
* So sánh phần tử tại `mid` với giá trị `target`.
* Nếu tìm thấy, trả về vị trí (index) của phần tử đó.
* Nếu phần tử giữa nhỏ hơn `target`, tìm kiếm ở nửa bên phải.
* Nếu phần tử giữa lớn hơn `target`, tìm kiếm ở nửa bên trái.
* Nếu không tìm thấy sau khi kết thúc tìm kiếm, trả về `-1`.

**Ví dụ:**

```text
Input:
number = [4, 7, 12, 21, 30, 44, 56, 65, 73, 89]
target = 56

Output:
Index = 6
```

**Giải thích:**

Thuật toán bắt đầu với:

```text
left = 0
right = 9
```

Tính vị trí giữa:

```text
mid = (left + right) / 2
    = (0 + 9) / 2
    = 4
```

Giá trị tại `number[4]` là `30`.

Vì:

```text
30 < 56
```

nên `target` nằm ở bên phải.

Cập nhật:

```text
left = mid + 1
left = 5
```

Tiếp tục tính `mid` và so sánh cho đến khi tìm thấy `56`.

Kết quả:

```text
Index = 6
```

## 3. Ý tưởng và cách giải quyết

Thuật toán Binary Search hoạt động theo các bước:

1. Khởi tạo `left = 0`, đại diện cho vị trí đầu tiên của mảng.
2. Khởi tạo `right = size - 1`, đại diện cho vị trí cuối cùng của mảng.
3. Tính vị trí giữa bằng công thức `mid = (left + right) / 2`.
4. So sánh `array[mid]` với `target`.
5. Nếu `array[mid] == target`, trả về `mid`.
6. Nếu `array[mid] < target`, tìm kiếm ở bên phải bằng cách cập nhật `left = mid + 1`.
7. Nếu `array[mid] > target`, tìm kiếm ở bên trái bằng cách cập nhật `right = mid - 1`.
8. Tiếp tục quá trình cho đến khi tìm thấy phần tử hoặc `left > right`.
9. Nếu không tìm thấy, trả về `-1`.

## 4. Code C#

```csharp
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

        // Sắp xếp mảng trước khi Binary Search
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
```

## 5. Độ phức tạp thuật toán (Big O)

Độ phức tạp thời gian của Binary Search phụ thuộc vào vị trí của phần tử cần tìm và số lần phạm vi tìm kiếm được chia đôi.

| Trường hợp                | Độ phức tạp | Giải thích                                                   |
| ------------------------- | ----------- | ------------------------------------------------------------ |
| Tốt nhất (Best Case)      | O(1)        | Phần tử cần tìm nằm ngay tại vị trí giữa của mảng.           |
| Trung bình (Average Case) | O(log n)    | Sau mỗi lần tìm kiếm, phạm vi cần tìm giảm khoảng một nửa.   |
| Xấu nhất (Worst Case)     | O(log n)    | Phải liên tục chia đôi phạm vi cho đến khi không còn phần tử. |

**Độ phức tạp không gian (Space Complexity):**

* `O(1)` – Thuật toán chỉ sử dụng các biến phụ như `left`, `right` và `mid`, không tạo thêm cấu trúc dữ liệu phụ thuộc vào `n`.

Trong đó, `n` là số lượng phần tử trong mảng.

## 6. Ưu điểm

* **Tìm kiếm nhanh:** Độ phức tạp thời gian trung bình và xấu nhất là `O(log n)`.
* **Hiệu quả với dữ liệu lớn:** Mỗi lần tìm kiếm loại bỏ khoảng một nửa số phần tử cần kiểm tra.
* **Không cần nhiều bộ nhớ:** Thuật toán chỉ sử dụng một số biến phụ, có độ phức tạp không gian `O(1)`.
* **Hiệu quả khi tìm kiếm nhiều lần:** Khi dữ liệu đã được sắp xếp, có thể thực hiện nhiều lần tìm kiếm nhanh chóng.
* **Giảm số lần so sánh:** Không cần kiểm tra lần lượt từng phần tử như Linear Search.

## 7. Nhược điểm

* **Yêu cầu mảng phải được sắp xếp:** Binary Search không hoạt động chính xác trên mảng chưa được sắp xếp.
* **Có chi phí sắp xếp:** Nếu dữ liệu chưa được sắp xếp, cần thực hiện thêm bước sắp xếp trước khi tìm kiếm.
* **Không phù hợp với mọi cấu trúc dữ liệu:** Binary Search phù hợp nhất với các cấu trúc dữ liệu có thể truy cập phần tử theo index nhanh như mảng.
* **Khó hiểu hơn Linear Search:** Logic chia đôi phạm vi tìm kiếm phức tạp hơn so với việc duyệt tuần tự.

## 8. Khi nào nên sử dụng?

Binary Search phù hợp khi:

* Mảng đã được sắp xếp.
* Mảng có số lượng phần tử lớn.
* Cần thực hiện nhiều lần tìm kiếm trên cùng một tập dữ liệu.
* Cần tối ưu thời gian tìm kiếm.
* Dữ liệu có thể truy cập nhanh theo index.

Nếu mảng chưa được sắp xếp và chỉ cần tìm kiếm một lần, Linear Search có thể đơn giản hơn vì không cần thực hiện bước sắp xếp trước.

## 9. Kết luận

Binary Search là thuật toán tìm kiếm hiệu quả dựa trên nguyên tắc **chia để trị**. Thay vì kiểm tra từng phần tử, thuật toán liên tục chia đôi phạm vi tìm kiếm và loại bỏ một nửa số phần tử sau mỗi lần so sánh.

Thuật toán có độ phức tạp thời gian `O(log n)` trong trường hợp trung bình và xấu nhất, cùng độ phức tạp không gian `O(1)`.

Mặc dù yêu cầu mảng phải được sắp xếp trước, Binary Search vẫn là một thuật toán quan trọng và hiệu quả khi làm việc với dữ liệu lớn hoặc thực hiện nhiều thao tác tìm kiếm.

Binary Search là một trong những thuật toán tìm kiếm nền tảng cần nắm vững trong **Data Structures and Algorithms (DSA)**.