using Microsoft.VisualBasic;

//Write a function that takes in a string of one or more words, and returns the same string,
//but with all words that have five or more letters reversed (Just like the name of this Kata).
//Strings passed in will consist of only letters and spaces. Spaces will be included only
// when more than one word is present.

//Examples

//"Hey fellow warriors"-- > "Hey wollef sroirraw"
//"This is a test        --> "This is a test" 
//"This is another test"-- > "This is rehtona test"


#region solution 1
//static string SpinWords(string sentence)
//{
//    string[] words = sentence.Split(' ');
//    string newSentence = "";

//    for (int i = 0; i < words.Length; i++)
//    {
//        if (words[i].Length >= 5)
//        {
//            char[] wordsArray = words[i].ToCharArray();
//            Array.Reverse(wordsArray);
//            words[i] = new string(wordsArray);
//        }
//        newSentence += words[i];

//        if (i < words.Length - 1)
//        {
//            newSentence += " ";
//        }
//    }

//    return newSentence;

//}
//Console.WriteLine(SpinWords("Hey fellow warriors"));
//Console.WriteLine(SpinWords("This is a test"));
//Console.WriteLine(SpinWords("This is another test"));
#endregion

#region solution 2
static string SpinWords(string sentence)
{
    string[] words = sentence.Split(' ');
    return string.Join(" ", words.Select(word => word.Length >= 5 ? new string(word.Reverse().ToArray()) : word));


}
Console.WriteLine(SpinWords("Hey fellow warriors"));
Console.WriteLine(SpinWords("This is a test"));
Console.WriteLine(SpinWords("This is another test"));
#endregion





