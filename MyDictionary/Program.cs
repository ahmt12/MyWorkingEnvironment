namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MyDictionary<string> person = new MyDictionary<string>();

            string Name1 = "Ahmet";
            string Name2 = "Aslan";

            person.Add(Name1);
            person.Add(Name2);

        }
    }
}