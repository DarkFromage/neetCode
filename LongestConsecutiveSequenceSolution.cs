namespace neetCode
{
    internal class LongestConsecutiveSequenceSolution
    {

        public int LongestConsecutiveSequence(int[] nums)
        {
            //    for (int i = 0; i < nums.Length - 1; i++)
            //    {
            //        for(int j = i+1; j < nums.Length; j++)
            //        {
            //            if (nums[i] <= nums[j]) continue;
            //            else
            //            {
            //                var _temp = nums[i];
            //                nums[i] = nums[j];
            //                nums[j] = _temp;
            //            }
            //        }
            //    }
            //    int consecutive = 0;
            //    int bestScore = 0;

            //    for(int i = 0; i < nums.Length; i++)
            //    {
            //        if(consecutive == 0)
            //        {
            //            consecutive++;
            //            continue;
            //        }
            //        if(nums[i] == nums[i - 1]) continue;

            //        if (nums[i] == nums[i - 1] + 1)
            //        {
            //            consecutive++;
            //        }
            //        else
            //        { 
            //            if(consecutive > bestScore) bestScore = consecutive;
            //            consecutive = 1;
            //        }
            //    }
            //    if (consecutive >  bestScore) bestScore= consecutive;
            //    return bestScore;
            //
            HashSet<int> numsCollection = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                numsCollection.Add(nums[i]);
            }
            int bestScore = 0;
            foreach (int i in numsCollection)
            {
                if (numsCollection.Contains(i - 1)) continue;

                int consecutive = 1;
                
                int n = 1;
                while (numsCollection.Contains(i + n))
                {
                    consecutive++;
                    n++;
                }
                if (consecutive > bestScore) bestScore = consecutive;
            }
            return bestScore;
        }
    }
}
