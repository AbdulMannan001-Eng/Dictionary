// See https://aka.ms/new-console-template for more information
 class Dictionary
{

 
    static void Main()
    {
        var wordDictionary = new Dictionary<char, string>();
        wordDictionary.Add('A', "Ant");
        wordDictionary.Add('B', "Bat");
        wordDictionary.Add('C', "Cat");
        wordDictionary.Add('D', "Dog");
        wordDictionary.Add('E', "Egg");
        wordDictionary.Add('F', "Fan");
        wordDictionary.Add('G', "Goat");
        wordDictionary.Add('H', "Hen");
        wordDictionary.Add('I', "Ice");
        wordDictionary.Add('J', "Jug");
        wordDictionary.Add('K', "Kettle");
        wordDictionary.Add('L', "Leg");
        wordDictionary.Add('M', "Money");
        wordDictionary.Add('N', "Nut");
        wordDictionary.Add('O', "Orange");
        wordDictionary.Add('P', "Pot");
        wordDictionary.Add('Q', "Queen");
        wordDictionary.Add('R', "Rat");
        wordDictionary.Add('S', "Snake");
        wordDictionary.Add('T', "Turkey");
        wordDictionary.Add('U', "Umbrella");
        wordDictionary.Add('V', "Violin");
        wordDictionary.Add('W', "Water");
        wordDictionary.Add('X', "Xylophone");
        wordDictionary.Add('Y', "Yam");
        wordDictionary.Add('Z', "Zenith");
        Console.WriteLine("Alphabet\nWord");
        
        foreach (var pair in wordDictionary)
        {
            Console.WriteLine($"{pair.Key} for {pair.Value}");
        }
    }
}