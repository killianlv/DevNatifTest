namespace ex2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Entrez un texte a mettre en majuscules :");
            string input = Console.ReadLine();
            Console.WriteLine(ConvertToUpper(input));
        }

        public static string ConvertToUpper(string text)
        {
            return text.ToUpper();
        }
    }
}