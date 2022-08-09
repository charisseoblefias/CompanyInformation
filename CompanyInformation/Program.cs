using System;

class CompanyInformation
{
	static void Main(string [] args)
	{
		Console.Write("Enter company name: ");
		string CompanyName = Console.ReadLine();
		
		Console.Write("Enter company address: ");
		string CompanyAddress = Console.ReadLine();
		
		Console.Write("Enter company phone number: ");
		string CompanyPhoneNumber = Console.ReadLine();
		
		Console.Write("Enter company fax number: ");
		string CompanyFaxNumber = Console.ReadLine();
		
		Console.Write("Enter company web site: ");
		string CompanyWebSite = Console.ReadLine();
		
		Console.Write("Enter company manager: ");
		string CompanyManager = Console.ReadLine();
		
		Console.Write("Enter manager's first name: ");
		string ManagerFirstName = Console.ReadLine();
		
		Console.Write("Enter manager's last name : ");
		string ManagerLastName = Console.ReadLine();
		
		Console.Write("Enter manager's age: ");
		string ManagerAge = Console.ReadLine();
		
		Console.Write("Enter manager's phone number: ");
		string ManagerPhoneNumber = Console.ReadLine();
		
		Console.WriteLine();
		Console.WriteLine("Company Name: {0}, ", CompanyName);
		Console.WriteLine("Address: {0}, ", CompanyAddress);
		Console.WriteLine("Phone Number: {0}, ", CompanyPhoneNumber);
		Console.WriteLine("Fax: {0}", CompanyFaxNumber);
		Console.WriteLine("Web site: {0}", CompanyWebSite);
		Console.WriteLine("Manager: {0}", CompanyManager);
		Console.WriteLine("Manager's Name: {0} {1}", ManagerFirstName, ManagerLastName);
		Console.WriteLine("Age: {0}", ManagerAge);
		Console.WriteLine("Phone Number: {0}", ManagerPhoneNumber);
		Console.ReadKey();
		
	}
}