using System;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Serialization;

//string path = @"/Users/eviolspirid/Projects/c_sharp/str_stud/str_stud/content.txt";

internal class Program
{
    class Person
    {
     static int counter;
     public string? FIO { get; set; }
     public string? faculty { get; set; }
     public string? specialty { get; set; }
     public string? course { get; set; }
     public string? group { get; set; }
     public string? city { get; set; }
     public string? pstIndex { get; set; }
     public string? street { get; set; }
     public string? phone { get; set; }
     public string? mail { get; set; }


        public void SetInf()
        {
            Console.WriteLine("Enter the INITIALS:");
            FIO = Console.ReadLine();
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
            pstIndex = Console.ReadLine();
            Console.Write("Enter the Street:");
            street = Console.ReadLine();
            Console.Write("Enter the Phone:");
            phone = Console.ReadLine();
            Console.Write("Enter the E-mail:");
            mail = Console.ReadLine();
          
        }
        public void GetInf()
        {
            Console.WriteLine($" FIO = {FIO}\n Faculty = {faculty}\n Specialty = {specialty}\n Course = {course}\n Group = {group}\n City = {city}\n PostIndex = {pstIndex}\n Street = {street}\n Phone = {phone}\n Mail = {mail}\n\n");
        }
            
    };

    void prop_inf(string text)
    {
        Person tem_h = new Person();
        int fio = text.IndexOf("FIO");
                                                   //прописать функцию friendly и присвоить конкретное слово соотв временному объекту
        int facult = text.IndexOf("Faculty");
        int spec = text.IndexOf("Specialty");
        int course = text.IndexOf("Course");
        int group = text.IndexOf("Group");
        int city = text.IndexOf("City");
        int post = text.IndexOf("PostIndex");
        int strt = text.IndexOf("Street");
        int phn = text.IndexOf("Phone");
        int mail = text.IndexOf("Mail");
    }

    static void ListMenu(FileInfo fileInf, string path)
    {
        
        if (fileInf.Exists)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine())!= null)
                {
                    //Console.WriteLine(line);
                    string jsonString = File.ReadAllText(path);
                    Person exmpl = JsonSerializer.Deserialize<Person>(jsonString)!; //ПРЕДСТАВИТЬ ВВИДЕ МАССИВА И ОТРАБОТАТЬ КАЖДЫЙ ЭЛЕМЕНТ ЧЕРЕЗ ЦИКЛ
                    exmpl.GetInf();
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    PrintMenu(fileInf,path);

                }
            }
            /*
                string text = reader.ReadLine();
                Console.WriteLine(text);
                string jsonString = File.ReadAllText(path);
                Person exmpl = JsonSerializer.Deserialize<Person>(jsonString)!;
            */
                /*
                Person tem_h = new Person();
                string tag = text.Substring(text.IndexOf("FIO "), text.IndexOf(","));
                string facult = text.Substring(text.IndexOf("Faculty "), text.IndexOf(","));
                string spec = text.Substring(text.IndexOf("Specialty"),text.IndexOf(","));
                string course = text.Substring(text.IndexOf("Course"), text.IndexOf(','));
                string group = text.Substring(text.IndexOf("Group"), text.IndexOf(','));
                string city = text.Substring(text.IndexOf("City"), text.IndexOf(','));
                string post = text.Substring(text.IndexOf("PostIndex"), text.IndexOf(','));
                string strt = text.Substring(text.IndexOf("Street"), text.IndexOf(','));
                string phn = text.Substring(text.IndexOf("Phone"), text.IndexOf(','));
                string mail = text.Substring(text.IndexOf("Mail"));
                tag.Remove(0, tag.IndexOf("=")+1);
                Console.WriteLine(tag);
                Console.WriteLine(facult);
                Console.WriteLine(spec);
                Console.WriteLine(course);
                Console.WriteLine(city);
                Console.WriteLine(post);
                Console.WriteLine(strt);
                Console.WriteLine(phn);
                Console.WriteLine(mail);
                */
         
        }
        else
            Console.WriteLine("Cannot find the file!");
    }

    static void AddNode(FileInfo fileInf, string path)
    {
        Person human = new Person();
        if (fileInf.Exists)
        {
            human.SetInf();
            //string originalText = human.GetInf();
            string jsonString = JsonSerializer.Serialize(human);
            File.AppendAllText(path, jsonString);
            Console.Clear();
            PrintMenu(fileInf, path);
            
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
        string path = @"/Users/eviolspirid/Projects/c_sharp/str_stud/str_stud/content.json";
        FileInfo fileInf = new FileInfo(path);
       
        PrintMenu(fileInf, path);

        System.Environment.Exit(0);
    }
}

