using System;

class Person
{
    public string? FIO { get; set; }


    public Curriculum curriculum;
    public Address address;
    public Contacts contacts;
    public void SetInf()
    {
        Console.WriteLine("Enter the INITIALS:");
        FIO = Console.ReadLine();
        curriculum = new Curriculum();
        address = new Address();
        contacts = new Contacts();
    }

    public void GetInf()
    {
        Console.WriteLine($" FIO = {FIO}\n");
        curriculum.GetInf();
        address.GetInf();
        contacts.GetInf();
    }

};

