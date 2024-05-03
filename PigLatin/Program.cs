
bool runProgram = true; 
//welcome
Console.WriteLine("Welcome to the Pig Latin Translator!");
//programloop

while(runProgram)
{
    //getUserInput
Console.Write("Please enter a line to be translated: ");
string word = Console.ReadLine();
    
    
    //validation
    if (word.StartsWith(" ") || word == "")
    {
        Console.WriteLine("Invalid input");
        continue;
    }
   
        //sentence
        string[] sentence = word.Split(' ');
        foreach (string s in sentence)

        {
        //methodcalls
        if (containSymbols(s))
            {
                Console.WriteLine(s);
            }

            else if (StartsWithVowel(s))
            {
                Console.Write($"{s}way ");
            } else

            {
                Console.Write(StartsWithC(s));
        }
        }
    
    
    //exitloop
    while(true)
    {
        Console.WriteLine("\tWould you like to translate another word? Please say yes, I worked so long on this. y/n");
        string youSaidYes = Console.ReadLine().ToLower().Trim();
        if (youSaidYes == "y")
        {
            Console.WriteLine("YEEEEEE, here we go again");
            break;
        } else if (youSaidYes == "n")
        {
            Console.WriteLine("you are breaking my heart");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}






//methods

//startwithvowel+way
static bool StartsWithVowel(string vowel1)
{

    string firstLetter = vowel1.Substring(0, 1);
    return "AEIOUaeiou".Contains(firstLetter);
}
 
//startswithconsanants+ay
static string StartsWithC(string vowel2)
{
   
    for (int i = 0; i < vowel2.Length; i++)
    {
        string vowelStart = vowel2.Substring(i, 1);
        if ("AEIOUaeiou".Contains(vowelStart))
        {
            return $"{vowel2.Substring(i)}{vowel2.Substring(0, i)}ay "; 
        }
    }
    
    return $"{vowel2}";
    
}
    


//containssymbolreturnwithsymbol 
static bool containSymbols(string symb)
{
    int i = 0;
    while (i < symb.Length)
    {
        string symbol = symb.Substring(i, 1);
        i++;
        if ("123457890@#$%^&*()_+".Contains(symbol))
        {

            return true;
        }

    }
    return false;

}








