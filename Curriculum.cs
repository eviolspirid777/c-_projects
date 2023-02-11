using System;

    public class Curriculum
    {
        public string? faculty { get; set; }
        public string? specialty { get; set; }
        public string? course { get; set; }
        public string? group { get; set; }
        public Curriculum()
        {
        Console.WriteLine("Enter the Faculty:");
        faculty = Console.ReadLine();
        Console.WriteLine("Enter the Specialty:");
        specialty = Console.ReadLine();
        Console.WriteLine("Enter the Course:");
        course = Console.ReadLine();
        Console.WriteLine("Enter the Group:");
        group = Console.ReadLine();
        }
        public void GetInf()
        {
        Console.WriteLine($"Faculty = {faculty}\n Specialty = {specialty}\n Course = {course}\n Group = {group}\n");
        }
    }

