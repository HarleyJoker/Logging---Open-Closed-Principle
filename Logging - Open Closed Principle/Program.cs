using Logging___Open_Closed_Principle;

class Program
{
    static void Main(string[] args)
    {
        //var logger = new Logger();
        //logger.Log("Hello World", LoggerType.Console);


        ILogger logger = new ConsoleLogger();
        logger.Log("Hello World");

        // Switching to a file logger doesn't require any changes to the existing code
        logger = new FileLogger();
        logger.Log("Hello File");

    }
}