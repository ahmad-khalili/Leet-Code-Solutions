namespace LeetCodeSolutions;
public class Program
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] outcome = new int[2];
        
        for(int i = 0; i < nums.Length; i++)
        {
            int currentNum = nums[i];
            for(int j = 1; j < nums.Length; j++)
            {
                if (nums[j] == target - currentNum)
                {
                    outcome[0] = i;
                    outcome[1] = j;
                }
            }
        }
        return outcome;
    }

    public static void Main()
    {
        Program program = new Program();
        int[] testArray = new[] { 2, 7, 11, 15 };
        int[] outcomeArray = new int[2];
        outcomeArray = program.TwoSum(testArray, 9);
        Console.WriteLine($"[{outcomeArray[0]}, {outcomeArray[1]}]");
    }
}