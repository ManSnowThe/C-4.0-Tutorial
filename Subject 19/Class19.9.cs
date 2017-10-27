// Использовать запрос для получения последовательности объектов
// типа EmailAddresses из списка объектов типа ContactInfo.using System;
using System.Linq;

namespace ca2
{
    class ContactInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ContactInfo(string n, string a, string p)
        {
            Name = n;
            Email = a;
            Phone = p;
        }
    }
    class EmailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public EmailAddress(string n, string a)
        {
            Name = n;
            Address = a;
        }
    }
    class SelectDemo3
    {
        static void Main()
        {
            ContactInfo[] contacts =
            {
                new ContactInfo("Герберт", "Herb@HerbSchildt.com", "555-1010"),
                new ContactInfo("Том", "Tom@HerbSchildt.com", "555-1101"),                new ContactInfo("Сара", "Sara@HerbSchildt.com", "555-0110")
            };
            // Сформировать запрос на получение списка объектов типа EmailAddress.
            var emailList = from entry in contacts
                            select new EmailAddress(entry.Name, entry.Email);

            Console.WriteLine("Список адресов электронной почты:");

            // Выполнить запрос и вывести его результаты.
            foreach (EmailAddress e in emailList)
                Console.WriteLine(" {0}, {1}", e.Name, e.Address);
        }
    }
}
