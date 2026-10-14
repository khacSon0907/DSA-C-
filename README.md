# 📚 Data Structures & Algorithms (DSA) – Cấu Trúc Dữ Liệu & Giải Thuật

Chào mừng bạn đến với kho lưu trữ mã nguồn và tài liệu học tập môn **Cấu Trúc Dữ Liệu & Giải Thuật (DSA)** trường Đại học Ngoại ngữ - Tin học TP.HCM (HUFLIT).

Dự án này bao gồm:
1. **Source code C# (.NET)** chuẩn mực, có chú thích chi tiết cho từng cấu trúc dữ liệu và giải thuật.
2. **Tài liệu README chuyên sâu** cho từng thư mục thuật toán con (lý thuyết, ví dụ từng bước, mã giả, phân tích độ phức tạp $O$).
3. **Ứng dụng Web Mô Phỏng Trực Quan ([`index.html`](./index.html))**: Cho phép nhập dữ liệu trực tiếp, quan sát thuật toán chạy từng bước (step-by-step), đổi màu highlight, giải thích chi tiết bằng tiếng Việt.

---

## 🚀 Trải Nghiệm Ứng Dụng Web Mô Phỏng Trực Quan

Không cần cài đặt bất kỳ server hay thư viện nào! Bạn chỉ cần:
- **Cách 1:** Nhấp đúp chuột trực tiếp vào file **[`index.html`](./index.html)** để mở trong trình duyệt (Chrome, Edge, Firefox, Cốc Cốc, Safari,...).
- **Cách 2:** Sử dụng tiện ích Live Server trong VS Code / Antigravity IDE (chuột phải vào `index.html` $\rightarrow$ chọn **Open with Live Server**).

### ✨ Các tính năng nổi bật trên Web:
* 🔍 **Linear Search (Tìm kiếm tuyến tính):** Tự do nhập mảng số và giá trị cần tìm. Mô phỏng tuần tự từng ô, highlight vàng khi đang xét, xanh lá khi tìm thấy và đỏ khi không khớp.
* ⚡ **Binary Search (Tìm kiếm nhị phân):** Trực quan hóa 3 con trỏ `Left`, `Mid`, `Right`, tự động làm mờ nửa đoạn mảng bị loại bỏ sau mỗi lần so sánh.
* 🫧 **Bubble Sort (Sắp xếp nổi bọt):** Mô phỏng dạng cột chiều cao động (Bar Chart), hoán đổi vị trí sinh động kèm bộ đếm số lần so sánh và hoán đổi.
* 🔗 **Linked List (Danh sách liên kết):** Thêm đầu (`AddFirst`), thêm cuối (`AddLast`), xóa đầu, tìm kiếm Node với hiệu ứng laser quét qua từng mắt xích liên kết `Data | Next ->`.
* 🎛️ **Bảng điều khiển:** Chạy tự động (Play/Pause), đi từng bước (Step), Đặt lại (Reset), Đổi tốc độ (Speed Slider), Tạo mảng ngẫu nhiên (Randomize).

---

## 🗂️ Mục Lục & Cấu Trúc Thư Mục

Dưới đây là liên kết trực tiếp tới từng chủ đề giải thuật và cấu trúc dữ liệu:

```text
DSA/
├── 🌐 index.html                     <-- Web mô phỏng trực quan tương tác
├── 📖 README.md                      <-- File tài liệu tổng quan (bạn đang đọc)
├── 📁 LinearSearch-dsa/              <-- Thuật toán Tìm kiếm tuyến tính
│   ├── LinearSearch.cs
│   ├── Program.cs
│   └── README.md                     <-- Chi tiết lý thuyết & mã nguồn
│
├── 📁 BinarySearch/                  <-- Thuật toán Tìm kiếm nhị phân
│   ├── BinarySearch.cs
│   ├── Program.cs
│   └── ReadMe.md                     <-- Chi tiết lý thuyết & mã nguồn
│
├── 📁 BubleSort/                     <-- Thuật toán Sắp xếp nổi bọt
│   ├── BubbleSort.cs
│   ├── Program.cs
│   └── ReadMe.md                     <-- Chi tiết lý thuyết & mã nguồn
│
└── 📁 LinkedList/                    <-- Danh sách liên kết đơn
    ├── Node.cs
    ├── LinkedList.cs
    ├── Program.cs
    └── ReadMe.md                     <-- Chi tiết lý thuyết & mã nguồn
```

---

## 📌 Danh Sách Thư Mục Con & Tài Liệu Chi Tiết

| Cấu trúc / Giải thuật | Loại | Thư mục | Tài liệu hướng dẫn | Tóm tắt nguyên lý |
| :--- | :--- | :--- | :--- | :--- |
| **Linear Search** | Thuật toán tìm kiếm | [`./LinearSearch-dsa`](./LinearSearch-dsa/) | [📖 Xem README](./LinearSearch-dsa/README.md) | Duyệt tuần tự từ đầu đến cuối mảng cho đến khi gặp phần tử khớp. |
| **Binary Search** | Thuật toán tìm kiếm | [`./BinarySearch`](./BinarySearch/) | [📖 Xem README](./BinarySearch/ReadMe.md) | Chia đôi mảng đã sắp xếp để tìm kiếm nhanh trong $O(\log n)$. |
| **Bubble Sort** | Thuật toán sắp xếp | [`./BubleSort`](./BubleSort/) | [📖 Xem README](./BubleSort/ReadMe.md) | So sánh các cặp liền kề và đẩy dần số lớn nhất về cuối mảng. |
| **Linked List** | Cấu trúc dữ liệu | [`./LinkedList`](./LinkedList/) | [📖 Xem README](./LinkedList/ReadMe.md) | Danh sách liên kết đơn gồm các Node lưu `Data` và con trỏ `Next`. |

---

## 📊 Bảng Tổng Hợp Độ Phức Tạp (Complexity Cheat Sheet)

### 1. Thuật toán tìm kiếm & sắp xếp

| Thuật toán | Best Time | Average Time | Worst Time | Space Complexity | Ổn định (Stable) |
| :--- | :---: | :---: | :---: | :---: | :---: |
| **Linear Search** | $O(1)$ | $O(n)$ | $O(n)$ | $O(1)$ | — |
| **Binary Search** | $O(1)$ | $O(\log n)$ | $O(\log n)$ | $O(1)$ | — |
| **Bubble Sort** | $O(n)$ *(có cờ swapped)* | $O(n^2)$ | $O(n^2)$ | $O(1)$ | Có (Stable) |

### 2. Cấu trúc dữ liệu (Data Structures)

| Cấu trúc dữ liệu | Truy cập theo vị trí | Tìm kiếm giá trị | Thêm ở đầu | Thêm ở cuối | Xóa ở đầu |
| :--- | :---: | :---: | :---: | :---: | :---: |
| **Mảng (Array)** | **$O(1)$** | $O(n)$ | $O(n)$ | $O(1)$ | $O(n)$ |
| **Danh sách liên kết (Singly Linked List)** | $O(n)$ | $O(n)$ | **$O(1)$** | **$O(1)$** *(có Tail)* | **$O(1)$** |

---

## 💻 Hướng Dẫn Biên Dịch & Chạy Mã C# (.NET)

Yêu cầu máy tính đã cài đặt [.NET SDK](https://dotnet.microsoft.com/download) (phiên bản 6.0, 7.0 hoặc 8.0 trở lên).

Mở terminal tại thư mục dự án và chạy các lệnh sau:

### 1. Chạy Linear Search:
```bash
cd LinearSearch-dsa
dotnet run
```

### 2. Chạy Binary Search:
```bash
cd BinarySearch
dotnet run
```

### 3. Chạy Bubble Sort:
```bash
cd BubleSort
dotnet run
```

### 4. Chạy Linked List:
```bash
cd LinkedList
dotnet run
```

---

## 👨‍💻 Tác Giả & Bản Quyền
* Học phần: Cấu trúc dữ liệu và giải thuật (Data Structures and Algorithms).
* Đại học Ngoại ngữ - Tin học TP.HCM (HUFLIT).
