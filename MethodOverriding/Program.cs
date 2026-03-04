using ConsoleApp7;
using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// ==========================================
// BÀI 3: ĐỘNG VẬT KÊU
// ==========================================
Console.WriteLine("--- BÀI 3: ĐỘNG VẬT ---");
Animal myDog = new Dog();
Animal myCat = new Cat();
Animal myCow = new Cow();

myDog.Speak();
myCat.Speak();
myCow.Speak();


// ==========================================
// BÀI 4: TÍNH LƯƠNG NHÂN VIÊN
// ==========================================
Console.WriteLine("\n--- BÀI 4: TÍNH LƯƠNG ---");
Employee manager = new Manager();
Employee dev = new Developer();
Employee tester = new Tester();

Console.WriteLine($"Manager: {manager.CalculateSalary()}");
Console.WriteLine($"Developer: {dev.CalculateSalary()}");
Console.WriteLine($"Tester: {tester.CalculateSalary()}");


// ==========================================
// BÀI 5: TÍNH DIỆN TÍCH HÌNH HỌC
// ==========================================
Console.WriteLine("\n--- BÀI 5: TÍNH DIỆN TÍCH ---");
Shape circle = new Circle(5);       // Bán kính 5
Shape rect = new Rectangle(4, 5);   // Rộng 4, Dài 5
Shape triangle = new Triangle(4, 5); // Đáy 4, Cao 5

Console.WriteLine($"Circle Area (r=5): {Math.Round(circle.CalculateArea(), 2)}");
Console.WriteLine($"Rectangle Area (4x5): {rect.CalculateArea()}");
Console.WriteLine($"Triangle Area (b=4, h=5): {triangle.CalculateArea()}");


// ==========================================
// BÀI 6: HIỂN THỊ THÔNG TIN NGƯỜI
// ==========================================
Console.WriteLine("\n--- BÀI 6: THÔNG TIN ---");
// Sử dụng tên class mới (PersonB6, StudentB6) để không trùng lặp
PersonB6 student = new StudentB6("Nguyen Van A", "Computer Science");
PersonB6 teacher = new TeacherB6("Le Minh Tuan", "Mathematics");

student.ShowInfo();
teacher.ShowInfo();

Console.ReadLine();