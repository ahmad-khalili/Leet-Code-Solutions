namespace LeetCodeSolutions;
public class Program
{
    public IList<int> FindDuplicates(int[] nums) {
        HashSet<int> numSet = new HashSet<int>();
        List<int> dupList = new List<int>();
        foreach(var num in nums){
            if(!(numSet.Add(num))){
                dupList.Add(num);
            }
        }
        return dupList;
    }
    public static void Main()
    {
        Program program = new Program();
        var testNumbers = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
        var duplicateList = program.FindDuplicates(testNumbers);
        foreach (var number in duplicateList)
        {
            Console.WriteLine(number);
        }
    }
}