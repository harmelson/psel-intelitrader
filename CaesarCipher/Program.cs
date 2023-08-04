namespace CaesarCipher
{
    class Program
    {
        static void Main()
        {
            HelloWorld helloWorld = new HelloWorld();
            string message = helloWorld.GetHelloWorld();
            Console.WriteLine(message);
        }
    }

    public class HelloWorld
    {
        public string GetHelloWorld()
        {
            return "Hello World!";
        }
    }
}