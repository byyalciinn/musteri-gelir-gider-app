using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ana Menü döngüsü
            while (true)
            {
                Console.WriteLine("\nAna Menü:");
                Console.WriteLine("1. Müşteri Ekle");
                Console.WriteLine("2. Gelir/Gider Ekle");
                Console.WriteLine("3. Müşteri Listesini Göster");
                Console.WriteLine("4. Müşteri Detayını Göster");
                Console.WriteLine("5. Çıkış");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Müşteri adı: ");
                        var name = Console.ReadLine();
                        AddCustomer(name);
                        break;

                    case "2":
                        Console.Write("Müşteri adı: ");
                        var customerName = Console.ReadLine();
                        Console.Write("Tutar (gelir/gider): ");
                        var amount = decimal.Parse(Console.ReadLine());
                        Console.Write("Açıklama: ");
                        var description = Console.ReadLine();
                        AddTransaction(customerName, amount, description);
                        break;

                    case "3":
                        ListCustomers();
                        break;

                    case "4":
                        Console.Write("Müşteri adı: ");
                        var nameToShow = Console.ReadLine();
                        ShowCustomerDetails(nameToShow);
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Geçersiz seçenek, tekrar deneyin.");
                        break;
                }
            }
        }

        public static void AddCustomer(string name)
        {
            // Yeni müşteri ekleme
            Customer newCustomer = new Customer
            {
                Name = name
            };
            Database.Customers.Add(newCustomer);
            Console.WriteLine($"Müşteri {name} eklendi.");
        }

        public static void AddTransaction(string customerName, decimal amount, string description)
        {
            // Gelir/Gider ekleme
            var customer = Database.Customers.FirstOrDefault(c => c.Name == customerName);
            if (customer != null)
            {
                var transaction = new Transaction
                {
                    Date = DateTime.Now,
                    Amount = amount,
                    Description = description
                };
                customer.Transactions.Add(transaction);
                Console.WriteLine($"İşlem başarıyla eklendi: {amount} TL - {description}");
            }
            else
            {
                Console.WriteLine("Müşteri bulunamadı.");
            }
        }

        public static void ListCustomers()
        {
            // Müşteri listesini gösterme
            Console.WriteLine("Müşteri Listesi:");
            foreach (var customer in Database.Customers)
            {
                Console.WriteLine($"{customer.Name} - Borç: {customer.Debt} TL - Alacak: {customer.Credit} TL - Bakiye: {customer.Balance} TL");
            }
        }

        public static void ShowCustomerDetails(string customerName)
        {
            // Müşteri detaylarını gösterme
            var customer = Database.Customers.FirstOrDefault(c => c.Name == customerName);
            if (customer != null)
            {
                Console.WriteLine($"{customer.Name} - Giriş/Çıkışlar:");
                foreach (var transaction in customer.Transactions)
                {
                    Console.WriteLine($"{transaction.Date.ToString("dd/MM/yyyy")} - {transaction.Description}: {transaction.Amount} TL");
                }
            }
            else
            {
                Console.WriteLine("Müşteri bulunamadı.");
            }
        }
    }

    // Müşteri sınıfı
    public class Customer
    {
        public string Name { get; set; }
        public decimal Debt { get; set; }
        public decimal Credit { get; set; }
        public decimal Balance => Credit - Debt; // Bakiye, alacak - borç
        public List<Transaction> Transactions { get; set; } = new List<Transaction>(); // Gelir/Gider kayıtları
    }

    // Gelir/Gider sınıfı
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; } // Gelir veya gider
    }

    // Veritabanı (in-memory)
    public static class Database
    {
        public static List<Customer> Customers { get; set; } = new List<Customer>();
    }
}
