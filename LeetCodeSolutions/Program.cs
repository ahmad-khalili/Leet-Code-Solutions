namespace LeetCodeSolutions;
public class Program
{
    public int Maximum69Number (int num)
    {
        if (num == 9999) return num;
        var charArray = num.ToString().ToCharArray();
        for(int i = 0;i<charArray.Length;i++){
            if (charArray[i].Equals('6')){
                charArray[i] = '9';
                break;
            }
        }
        return Int32.Parse(charArray);
    }
    public static void Main()
    {
        Program program = new Program();
        var testInt = 9999;
        Console.WriteLine(program.Maximum69Number(testInt));
    }
}