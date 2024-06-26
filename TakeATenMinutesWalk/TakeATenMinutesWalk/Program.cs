﻿
//You live in the city of Cartesia where all roads are laid out in a perfect grid. 
//    You arrived ten minutes too early to an appointment, so you decided to take 
//    the opportunity to go for a short walk. The city provides its citizens with a
//    Walk Generating App on their phones -- everytime you press the button 
//    it sends you an array of one-letter strings representing directions to 
//    walk (eg. ['n', 's', 'w', 'e']). You always walk only a single block 
//    for each letter (direction) and you know it takes you one minute to 
//    traverse one city block, so create a function that will return true if 
//    the walk the app gives you will take you exactly ten minutes (you don't 
//    want to be early or late!) and will, of course, return you to your 
//    starting point. Return false otherwise.

//Note: you will always receive a valid array containing a random assortment of 
//    direction letters ('n', 's', 'e', or 'w' only). It will never give you an 
//    empty array (that's not a walk, that's standing still!).

 static bool IsValidWalk(string[] walk)
{
    #region 1st way
    //int ew = 0;

    //if (walk.Length != 10)
    //{
    //	return false;
    //}

    //   foreach (var item in walk)
    //   {
    //       if (item == "n")
    //       {
    //           ns++;
    //       }

    //       if (item == "s")
    //       {
    //           ns--;
    //       }

    //       if (item == "e")
    //       {
    //           ew++;
    //       }

    //       if (item == "w")
    //       {
    //           ew--;
    //       }
    //   }

    //   return ns==0 && ew == 0;
    #endregion



    #region 2nd way
    return walk.Count() == 10 &&
        walk.Count(n => n == "n") == walk.Count(s => s == "s") &&
        walk.Count(e => e == "e") == walk.Count(w => w == "w");
    #endregion


}

Console.WriteLine(IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }) );
Console.WriteLine(IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }));
Console.WriteLine(IsValidWalk(new string[] { "w" }));
Console.WriteLine(IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }));
Console.WriteLine(IsValidWalk(new string[] { "e", "w", "e", "w", "e", "w", "e", "w", "e", "w" }));
Console.WriteLine(IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }));
