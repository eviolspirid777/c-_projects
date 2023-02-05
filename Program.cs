using System;
using System.IO;
using System.Security.Cryptography;

//string path = @"/Users/eviolspirid/Projects/c_sharp/str_stud/str_stud/content.txt";

internal class Program
{
    class Person
    {
        private string? name, faculty, specialty, course, group, city, pst_index, street, phone, mail;
        public void set_inf()
        {
            Console.WriteLine("Enter the INITIALS:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Faculty:");
            faculty = Console.ReadLine();
            Console.WriteLine("Enter the Specialty:");
            specialty = Console.ReadLine();
            Console.WriteLine("Enter the Course:");
            course = Console.ReadLine();
            Console.WriteLine("Enter the Group:");
            group = Console.ReadLine();
            Console.WriteLine("Enter the City:");
            city = Console.ReadLine();
            Console.Write("Enter the Post Index:");
            pst_index = Console.ReadLine();
            Console.Write("Enter the Street:");
            street = Console.ReadLine();
            Console.Write("Enter the Phone:");
            phone = Console.ReadLine();
            Console.Write("Enter the E-mail:");
            mail = Console.ReadLine();
        }
        public string get_inf()
        {
            return $"FIO = {name}, Faculty = {faculty}, Specialty = {specialty}, Course = {course}, Group = {group}, City = {city}, PostIndex = {pst_index}, Street = {street}, Phone = {phone}, Mail = {mail}\n";
        }
        
    };

    static void ListMenu(FileInfo fileInf, string path)
    {
        
        if (fileInf.Exists)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadToEnd();
                Console.WriteLine(text);
            }                                           
        }
        else
            Console.WriteLine("Cannot find the file!");
    }

    static void AddNode(FileInfo fileInf, string path)
    {
        Person human = new Person();
        if (fileInf.Exists)
        {
            human.set_inf();
            string originalText = human.get_inf();
            File.AppendAllText(path, originalText);
            
        }
        else
            Console.WriteLine("Cannot find the file!");
       
    }

    static void Filter()
    {
        Console.WriteLine("Enter what type do u want to filt:\n1)faculty\n2)speciality\n3)course\n4)group\n");
        string? c = Console.ReadLine();
        switch (c)
        {
            case "1":
                Console.WriteLine("Enter the faculty:");
                string k_word = Console.ReadLine();
                Console.Clear();
                break;
            case "2":
                Console.WriteLine("Enter the specialty:");
           //     string k_word = Console.ReadLine();
                Console.Clear();
                break;
            case "3":
                Console.WriteLine("Enter the course:");
             //   string k_word = Console.ReadLine();
                Console.Clear();
                break;
            case "4":
                Console.WriteLine("Enter the group:");
             //   string k_word = Console.ReadLine();
                Console.Clear();
                break;
        }
/*        if( ... == key_word)                                                    //ключевое слово надо сравнить с потоком слов, если он равен, то выводится список, содержащий данные записи
        {

        }*/
    }

    static void PrintMenu(FileInfo fileInf, string path)
    {
        Men:
        Console.Write("Enter the number:\n1.Get the list\n2.Add node\n3.Filter\n4.Exit\n");
        char ch = Convert.ToChar(Console.ReadLine());
        switch (ch)
        {
            case '1':
                {
                    Console.Clear();
                    ListMenu(fileInf, path);
                    break;
                }
            case '2':
                {
                    Console.Clear();
                    AddNode(fileInf, path);
                    break;
                }
            case '3':
                {
                    Console.Clear();
                    Filter();
                    break;
                }
            case '4':
                {
                    Console.Clear();
                    break;
                }
            default:
                {
                    Console.Clear();
                    Console.WriteLine("Error! Cannot get the the symbol");
                    Thread.Sleep(500);
                    Console.Clear();
                    goto Men;
                }
        }
    }
    private static void Main(string[] args)
    {
        string path = @"/Users/eviolspirid/Projects/c_sharp/str_stud/str_stud/content.txt";
        FileInfo fileInf = new FileInfo(path);
       
        PrintMenu(fileInf, path);

        System.Environment.Exit(0);
    }
}

