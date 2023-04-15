/* FONKSİYON İLE KARENİN ÇEVRESİ 
using System;

public class Program
{ 
    public static void kare(int sayi)
    {
         sayi = sayi * 4;
        Console.WriteLine("Karenin çevresi: "+sayi);
    }

    public static void Main()
    {
    Console.Write("çevresini hesaplatacağınız karenin bir kenarını giriniz: ");
    int kenar=Convert.ToInt32(Console.ReadLine());
        kare(kenar);
    }
} */
/* FONKSİYON İLE DAİRENİN ALANI
using System;

public class Program
{
    public static void daire(int r)
    {
        int alan = 3 * r * r;
        Console.WriteLine("dairenin alanı: "+alan);
    }

    public static void Main()
    {
        Console.Write("bir sayı giriniz: ");
        int r = Convert.ToInt32(Console.ReadLine());
        daire(r);
    }
}*/
/* FONKSİYON İLE DAİRENİN ÇEVRESİ
public class Program
{
    public static void daire(int r)
    {
        int pi = 3;
        int cevre = (2*pi)*r;
        Console.WriteLine("dairenin alanı: " + cevre);
    }

    public static void Main()
    {
        Console.Write("bir sayı giriniz: ");
        int r = Convert.ToInt32(Console.ReadLine());
        daire(r);
    }
} */
/* FONKSİYON İLE ÜÇGEN 
public class Program
{
    public static void ucgen(int k1, int k2, int k3)
    {
        if (k1 == k2 && k2 == k3 && k1 == k3)
        {
            Console.WriteLine("eşkenar üçgen");
        }
        else if (k1 == k2 || k1 == k3 || k3 == k2)
        {
            Console.WriteLine("ikizkenar üçgen");
        }
        else
            Console.WriteLine("Çeşitkenar üçgen");
    }
   
    public static void Main()
    {
        Console.Write("bir kenar giriniz: ");
        int k1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("bir kenar giriniz: ");
        int k2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("bir kenar giriniz: ");
        int k3 = Convert.ToInt32(Console.ReadLine());
        ucgen(k1, k2, k3);
    }
} */
/* YOL PROBLEMİ 
public class Program
{
    public static void YOL(int yol, int zaman)
    {
       
        Console.WriteLine("gidilen hız=" + yol/zaman);
    }

    public static void Main()
    {
        Console.Write("Araç kaç km yol gitmiş? ");
        int yol=Convert.ToInt32(Console.ReadLine());
        Console.Write("Geçilen süre(saat cinsinden)? ");
        int zaman=Convert.ToInt32(Console.ReadLine());
        YOL(yol, zaman);
    }
} */
/* FONKSİYON İLE Y.S 
public class Program
{
    static int hesap = 0;
    public static void yiyecek()
    {
        Console.WriteLine("İstediğiniz yemeğin numarasını giriniz: ");
        Console.WriteLine("1-Et yemeği");
        Console.WriteLine("2-Tavuk yemeği");
        Console.WriteLine("3-Mantı");
        Console.WriteLine("4-Pilav");

        int secim=Convert.ToInt32(Console.ReadLine());
        if (secim == 1)
        {
            hesap += 20;
            Console.WriteLine("Et hemeğiniz hazırlanıyor");
        }
        else if (secim == 2)
        {
            hesap += 10;
            Console.WriteLine("Tavuk yemeğiniz hazırlanıyor");
        }
        else if (secim == 3)
        {
            hesap += 10;
            Console.WriteLine("Mantınız hazırlanıyor");
        }
        else if (secim == 4)
        {
            hesap += 10;
            Console.WriteLine("Pilavınız hazırlanıyor");
        }
        else
        { 
            Console.WriteLine("hatalı seçim yaptınız");
        }
        
    }
 
    static void icecekler()
    {
            Console.WriteLine("İstediğiniz içeceğin numarasını giriniz: ");
            Console.WriteLine("1-Ayran");
            Console.WriteLine("2-Kola");
            Console.WriteLine("3-Fanta");
            Console.WriteLine("4-Gazoz");

        int secim2=Convert.ToInt32(Console.ReadLine());
        if (secim2 == 1)
        {
            hesap += 2;
            Console.WriteLine("Ayranınız hazırlanıyor");
        }
        else if (secim2 == 2)
        {
            hesap += 4;
            Console.WriteLine("Kolanız hazırlanıyor");
        }
        else if (secim2 == 3)
        {
            hesap += 4;
            Console.WriteLine("Fantanız hazırlanıyor");
        }
        else if(secim2 == 4){
            hesap += 4;
            Console.WriteLine("Gazozunuz hazırlanıyor");
         }
        else
        {
            Console.WriteLine("Hatalı seçim yaptınız");
        }
           
    }
    
    static void tatlilar()
    {
        Console.WriteLine("İstediğiniz tatlı numarasını giriniz:");
        Console.WriteLine("1-Sütlaç");
        Console.WriteLine("2-Keşkül");
        Console.WriteLine("3-Kazandibi");

        int secim3=Convert.ToInt32(Console.ReadLine());
        if (secim3 == 1)
        {
            hesap += 8;
            Console.WriteLine("Sütlaçınız hazırlanıyor");
        }
        else if (secim3 == 2)
        {
            hesap += 11;
            Console.WriteLine("Keşkülünüz hazırlanıyor");
        }
        else if (secim3 == 3)
        {
            hesap += 12;
            Console.WriteLine("Kazandibiniz hazırlanıyor");
        }
        else
        {
            Console.WriteLine("Hazalı seçim yaptınız");
        }
       
    }

    static void hesapodeme()
    {
        Console.WriteLine("Ödemeniz gereken tutar {0} TL",hesap);
    }
   

    public static void Main()
    {
        int secim;
        do
        {
            Console.WriteLine("*******Ana Menü*******");
            Console.WriteLine("1-yiyecekler");
            Console.WriteLine("2-İçecekler");
            Console.WriteLine("3-Tatılar");
            Console.WriteLine("4-Hesap ödeme");
            Console.Write("İşlem yapmak için bir numara giriniz: ");
            secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                yiyecek();
            }
            else if (secim == 2)
            {
                icecekler();
            }
            else if (secim == 3)
            {
                tatlilar();
            }
            else if (secim == 4)
            {
                hesapodeme();
            }
            else
            {
                break;
            }
            
        }
        while (secim != 4);
        }
    } */

