public class Program
{
    private static void Main(string[] args)
    {
        Cusing System.Linq.Expressions;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Print the rectangle.");
        Console.WriteLine("2. Print the square triangle (top-left).");
        Console.WriteLine("3. Print the square triangle (top-right).");
        Console.WriteLine("4. Print the square triangle (bottom-left).");
        Console.WriteLine("5. Print the square triangle (bottom-right).");
        Console.WriteLine("6. Print isosceles triangle.");
        Console.WriteLine("7. Exit.");
        Console.Write("Input your choice: ");
        float number = Convert.ToSingle(Console.ReadLine());

        //Rectangle.
        if (number == 1)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("* * * * * * *");
            }
        }

        //square triangle (top-left)
        else if (number == 2)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }

        // square triangle (top-right)
        else if (number == 3)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int space = 1; space < i; space++)
                {
                    Console.Write("  ");
                }
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        //square triangle (bottom-left)
        else if (number == 4)
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        //square triangle (bottom-right)
        else if (number == 5)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int space = 5; space > i; space--)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        //isosceles triangle
        else if (number == 6)
        {
            for (int i = 1; i < 5; i++)
            {
                for (int space = 1; space <= 5 - i; space++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= (2 * i) - 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        //Exit
        else if (number == 7)
        {
            return;
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}
    }
}