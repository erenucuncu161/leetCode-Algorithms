public class Solution {
    public void MoveZeroes(int[] nums) {
        int[] dizi= new int[nums.Length];
     int sayac = 0;
     for (int i = 0; i < nums.Length; i++)
     {
         if (nums[i] != 0)
         {   
             
             dizi[sayac]= nums[i];
             sayac++;
         }
         
     }
     int a = nums.Length - sayac;
     for (int i = 0; i < a; i++)
     {
         dizi[sayac] = 0;
         sayac++;
     }
     for(int i=0;i<nums.Length;i++){
        nums[i]=dizi[i];
     }
     
    }
}