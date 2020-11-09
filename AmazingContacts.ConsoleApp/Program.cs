using AmazingContacts.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AmazingContacts.ConsoleApp
{
    class Program
    {
        //Represents our Database
        private static List<Contact> Contacts = new List<Contact>();

        static void Main(string[] args)
        {
            int option = 0;

            while(option != 3)
            {
                Console.WriteLine("1 - Register Contact");
                Console.WriteLine("2 - Print All Contacts");
                Console.WriteLine("3 - Exit");
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                    RegisterContact();
                else if (option == 2)
                    PrintAllContacts();

                //switch (option)
                //{
                //    case 1:
                //        RegisterContact();
                //        break;
                //    case 2:
                //        PrintAllContacts();
                //        break;
                //}
            }



        }

        static void RegisterContact()
        {
            var contact = new Contact();

            contact.Id = Guid.NewGuid(); //Randomly generates the Id

            Console.WriteLine("Type the contact Name:");
            contact.Name = Console.ReadLine();

            Console.WriteLine("Type the contact Phone:");
            contact.Phone = Console.ReadLine();

            Console.WriteLine("Type the contact E-mail:");
            contact.Email = Console.ReadLine();

            Console.WriteLine("Type the contact Address:");
            contact.Address = Console.ReadLine();

            Contacts.Add(contact);
        }

        static void PrintAllContacts()
        {
            Console.WriteLine();
            Console.WriteLine("######### All Contact #########");
            for(var i = 0 ; i < Contacts.Count; i++)
            {
                
                Console.WriteLine("Name : "+ Contacts[i].Name);
                Console.WriteLine("Phone : " + Contacts[i].Phone);
                Console.WriteLine("E-mail : " + Contacts[i].Email);
                Console.WriteLine("Address : " + Contacts[i].Address);
                Console.WriteLine();
            }
            Console.WriteLine("#################################");
            Console.WriteLine();

            //foreach(var contact in Contacts){
            //    Console.WriteLine("Name: " + contact.Name);
            //    Console.WriteLine("Phone: " + contact.Phone);
            //    Console.WriteLine("E-mail: " + contact.Email);
            //    Console.WriteLine("Address: " + contact.Address);
            //}
        }

        static void SearchByName()
        {
            Console.WriteLine("Type the contact name you want to look for:");
            string name = Console.ReadLine().ToLower();
            
            var searchResult = Contacts.Where(contact => contact.Name.Contains(name)).ToList();

            if (searchResult.Count == 0)
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            foreach(var contact in searchResult)
            {
                Console.WriteLine("Name: " + contact.Name);
                Console.WriteLine("Phone: " + contact.Phone);
                Console.WriteLine("E-mail: " + contact.Email);
                Console.WriteLine("Address: " + contact.Address);
            }
        }

        static void SearchByEmail()
        {
            Console.WriteLine("Type the contact email you want to look for:"); 
            string email = Console.ReadLine();

            if (email == null)
            {
                Console.WriteLine("Email not found");
                return;
            }

            var searchResult = Contacts.Where(contact => contact.Email.Contains(email)).ToList();

            foreach(var contact in searchResult)
            {
                Console.WriteLine("Name: " + contact.Name);
                Console.WriteLine("Phone: " + contact.Phone);
                Console.WriteLine("E-mail: " + contact.Email);
                Console.WriteLine("Address: " + contact.Address);
            }
        }
    }
}
