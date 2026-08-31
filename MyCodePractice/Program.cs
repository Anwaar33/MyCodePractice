namespace MyCodePractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            CodeClass codeClass = new CodeClass();
            newCodeFile newCodeFile = new newCodeFile();

            Program program = new Program();

            newCodeFile.printTrianle();
        }

        // Recursive with base case and negative check
        public static int Factorial(int factNum)
        {
            if (factNum <= 1) return 1;
            return factNum * Factorial(factNum - 1);
        }
    }
}
