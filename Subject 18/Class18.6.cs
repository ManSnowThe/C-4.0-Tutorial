﻿// Применить ограничение на интерфейс.using System;

namespace ca2
{
    // Специальное исключение, генерируемое в том случае,
    // если имя или номер телефона не найдены.
    class NotFoundException : Exception
    {
        /* Реализовать все конструкторы класса Exception.
Эти конструкторы выполняют вызов конструктора базового класса.
Класс NotFoundException ничем не дополняет класс Exception и
поэтому не требует никаких дополнительных действий. */
        public NotFoundException() : base() { }
        public NotFoundException(string str) : base(str) { }
        public NotFoundException(string str, Exception inner) : base(str, inner) { }
        protected NotFoundException( System.Runtime.Serialization.SerializationInfo si,
        System.Runtime.Serialization.StreamingContext sc) : base(si, sc) { }
    }
    // Интерфейс, поддерживающий имя и номер телефона.
    public interface IPhoneNumber
    {
        string Number
        {
            get;
            set;
        }
        string Name
        {
            get;
            set;
        }
    }
    // Класс для телефонных номеров друзей.
    // В нем реализуется интерфейс IPhoneNumber.
    class Friend : IPhoneNumber
    {
        public Friend(string n, string num, bool wk)
        {
            Name = n;
            Number = num;
            IsWorkNumber = wk;
        }
        public bool IsWorkNumber { get; private set; }
        // Реализовать интерфейс IPhoneNumber.
        public string Name { get; set; }
        public string Number { get; set; }
        // ...
    }
    // Класс телефонных номеров поставщиков.
    class Supplier : IPhoneNumber
    {
        public Supplier (string n, string num)
        {
            Name = n;
            Number = num;
        }
        // Реализовать интерфейс IPhoneNumber.
        public string Name { get; set; }
        public string Number { get; set; }
        // ...
    }
    // Класс PhoneList способен управлять любым видом списка телефонных
    // номеров, при условии, что он реализует интерфейс IPhoneNumber.
    class PhoneList<T>where T : IPhoneNumber
    {
        T[] phList;
        int end;

        public PhoneList()
        {
            phList = new T[10];
            end = 0;
        }
        public bool Add(T newEntry)
        {
            if (end == 10) return false;
            phList[end] = newEntry;
            end++;
            return true;
        }
        // Найти и возвратить сведения о телефоне по заданному имени.        public T FindByName(string name)
        {
            for(int i = 0; i < end; i++)
            {
                // Имя может использоваться, потому что его свойство Name
                // относится к членам интерфейса IPhoneNumber, на который
                // накладывается ограничение.
                if (phList[i].Name == name)
                    return phList[i];
            }
            // Имя отсутствует в списке.
            throw new NotFoundException();
        }
        // Найти и возвратить сведения о телефоне по заданному номеру.        public T FindByNumber(string number)
        {
            for(int i = 0; i < end; i++)
            {
                // Номер телефона также может использоваться, поскольку его
                // свойство Number относится к членам интерфейса IPhoneNumber,
                // на который накладывается ограничение.
                if (phList[i].Number == number)
                    return phList[i];
            }
            // Номер отсутствует в списке.
            throw new NotFoundException();
        }
        // ...
    }
    // Продемонстрировать наложение ограничения на интерфейс.
    class UseInterfaceConstraint
    {
        static void Main()
        {
            // Следующий код вполне допустим, поскольку
            // в классе Friend реализуется интерфейс IPhoneNumber.
            PhoneList<Friend> plist = new PhoneList<Friend>();
            plist.Add(new Friend("Том", "555-1234", true));
            plist.Add(new Friend("Гари", "555-6756", true));
            plist.Add(new Friend("Матт", "555-9254", false));
            try
            {
                // Номер телефона по заданному имени друга
                Friend frnd = plist.FindByName("Гари");
                Console.Write(frnd.Name + " " + frnd.Number);
                if (frnd.IsWorkNumber)
                    Console.WriteLine(" (рабочий)");
                else
                    Console.WriteLine();
            }
            catch (NotFoundException)
            {
                Console.WriteLine("Не найдено");
            }
            Console.WriteLine();

            // Следующий код также допустим, поскольку в классе Supplier
            // также реализуется интерфейс IPhoneNumber.
            PhoneList<Supplier> plist2 = new PhoneList<Supplier>();
            plist2.Add(new Supplier("Фирма Global Hardware", "555-8834"));
            plist2.Add(new Supplier("Агентство Computer Warehouse", "555-9256"));
            plist2.Add(new Supplier("Компания NetworkCity", "555-2564"));
            try
            {
                // Наименование поставщика по заданному номеру телефона
                Supplier sp = plist2.FindByNumber("555-2564");
                Console.WriteLine(sp.Name + " " + sp.Number);
            }
            catch (NotFoundException)
            {
                Console.WriteLine();
            }
            Console.WriteLine();
            // Следующее объявление недопустимо, поскольку
            // в классе EmailFriend НЕ реализуется интерфейс IPhoneNumber.
            // PhoneList<EmailFriend> plist3 =
            // new PhoneList<EmailFriend>(); // Ошибка!
        }
    }
}