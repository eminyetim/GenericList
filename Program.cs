using System;

namespace GenericList
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);


            List<string> renkListesi = new();

            renkListesi.Add("Kirmizi");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sari");
            renkListesi.Add("Yeşil");

            System.Console.WriteLine("--SayiListesi--");
            // foreach (var item in sayiListesi)
            //     System.Console.WriteLine(item);
            sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
            
            System.Console.WriteLine("\n--RenkListesi--");
            // foreach (var item in renkListesi)
            //     System.Console.WriteLine();
            renkListesi.ForEach(renk => System.Console.WriteLine(renk));

            sayiListesi.Remove(4);
            renkListesi.Remove("Sari");

            sayiListesi.RemoveAt(1);
            renkListesi.RemoveAt(2);

            System.Console.WriteLine("--SayiListesi--");
            sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
            System.Console.WriteLine("\n--RenkListesi--");
            renkListesi.ForEach(renk => System.Console.WriteLine(renk));

            //Search
            if(sayiListesi.Contains(10));
                System.Console.WriteLine("Listede 10 var");
            
            System.Console.WriteLine("Index Of Mavi :"+renkListesi.BinarySearch("Yeşil"));
          
            //Converting Array to List
            string[] Hayvanlar = {"Kedi","Köpek","Kuş"};
            List<string> hayvanlarListesi = new List<string>(Hayvanlar);

            //Clear
            hayvanlarListesi.Clear();

            //List of Object

            List<Kullanicilar> kullanicilarListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            Kullanicilar kullanici2 = new Kullanicilar();

            kullanici1.Isim = "ali";
            kullanici1.Soyisim = "ytm";
            kullanici1.Yas = 61;

            kullanici2.Isim = "veli";
            kullanici2.Soyisim = "ytm";
            kullanici2.Yas = 16;

            kullanicilarListesi.Add(kullanici1);
            kullanicilarListesi.Add(kullanici2);


            foreach (var item in kullanicilarListesi)
            {
                System.Console.WriteLine(item.Isim + item.Soyisim + item.Yas);
            }

            List<Kullanicilar> yeniList = new List<Kullanicilar>();
            yeniList.Add(new Kullanicilar()
            {
                Isim = "ysf",
                Soyisim = "clk",
                Yas = 24   
            });

            foreach (var item in yeniList)
            {
                System.Console.WriteLine(item.Isim + item.Soyisim + item.Yas);
            }

            yeniList.Clear();
            kullanicilarListesi.Clear();

        }
    }

    class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}