using System;
using System.Collections.Generic;

namespace WindowsFormsApp4.Data
{
    public static class DataStore
    {
        public static List<Musteri> Musteriler { get; } = new List<Musteri>();
        public static List<Temsilci> Temsilciler { get; } = new List<Temsilci>();
        public static List<Talep> Talepler { get; } = new List<Talep>();
        public static List<GeriBildirim> GeriBildirimler { get; } = new List<GeriBildirim>();

        static DataStore()
        {
            var rep1 = new Temsilci { Ad = "Hüseyin Emre", Soyad = "Bülbül" };
            var rep2 = new Temsilci { Ad = "Kerem Efe", Soyad = "Sezek" };
            Temsilciler.Add(rep1);
            Temsilciler.Add(rep2);

            var cust1 = new Musteri
            {
                Ad = "Beyza Nur",
                Soyad = "Babur",
                Telefon = "0555 555 55 55",
                Email = "beyzanurbabur@example.com",
                TemsilciID = rep2.Id
            };
            var cust2 = new Musteri
            {
                Ad = "Azra",
                Soyad = "Erkiz",
                Telefon = "0544 444 44 44",
                Email = "azraerkiz@example.com",
                TemsilciID = rep1.Id
            };
            Musteriler.Add(cust1);
            Musteriler.Add(cust2);

            Talepler.Add(new Talep
            {
                Konu = "Ürün arızası",
                Detay = "Cihaz açılmıyor, servis gerekiyor.",
                MusteriID = cust2.Id,
                TemsilciID = rep1.Id
            });
            Talepler.Add(new Talep
            {
                Konu = "Fiyat teklifi",
                Detay = "10 adet ürün için indirim talebi.",
                MusteriID = cust1.Id,
                TemsilciID = rep2.Id
            });

            GeriBildirimler.Add(new GeriBildirim
            {
                Metin = "Web sitenizde bağlantı hatası var!",
                Tamamlandı = true
            });
            GeriBildirimler.Add(new GeriBildirim
            {
                Metin = "Canlı destek hattı 7/24 olsa harika olur.",
                Tamamlandı = false
            });
        }
    }
}
