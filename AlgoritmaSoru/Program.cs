using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoritmaSoru
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir dizi giriniz");
            string dizi = Console.ReadLine().ToLower();
            if (string.IsNullOrWhiteSpace(dizi)) //girilen dizinin null olup olmadığını kontrol ediyoruz değilse return
            {
                Console.WriteLine("no");
                return;
            }
            List<char> diziHarf = new List<char>(); // bir harf dizisi oluşturuyorz
            foreach (char item in dizi) // girilen dizide aynı olmayan harfleri dizinin içine ekliyoruz
            {
                if (!diziHarf.Any(x => x == item))
                {
                    diziHarf.Add(item);
                }
            }

            foreach (var item in diziHarf)
            {
                int harfSayisi = dizi.Count(a => a == item); //burada takıldım güncellenmiş şekilde tekrar atacağım 
                if (harfSayisi==1)
                {
                    Console.WriteLine("YES");
                }
            }   

        }
    }
}

