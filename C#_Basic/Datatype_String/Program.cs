namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Cholong";
            string message = "My name is " + myName;

            string capsMessage = message.ToUpper();

            string lowerMessage = message.ToLower();
            
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerMessage);

        }
    }
}