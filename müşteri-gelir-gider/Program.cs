using System;
using System.Collections.Generic;

public class Musteri
{
    public string Adi { get; set; }
    public decimal Borc { get; set; }
    public decimal Alacak { get; set; }
    public decimal Bakiye { get; set; }
    public List<DateTime> GirişÇıkışTarihler { get; set; } = new List<DateTime>();

    public Musteri(string adi, decimal borc, decimal alacak)
    {
        Adi = adi;
        Borc = borc;
        Alacak = alacak;
        Bakiye = Alacak - Borc;
    }

    public void EkleGirisCikis(DateTime tarih)
    {
        GirişÇıkışTarihler.Add(tarih);
    }
}

public class Program
{
    public static List<Musteri> musteriler = new List<Musteri>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("//////////// Müşteri Sistemi //////////////");
            Console.WriteLine("");
            Console.WriteLine("1. Müşteri Listeleni GÖrünütle");
            Console.WriteLine("2. Yeni Müşteri Ekle");
            Console.WriteLine("3. Gelir/Gider Ekle");
            Console.WriteLine("4. Müşteri Detaylarını Göster");
            Console.WriteLine("5. Çıkış Yapmak İçin");
            Console.WriteLine("");
            Console.Write("Seçiminizi yapın: ");
            var secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    MusteriListele();
                    break;
                case "2":
                    MusteriEkle();
                    break;
                case "3":
                    GelirGiderEkle();
                    break;
                case "4":
                    MusteriDetayGoster();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim yaptınız. Lütfen Tekrar deneyiniz.");
                    break;
            }

            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }

    static void MusteriListele()
    {
        Console.WriteLine("\n//// Müşteri Listesi ////");
        foreach (var musteri in musteriler)
        {
            Console.WriteLine($"İsim: {musteri.Adi} \n Borç: {musteri.Borc} \n Alacak: {musteri.Alacak} \n Bakiye: {musteri.Bakiye}");
        }
    }

    static void MusteriEkle()
    {
        Console.Write("\nMüşteri Adı: ");
        string adi = Console.ReadLine();

        Console.Write("Borç: ");
        decimal borc = decimal.Parse(Console.ReadLine());

        Console.Write("Alacak: ");
        decimal alacak = decimal.Parse(Console.ReadLine());

        Musteri yeniMusteri = new Musteri(adi, borc, alacak);
        musteriler.Add(yeniMusteri);

        Console.WriteLine("Müşteri başarıyla eklendi.");
    }

    static void GelirGiderEkle()
    {
        Console.Write("\nMüşteri Adı: ");
        string adi = Console.ReadLine();

        Musteri musteri = musteriler.Find(m => m.Adi.Equals(adi, StringComparison.OrdinalIgnoreCase));

        if (musteri != null)
        {
            Console.Write("Gelir: ");
            decimal gelir = decimal.Parse(Console.ReadLine());

            Console.Write("Gider: ");
            decimal gider = decimal.Parse(Console.ReadLine());

            musteri.Alacak += gelir;
            musteri.Borc += gider;
            musteri.Bakiye = musteri.Alacak - musteri.Borc;

            musteri.EkleGirisCikis(DateTime.Now);

            Console.WriteLine("Gelir ve gider başarıyla güncellendi.");
        }
        else
        {
            Console.WriteLine("Müşteri bulunamadı.");
        }
    }

    static void MusteriDetayGoster()
    {
        Console.Write("\nMüşteri Adı: ");
        string adi = Console.ReadLine();

        Musteri musteri = musteriler.Find(m => m.Adi.Equals(adi, StringComparison.OrdinalIgnoreCase));

        if (musteri != null)
        {
            Console.WriteLine($"{musteri.Adi} - Borç: {musteri.Borc} - Alacak: {musteri.Alacak} - Bakiye: {musteri.Bakiye}");
            Console.WriteLine("Giriş-Çıkış Tarihleri:");
            foreach (var tarih in musteri.GirişÇıkışTarihler)
            {
                Console.WriteLine(tarih);
            }
        }
        else
        {
            Console.WriteLine("Müşteri bulunamadı...");
        }
    }
}
