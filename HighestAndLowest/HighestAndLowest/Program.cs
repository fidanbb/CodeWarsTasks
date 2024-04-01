

//In this little assignment you are given a string of space separated 
//    numbers, and have to return the highest and lowest number.

//Examples

//Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
//Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
//Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"


//Notes
//All numbers are valid Int32, no need to validate them.
//There will always be at least one number in the input string.
//Output string must be two numbers separated by a single space, and highest number is first.


 static string HighAndLow(string numbers)
{
    #region 1st way
    //string[] numbersArr= numbers.Split(" ");

    //int max = Int32.Parse(numbersArr[0]);

    //int min = Int32.Parse(numbersArr[0]);

    //foreach (var elem in numbersArr)
    //{


    //        if (Int32.Parse(elem) > max)
    //        {
    //            max = Int32.Parse(elem);
    //        }

    //        if (Int32.Parse(elem) < min)
    //        {
    //            min = Int32.Parse(elem);
    //        }


    //}


    //return $"{max.ToString()} {min.ToString()}";
    #endregion


    #region 2nd way

    var arr = numbers.Split(" ").Select(int.Parse);

    //var arr = numbers.Split(" ").Select(m=> Convert.ToInt32(m));

    return string.Format("{0} {1}",arr.Max(),arr.Min());

    #endregion


}


Console.WriteLine(HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));

Console.WriteLine(HighAndLow("1 2 3"));
Console.WriteLine(HighAndLow("-1 -1"));