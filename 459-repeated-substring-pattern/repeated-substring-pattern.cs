public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        int n=s.Length;
        for(int i=1;i<=n/2;i++){
            if(n%i==0){
                string substring=s.Substring(0,i);
                int tekraradedi=n/i;
                string repeated= new StringBuilder().Insert(0,substring,tekraradedi).ToString();
                if(repeated.Equals(s)){
                    return true;
                }
            }
        }
   return false;
}}