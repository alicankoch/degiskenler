using System;

namespace degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte b = 5;         //1 byte
            sbyte s = 5;        //1 byte
           
            short s1 = 5;       //2 byte
            ushort s2 = 5;      //2 byte

            Int16 i16 = 2;      //2 byte
            int i = 2;          //4 byte
            Int32 i32 = 2;      //4 byte
            Int64 i64 = 2;      //8 byte

            uint ui = 2;        //4 byte
            long l = 2;         //8 byte
            ulong ul = 2;       //8 byte

            //Reel Sayılar
            float f = 2;        //4 byte
            double d = 2;       //8 byte
            decimal c = 2;      //16 byte

            char ch = '2';      //2 byte
            string str = "Alican"; //sınırsızdır

            bool b1 = true;
            bool b2 = false;

            DateTime dt1 = DateTime.Now;
            Console.WriteLine(dt1);

            object o1 = 'x';
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;


            //string ifadeler

            string str1 = String.Empty;
            str1 = "Alican KOÇ";
            string ad = "Alican";
            string soyad = "KOÇ";
            string tamisim = ad + " " + soyad;

            //integer tanımlama

            int integer1 = 6;   
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolen

            bool bool1 = 10 > 2;

            //Değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); // çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); //çıktısı 40

            int int22 = int20 + int.Parse(str20); //çıktısı 40

            //datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime1 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime1);

            //saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);




        }
    }
}
