namespace LeetCodeSolutions;
public class Program
{
    public bool IsValid(string s) {
        Stack<char> strStack = new Stack<char>();
        Dictionary<char, char> parentheses = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };
        foreach(var p in s){
            if (parentheses.ContainsKey(p)) strStack.Push(p);
            if (p.Equals(')') || p.Equals('}') || p.Equals(']')){
                if (strStack.Count > 0){
                    char top = strStack.Peek();
                    if(p.Equals(parentheses[top])){
                        strStack.Pop();
                    }
                    else return false;
                }
                else return false;
            }
        }
        if (strStack.Count == 0) return true;
        
        return false;
    }
    public static void Main()
    {
        Program program = new Program();
        var testParentheses = "()[]{}";
        Console.WriteLine(program.IsValid(testParentheses));
    }
}