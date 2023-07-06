namespace List
{
    
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> names = new List<string> {"Ahmet","Hakan","Murat"};
            names.Add("Kerem");
            Console.WriteLine(names[3]);

            
        }
        
    }
}