namespace ConsoleApp4
{
    internal class MorseCodeTranslator
    {
        static Dictionary<char, string> morseAlphabetDictionary;

        public static void MorseCodeTranslatorFunc(string[] args)
        {
            InitializeDictionary();

            Console.Write("Enter text to convert to Morse code: ");
            string input = Console.ReadLine().ToUpper();

            string morseCode = TranslateToMorseCode(input);
            Console.WriteLine($"Morse code: {morseCode}");
        }

        static void InitializeDictionary()
        {
            morseAlphabetDictionary = new Dictionary<char, string>()
            {
                { 'A', ".-" },
                { 'B', "-..." },
                { 'C', "-.-." },
                { 'D', "-.." },
                { 'E', "." },
                { 'F', "..-." },
                { 'G', "--." },
                { 'H', "...." },
                { 'I', ".." },
                { 'J', ".---" },
                { 'K', "-.-" },
                { 'L', ".-.." },
                { 'M', "--" },
                { 'N', "-." },
                { 'O', "---" },
                { 'P', ".--." },
                { 'Q', "--.-" },
                { 'R', ".-." },
                { 'S', "..." },
                { 'T', "-" },
                { 'U', "..-" },
                { 'V', "...-" },
                { 'W', ".--" },
                { 'X', "-..-" },
                { 'Y', "-.--" },
                { 'Z', "--.." },
                { '0', "-----" },
                { '1', ".----" },
                { '2', "..---" },
                { '3', "...--" },
                { '4', "....-" },
                { '5', "....." },
                { '6', "-...." },
                { '7', "--..." },
                { '8', "---.." },
                { '9', "----." },
                { ' ', "/" }
            };
        }

        static string TranslateToMorseCode(string input)
        {
            List<string> morseCode = new List<string>(input.Length);

            foreach (char character in input)
            {
                if (morseAlphabetDictionary.TryGetValue(character, out string morseCharacter))
                {
                    morseCode.Add(morseCharacter);
                }
                else
                {
                    Console.WriteLine($"Warning: Character '{character}' is not supported and will be skipped.");
                }
            }

            return string.Join(" ", morseCode);
        }
    }
}
