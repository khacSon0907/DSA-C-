    # Linear Search – Thuật toán tìm kiếm tuyến tính

## 1. Giới thiệu

**Linear Search (Tìm kiếm tuyến tính)** là một thuật toán tìm kiếm cơ bản trong cấu trúc dữ liệu và giải thuật (DSA). Thuật toán thực hiện bằng cách duyệt lần lượt từng phần tử trong mảng, bắt đầu từ phần tử đầu tiên, cho đến khi tìm thấy giá trị cần tìm hoặc duyệt hết mảng.

Linear Search có thể sử dụng trên cả mảng đã sắp xếp và mảng chưa sắp xếp.

## 2. Đề bài

Cho một mảng số nguyên gồm `n` phần tử và một giá trị `target` cần tìm.

Yêu cầu:

* Duyệt qua các phần tử của mảng từ trái sang phải.
* So sánh từng phần tử với giá trị `target`.
* Nếu tìm thấy, trả về vị trí (index) của phần tử đó.
* Nếu không tìm thấy sau khi duyệt hết mảng, trả về `-1`.

**Ví dụ:**

```text
Input:
number = [73, 56, 75, 51, 72, 30, 87, 56, 66, 27]
target = 87

Output:
Index = 6
```

**Giải thích:**

Thuật toán lần lượt kiểm tra từng phần tử:

* `number[0] = 73` → Không tìm thấy.
* `number[1] = 56` → Không tìm thấy.
* `number[2] = 75` → Không tìm thấy.
* `number[3] = 51` → Không tìm thấy.
* `number[4] = 72` → Không tìm thấy.
* `number[5] = 30` → Không tìm thấy.
* `number[6] = 87` → Tìm thấy!

Kết quả trả về là `6`.

## 3. Ý tưởng và cách giải quyết

Thuật toán Linear Search hoạt động theo các bước:

1. Khởi tạo biến `i = 0`, đại diện cho vị trí đầu tiên của mảng.
2. Sử dụng vòng lặp để duyệt từng phần tử cho đến khi hết mảng.
3. Tại mỗi vị trí, so sánh `number[i]` với `target`.
4. Nếu hai giá trị bằng nhau, trả về chỉ số `i`.
5. Nếu không bằng nhau, tăng `i` lên 1 và tiếp tục tìm kiếm.
6. Nếu duyệt hết mảng mà không tìm thấy, trả về `-1`.

## 4. Code C#

```csharp
using System;

class Program
{
    static int LinearSearch(int[] number, int target)
    {
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == target)
            {
                return i;
            }
        }

        return -1;
    }

    static void Main()
    {
        int[] number = { 73, 56, 75, 51, 72,
                         30, 87, 56, 66, 27 };

        int target = 87;

        int result = LinearSearch(number, target);

        if (result != -1)
        {
            Console.WriteLine(
                $"Tìm thấy {target} tại vị trí {result}");
        }
        else
        {
            Console.WriteLine("Không tìm thấy phần tử.");
        }
    }
}
```

## 5. Độ phức tạp thuật toán (Big O)

Độ phức tạp thời gian của Linear Search phụ thuộc vào vị trí của phần tử cần tìm.

| Trường hợp                | Độ phức tạp | Giải thích                                                |
| ------------------------- | ----------- | --------------------------------------------------------- |
| Tốt nhất (Best Case)      | O(1)        | Phần tử cần tìm nằm ngay đầu mảng.                        |
| Trung bình (Average Case) | O(n)        | Cần kiểm tra trung bình một số lượng phần tử tỷ lệ với n. |
| Xấu nhất (Worst Case)     | O(n)        | Phần tử nằm cuối mảng hoặc không tồn tại.                 |

**Độ phức tạp không gian (Space Complexity):**

* `O(1)` – Thuật toán chỉ sử dụng một số biến phụ như `i`, không cần tạo thêm mảng hoặc cấu trúc dữ liệu có kích thước phụ thuộc vào `n`.

Trong đó, `n` là số lượng phần tử trong mảng.

## 6. Ưu điểm

* **Dễ hiểu, dễ triển khai:** Thuật toán có cấu trúc đơn giản, phù hợp với người mới học lập trình và DSA.
* **Không yêu cầu sắp xếp:** Có thể tìm kiếm trực tiếp trên mảng chưa được sắp xếp.
* **Không cần bộ nhớ phụ lớn:** Chỉ sử dụng một vài biến, có độ phức tạp không gian `O(1)`.
* **Phù hợp với dữ liệu nhỏ:** Khi số lượng phần tử ít, thuật toán dễ triển khai và có thể đáp ứng tốt nhu cầu tìm kiếm.
* **Tìm được phần tử đầu tiên:** Với cách cài đặt cơ bản, thuật toán trả về vị trí xuất hiện đầu tiên của giá trị cần tìm.

## 7. Nhược điểm

* **Tốc độ giảm khi dữ liệu lớn:** Trong trường hợp xấu nhất, thuật toán phải kiểm tra toàn bộ `n` phần tử.
* **Không tận dụng thứ tự dữ liệu:** Ngay cả khi mảng đã được sắp xếp, cách triển khai cơ bản vẫn duyệt tuần tự.
* **Không tối ưu cho nhiều lần tìm kiếm:** Nếu phải tìm kiếm nhiều lần trên một mảng lớn, các thuật toán như Binary Search có thể phù hợp hơn khi dữ liệu đã được sắp xếp.

## 8. Khi nào nên sử dụng?

Linear Search phù hợp khi:

* Mảng có số lượng phần tử nhỏ.
* Dữ liệu chưa được sắp xếp.
* Chỉ cần thực hiện một vài lần tìm kiếm.
* Cần một thuật toán đơn giản, dễ cài đặt và dễ bảo trì.

Nếu mảng lớn, đã được sắp xếp và cần tìm kiếm nhiều lần, có thể cân nhắc sử dụng Binary Search với độ phức tạp thời gian `O(log n)`.

## 9. Kết luận

Linear Search là thuật toán tìm kiếm cơ bản, có cách hoạt động đơn giản và không yêu cầu dữ liệu phải được sắp xếp trước. Thuật toán có độ phức tạp thời gian `O(n)` trong trường hợp trung bình và xấu nhất, cùng độ phức tạp không gian `O(1)`.

Mặc dù không tối ưu cho dữ liệu lớn, Linear Search vẫn hữu ích trong nhiều trường hợp thực tế và là nền tảng để tiếp cận các thuật toán tìm kiếm nâng cao hơn.
