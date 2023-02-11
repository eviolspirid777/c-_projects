using System;
using System.Net;

	public class Address
	{
        public string? city { get; set; }
        public string? pstIndex { get; set; }
        public string? street { get; set; }
        public Address()
		{
        Console.WriteLine("Enter the City:");
        city = Console.ReadLine();
        Console.Write("Enter the Post Index:");
        pstIndex = Console.ReadLine();
        Console.Write("Enter the Street:");
        street = Console.ReadLine();
        }
        public void GetInf()
        {
            Console.WriteLine($"City = {city}\n Post Index = {pstIndex}\n Street = {street}\n");
        }
	}


