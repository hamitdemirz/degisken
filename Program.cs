using System;

name space degisken
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int deger= 2;
            string degisken = null;
            string Degisken= null;

            Console.WriteLine{"deger"};

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt)
            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            //string ifadeler

            string str1 = string.Empty;
            str1 = "Zikriye Ürkmez";
            string ad = "Zikriye";
            string soyad = "Ürkmez";
            string tamIsim = ad + " " + soyad;

            //integer tanımlama sekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            // boolean

            bool bool 1 = 10>2;

            // degisken donusumleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int22 = int20 + int.Parse(int20);

            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);



         }
    }
}