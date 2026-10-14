# Bubble Sort – Thuật toán sắp xếp nổi bọt

## 1. Giới thiệu

**Bubble Sort (Sắp xếp nổi bọt)** là một trong những thuật toán sắp xếp cơ bản và trực quan nhất trong cấu trúc dữ liệu và giải thuật (DSA).

Nguyên lý hoạt động: Thuật toán liên tục duyệt qua mảng, so sánh từng cặp phần tử liền kề nhau (`arr[j]` và `arr[j+1]`). Nếu chúng đứng sai thứ tự (ví dụ phần tử đứng trước lớn hơn phần tử đứng sau khi cần sắp tăng dần), thuật toán sẽ **hoán đổi vị trí (swap)** của chúng. 

Quá trình này giống như những "bọt khí nhẹ hơn nổi dần lên mặt nước", sau mỗi vòng lặp, phần tử lớn nhất trong đoạn chưa sắp xếp sẽ được "đẩy" về đúng vị trí cuối cùng của nó.

---

## 2. Ý tưởng thuật toán từng bước

Cho mảng gồm `n` phần tử:
1. Duyệt vòng lặp ngoài `i` từ `0` đến `n - 2` (tổng cộng `n - 1` lượt).
2. Duyệt vòng lặp trong `j` từ `0` đến `n - i - 2`:
   - So sánh `arr[j]` với `arr[j + 1]`.
   - Nếu `arr[j] > arr[j + 1]`: Thực hiện hoán đổi `arr[j]` và `arr[j + 1]`.
3. **Kỹ thuật tối ưu hóa (Optimized Bubble Sort):**
   - Đặt cờ hiệu `swapped = false` ở đầu mỗi vòng lặp `i`.
   - Nếu trong suốt vòng lặp `j` không có bất kỳ thao tác hoán đổi nào xảy ra (`swapped` vẫn là `false`), điều đó có nghĩa là **mảng đã hoàn toàn có thứ tự**. Ta có thể kết thúc thuật toán ngay lập tức (`break`), giúp giảm thời gian chạy tốt nhất xuống $O(n)$.

---

## 3. Ví dụ minh họa chi tiết

Giả sử ta cần sắp xếp mảng: `[5, 1, 4, 2, 8]` theo thứ tự tăng dần ($n = 5$).

### Lượt duyệt 1 ($i = 0$):
* So sánh `5` và `1`: $5 > 1$ $\rightarrow$ Hoán đổi $\rightarrow$ `[1, 5, 4, 2, 8]`
* So sánh `5` và `4`: $5 > 4$ $\rightarrow$ Hoán đổi $\rightarrow$ `[1, 4, 5, 2, 8]`
* So sánh `5` và `2`: $5 > 2$ $\rightarrow$ Hoán đổi $\rightarrow$ `[1, 4, 2, 5, 8]`
* So sánh `5` và `8`: $5 < 8$ $\rightarrow$ Giữ nguyên $\rightarrow$ `[1, 4, 2, 5, 8]`
* 👉 *Kết thúc lượt 1: Số lớn nhất (`8`) đã về đúng vị trí cuối cùng.*

### Lượt duyệt 2 ($i = 1$):
* So sánh `1` và `4`: $1 < 4$ $\rightarrow$ Giữ nguyên
* So sánh `4` và `2`: $4 > 2$ $\rightarrow$ Hoán đổi $\rightarrow$ `[1, 2, 4, 5, 8]`
* So sánh `4` và `5`: $4 < 5$ $\rightarrow$ Giữ nguyên
* 👉 *Kết thúc lượt 2: Số lớn thứ hai (`5`) đã về đúng vị trí.*

### Lượt duyệt 3 ($i = 2$):
* Mảng hiện tại: `[1, 2, 4, 5, 8]`
* So sánh các cặp liền kề: không có cặp nào cần hoán đổi $\rightarrow$ `swapped = false`.
* 👉 *Dừng thuật toán sớm nhờ cờ tối ưu! Mảng đã được sắp xếp.*

---

## 4. Phân tích độ phức tạp (Complexity Analysis)

| Trường hợp | Độ phức tạp thời gian (Time) | Điều kiện xảy ra |
| :--- | :--- | :--- |
| **Best Case (Tốt nhất)** | **$O(n)$** | Mảng đã được sắp xếp sẵn từ đầu (nhờ cờ `swapped`) |
| **Average Case (Trung bình)** | **$O(n^2)$** | Các phần tử phân bố ngẫu nhiên |
| **Worst Case (Tệ nhất)** | **$O(n^2)$** | Mảng bị sắp xếp ngược hoàn toàn (ví dụ: `[5, 4, 3, 2, 1]`) |
| **Space Complexity (Không gian)** | **$O(1)$** | Chỉ sử dụng thêm một biến tạm `temp` (In-place sort) |
| **Tính ổn định (Stability)** | **Stable** | Không làm thay đổi vị trí tương đối của các phần tử bằng nhau |

---

## 5. Mã giả (Pseudocode)

```text
procedure BubbleSort(A : list of sortable items, n : number of items)
    for i from 0 to n - 2 do
        swapped = false
        for j from 0 to n - i - 2 do
            if A[j] > A[j + 1] then
                swap(A[j], A[j + 1])
                swapped = true
            end if
        end for
        if not swapped then
            break
        end if
    end for
end procedure
```

---

## 6. Cài đặt C#

```csharp
public void SortAscending(int[] array)
{
    int n = array.Length;
    for (int i = 0; i < n - 1; i++)
    {
        bool swapped = false;
        for (int j = 0; j < n - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                swapped = true;
            }
        }
        if (!swapped)
            break;
    }
}
```

---

## 7. Ưu và nhược điểm

### Ưu điểm:
- Cực kỳ dễ hiểu, dễ nhớ và dễ cài đặt.
- Là thuật toán sắp xếp tại chỗ (In-place) không tốn bộ nhớ phụ ($O(1)$).
- Là thuật toán sắp xếp ổn định (Stable sort).

### Nhược điểm:
- Hiệu suất kém với dữ liệu lớn vì độ phức tạp là $O(n^2)$.
- Trong thực tế ít khi dùng cho tập dữ liệu lớn, chủ yếu dùng cho mục đích giáo dục và mảng rất nhỏ ($n < 50$).
