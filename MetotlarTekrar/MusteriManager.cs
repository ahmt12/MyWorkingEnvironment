using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarTekrar
{
    internal class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            //
            //
            //
            Console.WriteLine("{0} Id numaralı {1} kişisi listeye eklendi.",musteri.Id,musteri.Adi);
        }


        public void Listele(Musteri musteri1, Musteri musteri2)
        {

            Console.WriteLine("Lütfen bir Id numarası giriniz: ");
            string IdInput1 = Console.ReadLine();
            int IdNumber1 = Convert.ToInt32(IdInput1);

            Console.WriteLine("Lütfen bir Id numarası giriniz: ");
            string IdInput2 = Console.ReadLine();
            int IdNumber2 = Convert.ToInt32(IdInput2);

            if ((IdNumber1 == musteri1.Id && IdNumber1 > IdNumber2) || (IdNumber2==musteri1.Id && IdNumber2>IdNumber1))
            {
                Console.WriteLine(musteri1.Id+ " " +musteri1.Adi+ " " +musteri1.Soyadi);
                Console.WriteLine(musteri2.Id + " " + musteri2.Adi + " " + musteri2.Soyadi);
            }

            if ((IdNumber1 == musteri2.Id && IdNumber1 > IdNumber2) || (IdNumber2 == musteri2.Id && IdNumber2 > IdNumber1))
            {
                Console.WriteLine(musteri2.Id + " " + musteri2.Adi + " " + musteri2.Soyadi);
                Console.WriteLine(musteri1.Id + " " + musteri1.Adi + " " + musteri1.Soyadi);
            }








        }
        public void Remove()
        {



        }

    }
}
