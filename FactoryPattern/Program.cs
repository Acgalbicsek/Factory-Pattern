namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of fruit is on your tree?  Apple or Orange?");

            var userInput = Console.ReadLine().ToLower();

            var instance = GreenHouse.GetTree(userInput);

            instance.Type();


        }
    }
}
