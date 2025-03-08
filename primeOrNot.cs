namespace Prime_number
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to check : ");
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            if (number == 0 || number == 1)
            {
                Console.WriteLine($"{number} Not a prime nor composite...");
            }
            else if (number == 2 || number == 3)
            {
                Console.WriteLine($"{number} is a prime....");
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        count += 1;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"{number} is a prime number");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number");
            }
        }
    }
}
