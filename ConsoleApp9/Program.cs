using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.oyuncu ismini giriniz:");
            string isim1= Console.ReadLine();
            Console.WriteLine("2.oyuncu ismini giriniz:");
            string isim2=Console.ReadLine();
            
            Random sayiGen = new Random();   // Nesne Belirtilir 
            int zar = sayiGen.Next(1, 7);
            int zar2 = sayiGen.Next(1, 7);
            Console.WriteLine("{0}-{1}", zar,zar2);
            string kazanan = " ";
            if (zar > zar2)
                kazanan = isim1;
            else if (zar2 > zar)
                kazanan = isim2;
            else
                kazanan = "berabere";
            Console.WriteLine(kazanan);
                    
                    //iki kere sayigen tanımlarsak hep aynı sayı gelir
        }
    }
}
