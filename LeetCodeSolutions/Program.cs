namespace LeetCodeSolutions;
public class Program
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] outcome = new int[2];
        var passedElements = new Dictionary<int, int>();

        for(var i = 0;i < nums.Length;i++)
        {
            var neededNumber = target - nums[i];
            if (passedElements.ContainsKey(neededNumber))
            {
                outcome[0] = passedElements[neededNumber];
                outcome[1] = i;
            }
            else passedElements[nums[i]] = i;
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