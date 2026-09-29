public class Solution {
     public int FindMaxConsecutiveOnes(int[] input)
{
int repeats = 0;
int maxrepetition = 0;
int cnt = input.Count();
for (int i = 0; i < input.Count(); i++)
{
	for (int j = i; j < input.Count(); j++)
	{
		if (input[i] == input[j])
		{
			if (input[i] == 0 )
			{
				break;
			}
			repeats++;
			if (maxrepetition<repeats)
			{
				maxrepetition = repeats;
				
			}
		}
        else
		{
            repeats = 0;
			i = j;
			break;
        }
		if (j == (input.Count()-1))	
		{
            return maxrepetition;
        }
    }
	
}

return maxrepetition;	
}
}