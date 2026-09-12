namespace Algorithms_Easy;

public class TwoSum
{
    public int[] TwoSumFind(int[] nums, int target) {
        Dictionary<int, int> ht = new Dictionary<int, int>();
        
        int tmp = 0;
        int rest = 0;
        int[] res = new int[2];

        for (int i = 0; i < nums.Length; i++) {
            tmp = nums[i];
            rest = target - tmp;
            
            if (ht.ContainsKey(rest)) {
                res[0] = i;
                res[1] = ht[rest];
                return res;
            }
            
            ht[tmp] = i;
        }
        
        return new int[0];
    }
}