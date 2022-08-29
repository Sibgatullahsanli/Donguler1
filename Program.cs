internal class Program
{
    private static void Main(string[] args)
    {
        // Ekranda girilen sayıya kadar olan tek sayıları ekrana yazdırma işlemi.
        Console.WriteLine("lütfen bir sayı giriniz.");
        int sayac = int.Parse(Console.ReadLine());
        for (int i = 1; i <= sayac; i++)
          
        {    // komutlar
            if(i%2 == 1)
              Console.WriteLine(i);

        }   
         
        // 1 ile 1000 arası tek ve çift sayıların kendi içlerinde  toplamlarnı ekrana yazdır.
        int tekToplam = 0;
        int ciftToplam = 0;
        for (int i = 1; i <= 1000; i++)
        {
            if(i%2 == 1)
                tekToplam += i; // tekToplam = tekToplam + i;
            else
                ciftToplam += i; // çiftToplam = çiftToplam + i;   
        }
        Console.WriteLine("tekToplam:" + tekToplam);
        Console.WriteLine("ciftToplam:" + ciftToplam);
        
        // Break döngüyü tamamlamadan tamamen sonlandırmakta 
        // continue döngünün sadece continue bulunduğu saykılı atlayıp döngüye evam eder.
        Console.WriteLine("*****Break ve continue: kiywordleri*****");
        for (int i = 1; i < 10; i++)
        {
            if(i==4)
               break;
            Console.WriteLine(i);    
        }
        for (int i = 1; i < 10; i++)
        {
            if(i==4)
               continue;
            Console.WriteLine(i);
        }

    }
}