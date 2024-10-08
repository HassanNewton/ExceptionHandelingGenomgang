namespace ExceptionHandeling
{
    internal class Main2
    {
        static void Main(string[] args)
        {
            StreamReader reader = null;

            try
            {
                reader = new StreamReader("C:\\Users\\Ettan.malmo\\source\\repos\\ExceptionHandeling\\ExceptionHandeling\\TextFile1.txt");
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Filen hittas ej, kolla pathen");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }



        }
    }
}
