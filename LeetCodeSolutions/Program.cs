namespace LeetCodeSolutions;
public class Program
{
    private readonly Dictionary<string, int> _romanLetters = new Dictionary<string, int>()
    {
        {"I", 1},
        {"V", 5},
        {"X", 10},
        {"L", 50},
        {"C", 100},
        {"D", 500},
        {"M", 1000}
    };
    public int toRoman(char letter)
    {
        switch (letter)
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
            default:
                return 0;
        }
    }
    
    public int RomanToInt(string str)
    {
        int result = 0;
        
        foreach (var letter in str)
        {
            result += toRoman(letter);
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