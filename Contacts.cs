using System;

	public class Contacts
	{
        public string? phone { get; set; }
        public string? mail { get; set; }
        public Contacts()
		{
        Console.Write("Enter the Phone:");
        phone = Console.ReadLine();
        Console.Write("Enter the E-mail:");
        mail = Console.ReadLine();
        }
        public void GetInf()
        {
        Console.WriteLine($"Phone = {phone}\n Mail = {mail}\n\n");
        }
	}

