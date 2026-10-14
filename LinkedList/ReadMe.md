# Singly Linked List – Danh sách liên kết đơn

## 1. Giới thiệu

**Danh sách liên kết đơn (Singly Linked List)** là một cấu trúc dữ liệu tuyến tính bao gồm một chuỗi các phần tử gọi là **Node (Nút)**. Khác với mảng (Array) lưu trữ các phần tử ở các ô nhớ liên tiếp nhau, các Node trong danh sách liên kết có thể nằm rải rác ở bất kỳ đâu trong bộ nhớ RAM và được kết nối với nhau thông qua **con trỏ (Pointer / Reference)**.

Mỗi Node bao gồm hai thành phần chính:
1. **Data:** Giá trị hoặc thông tin mà Node lưu trữ.
2. **Next:** Con trỏ tham chiếu đến Node tiếp theo trong danh sách (Node cuối cùng trỏ đến `null`).

```text
[ Head ]
   │
   ▼
┌───────┬──────┐     ┌───────┬──────┐     ┌───────┬──────┐
│ Data  │ Next ┼───► │ Data  │ Next ┼───► │ Data  │ Next ┼───► NULL
└───────┴──────┘     └───────┴──────┘     └───────┴──────┘
  Node 1               Node 2               Node 3 [ Tail ]
```

---

## 2. So sánh Linked List và Mảng (Array)

| Tiêu chí | Mảng (Array) | Danh sách liên kết (Linked List) |
| :--- | :--- | :--- |
| **Vùng nhớ** | Liên tục, cố định | Phân tán, động theo nhu cầu |
| **Kích thước** | Cố định khi khởi tạo (hoặc tốn chi phí mở rộng) | Co giãn linh hoạt tại runtime |
| **Truy cập phần tử theo chỉ số (Index)** | **$O(1)$** (Truy cập ngẫu nhiên) | **$O(n)$** (Phải duyệt tuần tự từ Head) |
| **Thêm/Xóa ở đầu danh sách** | **$O(n)$** (Phải dời toàn bộ phần tử) | **$O(1)$** (Chỉ cần thay đổi liên kết con trỏ) |
| **Thêm/Xóa ở cuối (khi có con trỏ Tail)** | **$O(1)$** | **$O(1)$** |
| **Chi phí bộ nhớ** | Chỉ tốn cho phần tử | Tốn thêm bộ nhớ lưu con trỏ `Next` cho mỗi Node |

---

## 3. Các thao tác cơ bản và Độ phức tạp

### 3.1. Thêm phần tử
- **Thêm vào đầu (`AddFirst`):**
  - Tạo `newNode`.
  - Gán `newNode.Next = head`.
  - Cập nhật `head = newNode`.
  - Độ phức tạp: **$O(1)$**.
- **Thêm vào cuối (`AddLast`):**
  - Tạo `newNode`.
  - Nếu danh sách rỗng: `head = tail = newNode`.
  - Ngược lại: `tail.Next = newNode; tail = newNode`.
  - Độ phức tạp: **$O(1)$** (khi có con trỏ `tail`).

### 3.2. Tìm kiếm phần tử (`SearchX`)
- Bắt đầu từ `head`, duyệt từng node bằng `current = current.Next`.
- So sánh `current.Data == x`.
- Nếu tìm thấy trả về Node, nếu tới `null` trả về `null`.
- Độ phức tạp: **$O(n)$**.

### 3.3. Các hàm xử lý thống kê
- **`GetMax()` / `GetMin()`:** Duyệt qua danh sách để tìm giá trị lớn nhất / nhỏ nhất ($O(n)$).
- **`GetEvenList()` / `GetOddList()`:** Tách thành danh sách chẵn hoặc lẻ ($O(n)$).
- **`JoinList(list1, list2)`:** Nối hai danh sách liên kết thành một danh sách mới ($O(n + m)$).

---

## 4. Cấu trúc lớp Node và LinkedList trong C#

### Node:
```csharp
public class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}
```

### LinkedList cơ bản:
```csharp
public class LinkedList
{
    private Node head;
    private Node tail;
    public int count;

    public bool IsEmpty => head == null;

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

    public Node SearchX(int x)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data == x) return current;
            current = current.Next;
        }
        return null;
    }
}
```

---

## 5. Ứng dụng thực tế

1. **Cơ chế Undo / Redo:** Trong trình soạn thảo văn bản, trình duyệt web (Back/Forward).
2. **Cài đặt các cấu trúc dữ liệu khác:** Ngăn xếp (Stack), Hàng đợi (Queue), Đồ thị (Adjacency List).
3. **Quản lý bộ nhớ hệ điều hành:** Quản lý danh sách các khối bộ nhớ còn trống (Free memory block list).
4. **Trình phát nhạc:** Playlist bài hát kế tiếp (Next Song) hoặc danh sách phát vòng lặp (Circular Linked List).
