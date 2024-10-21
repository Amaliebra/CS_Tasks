public class Fundament : IFundament
{
    public void CheckOddOrEven(double a)
    {
        string result = Math.Round(a) % 2 == 0
        ? "even"
        : Math.Round(a) % 2 == 1 || Math.Round(a) % 2 == -1
        ? "odd"
        : "invalid";
    }

    public string GetAInterestingFact(string fact)
    {
        string[] intrestingFacts = {
            "You can hear a blue whale's heartbeat from over 3 kilometers away.",
            "The world's smallest bird is the bee hummingbird, which is the size of a bumblebee.",
            "Sharks existed before trees.",
            "Cleopatra lived closer to the invention of the iPhone than to the building of the pyramids.",
            "In 1992, a cargo ship lost 28,000 rubber ducks in the ocean, and they're still being found today.",
            "The average person takes about 23,000 breaths per day."
        };

        Random random = new Random();
        int randomIndex = random.Next(intrestingFacts.Length);
        return intrestingFacts[randomIndex];
    }

    public void SumTwoNumbers(int num1, int num2)
    {
        int sum = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {sum}");
    }

    public double SumTwoNumbersOfGivenType(double a, double b)
    {
        return a + b;
    }


    // Extra challenges

    public void PrintFibonnaciSeries()
    {
        // TODO: Implement the Fibonacci sequence
        // int a = 0;
        // int b = 1;
        // int c;

        /* 
        c = a + b
        a = b
        b = c
        */
    }

    public string ReverseString(string str)
    {
        // TODO: reverse the given string
        return "";
    }

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        if (n == 0)
        {
            return 1;
        }
        return n;
    }


}
