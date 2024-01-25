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
            string leftBracket = "[";
            string rightBracket = "]";
            //string blankSpace = " ";
            int longestLength = strArray.Max(str => str.Length);
            int lengthPlusBrackets = longestLength + 2;
            //Console.WriteLine(longestLength);
            for (int i = 0; i<strArray.Length; i++) {
                string spaces = new String(' ', (lengthPlusBrackets - strArray[i].Length) /2);
                Console.WriteLine(leftBracket + spaces + strArray[i] + spaces + rightBracket);
                
            }
            
            return strArray;
        }
    }
}

//fagiolo Marco Pino aristotelico mamma Hitler PIN ma o
