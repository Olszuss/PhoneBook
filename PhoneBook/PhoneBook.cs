using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
     class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
                Contacts.Add(contact);
        }

        public void RemoveContact(string number)
        {
            var contactToRemove = Contacts.FirstOrDefault(x => x.Number == number);
            Contacts.Remove(contactToRemove);
        }

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }
        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(x => x.Number == number);

            if (contact == null)
            {
                Console.WriteLine("Contact not found!");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayAllContact()
        {
            DisplayContactsDetails(Contacts);
        }

        public void DisplayMatchingNumber(string searchPhrase)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }
    }
}
