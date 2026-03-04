using ConsoleApp6;
using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=========== DEMO CALCULATOR ===========");
Calculator cal = new Calculator();
Console.WriteLine($"2 + 3 = {cal.Add(2, 3)}");
Console.WriteLine($"3 + 4 + 5 = {cal.Add(3, 4, 5)}");
Console.WriteLine($"2.2 + 3.3 = {cal.Add(2.2, 3.3)}");

Console.WriteLine("\n=========== BÀI 1: TÍNH DIỆN TÍCH ===========");
Area area = new Area();
Console.WriteLine($"Diện tích hình vuông (cạnh 5): {area.TinhDienTich(5)}");
Console.WriteLine($"Diện tích hình chữ nhật (cạnh 4x5.5): {area.TinhDienTich(4.0, 5.5)}");
Console.WriteLine($"Diện tích hình tròn (bán kính 3.5): {area.TinhDienTich(3.5):F2}");

Console.WriteLine("\n=========== BÀI 2: THÔNG TIN SINH VIÊN ===========");
Student student = new Student();
student.Display("An");
student.Display("An", 20);
student.Display("An", 20, "Hà Nội");

Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
Console.ReadKey();