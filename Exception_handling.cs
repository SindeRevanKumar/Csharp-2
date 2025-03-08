namespace excep
{
    public class program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            try
            {
                checked
                { 
                    
                int result = 2147483647 + n;
                Console.WriteLine(result);
                }
            }
            catch(System.IO.IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
