namespace ConvertToRomanNumerals;

public static class ToRomanNumerals
{
    public static void Main()
    {
        var input = 505;
        var romanNumerals = ConvertNumbersRomanNumerals(input);
        Console.WriteLine($"{input} = {romanNumerals}");
    }

    public static string ConvertNumbersRomanNumerals(int number)
    {
        string romanNumerals = "";
        Dictionary<string, int> romanNumeralsDictionary = new() {
            { "M", 1000 },
            { "CM", 900 },
            { "D", 500 },
            { "CD", 400 },
            { "C", 100 },
            { "XC", 90 },
            { "L", 50 },
            { "XL", 40 },
            { "X", 10 },
            { "IX", 9 },
            { "V", 5 },
            { "IV", 4 },
            { "I", 1 }
        };
        foreach (var item in romanNumeralsDictionary.TakeWhile(item => number > 0))
        {
            while (number >= item.Value)
            {
                romanNumerals += item.Key;
                number -= item.Value;
            }
        }
        return romanNumerals;
    }
}