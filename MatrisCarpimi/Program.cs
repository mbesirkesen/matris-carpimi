using System;
using System.Text;

namespace MatrisCarpimi
{
    class Program
    {
        const int MaxBoyut = 50;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int n = PozitifTamSayiOku(
                "Lütfen matrisin boyutunu giriniz (N): ",
                MaxBoyut);

            int[,] matris1 = MatrisOku(n, "1. matris");
            int[,] matris2 = MatrisOku(n, "2. matris");
            int[,] sonuc = MatrisCarp(matris1, matris2, n);

            Console.WriteLine("\nMatrisin çarpım sonucu:");
            MatrisYazdir(sonuc, n);

            Console.WriteLine("\nÇıkmak için bir tuşa basın...");
            Console.ReadKey();
        }

        static int PozitifTamSayiOku(string mesaj, int ustSinir)
        {
            while (true)
            {
                Console.Write(mesaj);
                string giris = Console.ReadLine()?.Trim();

                if (int.TryParse(giris, out int deger) && deger > 0 && deger <= ustSinir)
                    return deger;

                Console.WriteLine($"Geçersiz giriş. 1 ile {ustSinir} arasında bir tam sayı giriniz.");
            }
        }

        static int TamSayiOku(string mesaj)
        {
            while (true)
            {
                Console.Write(mesaj);
                string giris = Console.ReadLine()?.Trim();

                if (int.TryParse(giris, out int deger))
                    return deger;

                Console.WriteLine("Geçersiz giriş. Lütfen bir tam sayı giriniz.");
            }
        }

        static int[,] MatrisOku(int n, string ad)
        {
            int[,] matris = new int[n, n];
            Console.WriteLine($"\n{ad} ({n}x{n}) değerlerini giriniz:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matris[i, j] = TamSayiOku($"  [{i + 1},{j + 1}]: ");
                }
            }

            return matris;
        }

        static int[,] MatrisCarp(int[,] a, int[,] b, int n)
        {
            int[,] sonuc = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        sonuc[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return sonuc;
        }

        static void MatrisYazdir(int[,] matris, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matris[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
