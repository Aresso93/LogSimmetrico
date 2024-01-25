namespace LogSimmetrico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] logWords = {"fagiolo", "Marco", "Pino", "aristotelico", "mamma", "Hitler", "PIN", "ma", "o"};
            //for (int i = 0; i < logWords.Length; i++)
            //{
            //    Console.WriteLine("[" + "***" + logWords[i] + "***" + "]");

            //}
            StringManipulation();
        }

        static string[] StringManipulation()
        {
            Console.WriteLine("Dammi le strnghe, pls");
            string input = Console.ReadLine()!;
            string[] strArray = input.Split(' ');
            //int longestLength = strArray.Max(str => str.Length);
            //Console.WriteLine(longestLength);
            for (int i = 0; i<strArray.Length; i++) {
                Console.WriteLine(strArray[i]);
            }
            return strArray;
        }
    }
}

//fagiolo Marco Pino aristotelico mamma Hitler PIN ma o
