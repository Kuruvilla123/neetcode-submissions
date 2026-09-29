public class Solution {
      public bool hasDuplicate(int[] nums)
{
   int count = 0;
for (int i = 0; i < nums.Count(); i++)
{
    for (int j = i+1; j < nums.Count(); j++)
    {
        if (nums[i] == nums[j])
        {
            count++;
        }
    }
}
return count > 0 ? true : false; 
}
}