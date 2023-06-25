using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarTekrar
{
    internal class MusteriManager
    {
        public void Add(Musteri musteri1,Musteri musteri2)
        {
            Console.WriteLine("Lütfen eklenecek kişiye ait bir Id numarası giriniz:");
            var IdInput = Console.ReadLine();
            int IdNumber = Convert.ToInt32(IdInput);
            if (IdNumber==musteri1.Id)
            {
                Console.WriteLine("{0} Id numaralı {1} kişisi listeye eklendi.\n",musteri1.Id,musteri1.Adi);
            }
            else if (IdNumber==musteri2.Id)
            {
                Console.WriteLine("{0} Id numaralı {1} kişisi listeye eklendi.",musteri2.Id,musteri2.Adi);
            }
            else
            {
                Console.WriteLine("{0} Id numarası sistemimimizde kayıtlı değil.",IdNumber);
            }
        }
        public void Listele(Musteri musteri1, Musteri musteri2)
        {

            Console.WriteLine("Lütfen bir Id numarası giriniz: ");
            var IdInput1 = Console.ReadLine();
            int IdNumber1 = Convert.ToInt32(IdInput1);

            Console.WriteLine("Lütfen bir Id numarası giriniz: ");
            var IdInput2 = Console.ReadLine();
            int IdNumber2 = Convert.ToInt32(IdInput2);

            Console.WriteLine("Müşterilerimiz Id numarasına göre sıralanmıştır:\n");

            if ((IdNumber1 == musteri1.Id && IdNumber1 > IdNumber2) || (IdNumber2==musteri1.Id && IdNumber2>IdNumber1))
            {
                
                Console.WriteLine(musteri1.Id+ " " +musteri1.Adi+ " " +musteri1.Soyadi);

                Console.WriteLine(musteri2.Id + " " + musteri2.Adi + " " + musteri2.Soyadi);
            }

            else if ((IdNumber1 == musteri2.Id && IdNumber1 > IdNumber2) || (IdNumber2 == musteri2.Id && IdNumber2 > IdNumber1))
            {
                Console.WriteLine(musteri2.Id + " " + musteri2.Adi + " " + musteri2.Soyadi);

                Console.WriteLine(musteri1.Id + " " + musteri1.Adi + " " + musteri1.Soyadi);
            }
            else
            {
                Console.WriteLine("Girdiğiniz ID numaralarını kontrol ediniz.");
            }

        }
        public void Remove(Musteri musteri1, Musteri musteri2)
        {
            Console.WriteLine("Lütfen kaldırmak istediğiniz şahsın Id numarasını giriniz:");
            var IdInput = Console.ReadLine();
            int IdNumber=Convert.ToInt32(IdInput);
            if (IdNumber==musteri1.Id)
            {
                Console.WriteLine("{0} Id numaralı {1} isimli müşterimiz listeden kaldırılmıştır. Yeni liste aşağıda verilmiştir.\n",musteri1.Id,musteri1.Adi);

                Console.WriteLine(musteri2.Id+" "+musteri2.Adi+" "+musteri2.Soyadi);
            }
            else if(IdNumber==musteri2.Id)
            {
                Console.WriteLine("{0} Id numaralı {1} isimli müşterimiz listeden kaldırılmıştır. Yeni liste aşağıda verilmiştir.\n",musteri2.Id,musteri2.Adi);
                Console.WriteLine(musteri1.Id + " " + musteri1.Adi + " " + musteri1.Soyadi);

            }
        }
    }
}
