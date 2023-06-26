namespace MyGroupWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Üç ürüne ait ürün kodu, fiyatı, stoktaki ürün adedi bilgileri girilecek. 

            /*Mağazada kargonun ücretsiz olması için minimum 400 liralık ürün eklenmeli. Eğer müşterinin eklediği ürün 400tl altında ise
            ekranda ücretsiz kargo için kalan fiyat yazacak. Nüşteri bu fiyatı onaylamak istiyorsa son olarak ekranda çıkacak olan 
            toplam ödenmesi gereken ücret kısmında +30tl daha eklenecek. */

            // Eğer 400tl üstü ise ekranda tebrikler kargonuz ücretsiz yazacak.

           // Müşteri bir ürünü satın aldığında kalan stok adedi her bir ürün için tekrardan yazdırılacak.



            Product product1 = new Product();
            product1.Name = "Computer";kk
            product1.Code = 10;
            product1.Price = 250;
            product1.Stocks = 5;
            
            Product product2 = new Product();
            product2.Name = "TV";
            product2.Code = 11;
            product2.Price = 200;
            product2.Stocks = 4;

            Product product3 = new Product();
            product3.Name = "Phone";
            product3.Code = 12;
            product3.Price = 100;
            product3.Stocks = 1;


            ProductManager productManager = new ProductManager();
            productManager.Add(product1,product2,product3);

            
            
        }
    }
}