using System;

public class Kata
{
    public static string AreYouPlayingBanjo(string name)
    {
        //Implement me
        if (!string.IsNullOrEmpty(name) && (name[0] == 'R' || name[0] == 'r'))
        {
            return $"{name} plays banjo";
        }
        else
        {
            return $"{name} does not play banjo";
        }
    }

    public static void Main()
    {
        Console.WriteLine(AreYouPlayingBanjo("Martin"));
        Console.WriteLine(AreYouPlayingBanjo("Rikke"));
        Console.WriteLine(AreYouPlayingBanjo("bravo"));
        Console.WriteLine(AreYouPlayingBanjo("rolf"));
    }


}