namespace smallest_element
{
    public class program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int length = numbers.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Enter the number {i} : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int min = numbers[0];
            for (int i = 1; i < length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("The smallest number is : " + min);
        }
    }
}
