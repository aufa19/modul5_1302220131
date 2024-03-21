using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public class Penjumlahan
    {
        public static void JumlahTigaAngka<T>(dynamic nim1, dynamic nim2, dynamic nim3, dynamic nim4)
        {
            Console.WriteLine($"Masukkan NIM: {nim1},{nim2},{nim3},{nim4}");
            if (nim1 == (1, 2))
            {
                new Penjumlahan().JumlahTigaAngka<dynamic>("float");
            }else if (nim2 == (3, 4, 5))
            {
                new Penjumlahan().JumlahTigaAngka<dynamic>("double");
            }else if(nim3 == (6, 7, 8))
            {
                new Penjumlahan().JumlahTigaAngka<dynamic>("int");
            }else if(nim4 == (9, 0))
            {
                new Penjumlahan().JumlahTigaAngka<dynamic>("long");
            }
        }

        private void JumlahTigaAngka<T>(string v)
        {
            throw new NotImplementedException();
        }
    }
}