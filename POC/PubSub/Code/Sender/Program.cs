using System;
using Neuron.Esb;

namespace Neudesic.EnterpriseServiceBus.Samples
{
    public class Sender
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Initializing sender");

                using (Publisher publisher = new Publisher())
                {
                    publisher.Connect();

                    Console.WriteLine("Press <ENTER> to start sending");
                    Console.ReadLine();

                    Contact contact = CreateContact();
                    Console.WriteLine("Sending contact");
                    publisher.Send("CACTopic.Message", contact);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
            finally
            {
                Console.WriteLine("Press <ENTER> to shut down.");
                Console.ReadLine();
            }
        }

        private static Contact CreateContact()
        {
            Contact contact = new Contact();

            contact.ContactType = ContactType.Customer;
            contact.LastName = "Augustine";
            contact.FirstName = "Linson";
            contact.Street = "100 Main St";
            contact.Street2 = "";
            contact.City = "Los Angeles";
            contact.Region = "CA";
            contact.PostalCode = "99123";
            contact.Country = "USA";
            contact.Phone = "555-123-4567";
            contact.Email = "john.smith@acme.com";

            return contact;

        }
    }

    [Serializable]
    public enum ContactType { Other, Customer, Vendor, Personal }

    [Serializable]
    public class Contact
    {
        public ContactType ContactType;
        public string LastName;
        public string FirstName;
        public string Street;
        public string Street2;
        public string City;
        public string Region;
        public string PostalCode;
        public string Country;
        public string Phone;
        public string Email;

    }
}
