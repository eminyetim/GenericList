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

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

              System.Console.WriteLine("--SayiListesi--");
            // foreach (var item in sayiListesi)
            //     System.Console.WriteLine(item);
            sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
            
            System.Console.WriteLine("\n--RenkListesi--");
            // foreach (var item in renkListesi)
            //     System.Console.WriteLine();
            renkListesi.ForEach(renk => System.Console.WriteLine(renk));




           
          

        }
    }
}