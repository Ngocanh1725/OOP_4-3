using System;

namespace ConsoleApp7
{
    internal class PersonB6
    {
        public string Name { get; set; }

        public PersonB6(string name)
        {
            Name = name;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    internal class StudentB6 : PersonB6
    {
        public string Major { get; set; }

        public StudentB6(string name, string major) : base(name)
        {
            Major = major;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Student: {Name} - Major: {Major}");
        }
    }

    internal class TeacherB6 : PersonB6
    {
        public string Subject { get; set; }

        public TeacherB6(string name, string subject) : base(name)
        {
            Subject = subject;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Teacher: {Name} - Subject: {Subject}");
        }
    }
}