namespace MetotlarTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Aslan";

            Musteri musteri2 = new Musteri();

            musteri2.Id = 2;
            musteri2.Adi = "Muhammed";
            musteri2.Soyadi = "Aslan";

            MusteriManager.Listele(musteri1,musteri2);
            
        }
    }
}