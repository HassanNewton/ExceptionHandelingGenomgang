namespace ExceptionHandeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ange ett tal");
                int nbr1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ange ett tal");
                int nbr2 = Convert.ToInt32(Console.ReadLine());

                int result = nbr1 / nbr2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Du har försökt dividera med noll som inte är okej");
                Console.WriteLine(ex.Message);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Mata in ett heltal och inget annat");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
