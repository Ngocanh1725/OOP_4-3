using System;

namespace ConsoleApp6
{
    internal class Area
    {
        // 1. Tính diện tích hình vuông
        // Sử dụng kiểu int để phân biệt chữ ký (signature) với hàm tính diện tích hình tròn
        public int TinhDienTich(int a)
        {
            return a * a;
        }

        // 2. Tính diện tích hình chữ nhật
        // Khác số lượng tham số (2 tham số)
        public double TinhDienTich(double a, double b)
        {
            return a * b;
        }

        // 3. Tính diện tích hình tròn
        // Sử dụng kiểu double để phân biệt với hình vuông
        public double TinhDienTich(double r)
        {
            return Math.PI * r * r;
        }
    }
}