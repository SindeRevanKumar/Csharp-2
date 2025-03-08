namespace M1Preparation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to check the given number is palindrome");
            string word = Console.ReadLine().ToLower();

            ReverseString reverseString = new ReverseString();

            if (reverseString.IsPalindrome(word))
            {
                Console.WriteLine("The given word is palindrome");
            }
            else
            {
                Console.WriteLine("The given word is not palindrome");
            }
        
