using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230826_Enum
{
    enum HaftaninGunleri
    {
        Pazartesi=1,Sali,Carsamba,Persembe,Cuma,Cumartesi,Pazar
    }
    enum Departmanlar
    {
        SatisPersoneli=56,
        InsanKaynaklari=15,
        PazarlamaMuduru=80,
        ITPersoneli=10

    }
    internal class Program
    {

        static void Main(string[] args)
        {

            //Enum
            //String ifadelerle sayısal karşılaştırma ya da farklı işlemlerin gerektiği durumlarda yazılımcılar için dah ada okunabilirlik sağlayan ve gelecekte anlaşılması zorlaştırılan kod karmaşasıını azaltmayı sağlayan yardımcı bir kod yapısıdır
            //Enum içerisindeki ifadelerin herhangi bir türü yoktur
            //İfadeler değişken tanımlama kurallarına bağlı kalınarak tanımlanmalıdır
            //İfadeler aralarına virgül eklenerek tanımlanır
            //Enum içerisinde bulunan ifadelerin sayısal değerleri vardır
            //İlk değer default olarak 0(sıfır ) olarak tanımlanır
            //İstersek manuel olarak değer tanımlaması da yapabiliriz

            //1.Örnek
            //HaftaninGunleri bugun=HaftaninGunleri.Pazartesi;
            // Console.WriteLine("Bugün günlerden : "+bugun);

            //2.Örnek
            Console.Write("Departman Numarasını Giriniz");
            int departmanNo=int.Parse(Console.ReadLine());
            switch (departmanNo)
            {
                case (int)Departmanlar.SatisPersoneli:
                    Console.WriteLine("Satış Birimine Hoşgeldiniz");
                    break;
                case (int)Departmanlar.InsanKaynaklari:
                    Console.WriteLine("İnsan Kaynaklarına Hoşgeldiniz");
                    break;
                case (int)Departmanlar.PazarlamaMuduru:
                    Console.WriteLine("Pazarlama Departmanına Hoşgeldiniz");
                    break;
                case (int)Departmanlar.ITPersoneli:
                    Console.WriteLine(Departmanlar.ITPersoneli.ToString());
                    break;
                default:
                    Console.WriteLine("Kayıtlı departman numarası bulunamadı danımşaya yönlendiriliyorsunuz");
                    break;
            }

            Console.ReadKey();
        }
    }
    
}
