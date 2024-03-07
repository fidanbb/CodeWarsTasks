//Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

//Examples:

//solution('abc', 'bc') returns true
//solution('abc', 'd') returns false

#region solution-1
//static bool Solution(string str, string ending)
//{
//    if (str.Length >= ending.Length)
//    {
//        return str.Substring(str.Length - ending.Length, ending.Length) == ending;

//    }
//    return false;
//}

//Console.WriteLine(Solution("abc", "bc"));
//Console.WriteLine(Solution("abc", "d"));
//Console.WriteLine(Solution("abc", "abcd"));

#endregion

#region solution-2
//static bool Solution(string str, string ending)
//{
//    bool result = str.EndsWith(ending);
//    return result;
//}

//Console.WriteLine(Solution("abc", "bc"));
//Console.WriteLine(Solution("abc", "d"));
//Console.WriteLine(Solution("abc", "abcd"));

#endregion



