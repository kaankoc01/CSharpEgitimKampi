using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            // 2,4,6,8
            // Değişken Türü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Gri";
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lion";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[8]);

            // başka dizi oluşturma yolu

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };
            //for (int i = 0; i < colors.Length; i++) 
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 3, 85, 96, 74, 125, 635, 438, 520, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i] + " Sayısı 3 e tam bölünüyör");
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++) 
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 24, 636, 542, 100 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++) 
            //{
            //    if (myArray[i] > maxNumber)
            //    { 
            //        maxNumber = myArray[i]; 
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "Ali", "Ahmet", "Ayşe", "Buse", "Cem", "Deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 82, 52, 41, 10, 22, 35, 33 };
            //// küçükten büyüğe sıralama bu.

            // Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 82, 52, 41, 10, 22, 35, 33 };
            //// reverse tersine çeviriyor , sort = küçükten büyüğe getiiryor.
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++) {

            //    Console.WriteLine(numbers[i]);
            //}

            #endregion
            #region Dizi Metotları

            //string[] customers = { "Ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //// dizideki aradığın değerin indexini getirtme
            //int index = Array.IndexOf(customers, "merve");
            //    Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 10, 22, 34, 64, 12 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() +" Dizinin en küçük elemanı: " + numbers.Min()) ;


            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.Write($"Lütfen {i +1 }. Şehri giriniz");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------");

            //for (int i = 0; i < cities.Length; i++) {
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = {10,20,30,40,50};
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{ 
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 21, 32, 43, 54, 56, 766, 677, 778, 449, 120 };
            //Console.WriteLine("Çift Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 ==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}
            //Console.WriteLine("--------------------");
            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            #endregion
            Console.Read();
        }
    }
}
