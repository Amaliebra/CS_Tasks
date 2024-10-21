namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Greeting class
        Greetings greetings = new Greetings();
        // English greeting
        greetings.SayHello();
        // Japanese greeting
        greetings.YoiTsuitachi();

        Fundament fundament = new Fundament();

        fundament.SumTwoNumbers(5, 10);

        Console.WriteLine("Type anything to subscribe to random facts");
        string uselessKeyword = Console.ReadLine();
        string fact = fundament.GetAInterestingFact(uselessKeyword);
        Console.WriteLine("Intresting fact: " + fact);

    }
}
