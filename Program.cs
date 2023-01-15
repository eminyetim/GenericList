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
            List<string> hayvanlarListesi = new List<string>();

        }
    }
}