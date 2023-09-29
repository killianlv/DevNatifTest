namespace ex4
{
    public class Program
    {
        static List<char> alphabet = new List<char>
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m',
            'n','o','p','q','r','s','t','u','v','w','x','y','z'
        };

        public static void Main()
        {
            AlgoTest(MyNameIs);
            Console.ReadLine();
        }

        public static string MyNameIs(string name)
        {
            return string.Join("", name.ToLower().Select(_ => alphabet.IndexOf(_)));
        }

        public static void AlgoTest(Func<string, string> func)
        {
            if (func("AB") == "01")
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}