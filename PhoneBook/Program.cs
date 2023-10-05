using System;

namespace PhoneBook;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello from the PhoneBook app");

        Console.WriteLine("1. Add contact");
        Console.WriteLine("2. Remove contact by number");
        Console.WriteLine("3. Display contact by number");
        Console.WriteLine("4. Display all contacts");
        Console.WriteLine("5. Search contacts");
        Console.WriteLine("To exit insert 'X'");

        var userInput = Console.ReadLine();
        var phoneBook = new PhoneBook();

        while (true)
        {
            switch (userInput)
            {
                case "1":
                    Console.Write("Insert number:");
                    var number = Console.ReadLine();
                    Console.Write("Insert name:");
                    var name = Console.ReadLine();
                    var newContact = new Contact(name, number);
                    if (number.Length >=9 && name.Length >=3)
                    {
                        phoneBook.AddContact(newContact);
                    }
                    else
                    {
                        Console.WriteLine("Number should have at least 9 numbers!");
                        Console.WriteLine("Name should have at least 3 letters!");
                    }
                    
                    break;
                case "2":
                    Console.Write("Insert number to delete: ");
                    var numberToDelete= Console.ReadLine();
                    phoneBook.RemoveContact(numberToDelete);
                    Console.WriteLine("Number successfully deleted!");
                    break;
                case "3":
                    Console.WriteLine("Insert number:");
                    var numberToSearch = Console.ReadLine();

                    phoneBook.DisplayContact(numberToSearch);

                    break;
                case "4":
                    phoneBook.DisplayAllContact();
                    break;
                case "5":
                    Console.Write("Insert search phrase:");
                    var searchPhrase = Console.ReadLine();
                    phoneBook.DisplayMatchingNumber(searchPhrase);
                    break;
                case "x":
                    return;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            Console.WriteLine("Select operation:");
            userInput= Console.ReadLine();
        }
        
    }


}