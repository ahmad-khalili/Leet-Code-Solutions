namespace LeetCodeSolutions;
public class Program
{
    private readonly Dictionary<char, int> _romanLetters = new()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public int ToRoman(char letter)
    {
        if (!_romanLetters.ContainsKey(letter))
            return 0;
        
        return _romanLetters[letter];
    }

    public int RomanToInt(string str)
    {
        int result = 0;
        
        foreach (var letter in str)
        {
            result += ToRoman(letter);
        }

        if (str.Contains("IV") || str.Contains("IX"))
        {
            result -= 2;
        }

        if (str.Contains("XL") || str.Contains("XC"))
        {
            result -= 20;
        }

        if (str.Contains("CD") || str.Contains("CM"))
        {
            result -= 200;
        }

        return result;
    }

    public static void Main()
    {
        Program program = new Program();
        Console.WriteLine(program.RomanToInt("MCMXCIV"));
    }
}