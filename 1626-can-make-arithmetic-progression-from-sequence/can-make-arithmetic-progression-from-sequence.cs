public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        int sum=0;
        Array.Sort(arr);
        for(int i=arr.Length-1;i>1;i--){
           int a=Math.Abs(arr[i]-arr[i-1]);
           int b=Math.Abs(arr[i-1]-arr[i-2]);
            if(a==b){
                sum+=1;
            }

        }
        if(sum==arr.Length-2){
            return true;
        }
        return false;

    }
}