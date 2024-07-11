public class Solution {
    public bool IsMonotonic(int[] nums) {
        
        if(nums[0]>nums[nums.Length-1]){
            for(int i=nums.Length;i>1;i--){
                if(nums[i-1]>nums[i-2]){
                    return false;
                }
            }
        
        }
        else if(nums[0]<nums[nums.Length-1]){
             for(int i=nums.Length;i>1;i--){
                if(nums[i-1]<nums[i-2]){
                    return false;
                }
            }
        }
        else if(nums[0]==nums[nums.Length-1]){
             for(int i=nums.Length;i>1;i--){
                if(nums[i-1]!=nums[i-2]){
                    return false;
                }
            }
        }
        return true;
    }
}