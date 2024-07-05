public class Solution {
    public int ArraySign(int[] nums) {
        int product=1;
        for(int i=0;i<nums.Length;i++){
            product*=nums[i];
            product=signFunc(product);
        }
        return signFunc(product);
    }
    public int signFunc(int x){
        if(x>0){
            return 1;
        }
        else if(x<0){
            return -1;
        }
        else return 0;
    }
}