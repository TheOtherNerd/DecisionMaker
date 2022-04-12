public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter an integer between 1 and 100");
        string input = Console.ReadLine();
        float integer = float.Parse(input);

        if (integer < 1 || integer > 100)
        {
            Console.WriteLine($"{integer}. Outside the range asked for");
            
        }
        else if (integer % 2 == 0)
        {
            if (integer >= 2 && integer <= 24)
            {
                Console.WriteLine($"{integer}. Even and less than 25.");
            }
            else if (integer >= 26 && integer <= 60)
            {
                Console.WriteLine($"{integer}. Even and between 26 and 60 inclusive.");
            }
            else if (integer > 60)
            {
                Console.WriteLine($"{integer}. Even and greater than 60");
            }
        }
        else if (integer % 2 != 0)
        {
            if (integer < 60)
            {
                Console.WriteLine($"{integer}. Odd and less than 60.");
            }
            else
            {
                Console.WriteLine($"{integer}. Odd and greater than 60.");
            }
        }
        

        bool again = true;
        while (again == true)
        {
            Console.WriteLine("Would you like to replay? y/n");
            string yn = Console.ReadLine();
            switch (yn)
            {
                case "y":
                    Main();
                    break;

                case "n":
                    again = false;
                    break;

                default:
                    Console.WriteLine("I didnt understand that");
                    break;
            }
        }
    }
}
