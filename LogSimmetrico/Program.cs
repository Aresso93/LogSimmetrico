namespace LogSimmetrico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddSpacesToLog();
        }

        private static int GetMaxLength(string input)
        {
            string[] strArray = input.Split(" ");
            for (int i = 0; i < strArray.Length; i++)
            {
                for (int j = i + 1; j < strArray.Length; j++)
                {
                    if (strArray[i].Length < strArray[j].Length)
                    {
                        string sortevole = strArray[j];
                        strArray[j] = strArray[i];
                        strArray[i] = sortevole;
                    }
                }
            }
            int maxLength = strArray[0].Length;
            return maxLength;
        }
        private static string StringManipulation(string stringToEnlarge, int numberOfBlankSpaces)
        {
            string blankSpace = " ";
            string spaces = "";
            for (int i = 0;i < (numberOfBlankSpaces - stringToEnlarge.Length)/2;i++)
            {
                spaces += blankSpace;
            }
            stringToEnlarge = spaces + stringToEnlarge + spaces;
            //Console.WriteLine(stringToEnlarge);
            return stringToEnlarge;
        }    
        private static void AddSpacesToLog()
        {
            Console.WriteLine("Dammi le stringhe, pls");
            string input = Console.ReadLine()!;
            string trimmedInput = input.Replace(" ", "");
            string[] strArray = trimmedInput.Split(" ");
            string leftBracket = "[";
            string rightBracket = "]";
            string blankSpace = " ";
            int longestLength = GetMaxLength(input);
            int lengthPlusBrackets = longestLength + 2;          
            for (int i = 0; i < strArray.Length; i++)
            {   
                if (strArray[i].Length % 2 != 0) { 
                    Console.WriteLine(leftBracket + StringManipulation(strArray[i], lengthPlusBrackets) + rightBracket);

                } else
                {
                    Console.WriteLine(leftBracket + blankSpace + StringManipulation(strArray[i], lengthPlusBrackets) + rightBracket);
                }
            }
        }
    }
}


//fagiolo Marco Pino aristotelico mamma Hitler PIN ma o