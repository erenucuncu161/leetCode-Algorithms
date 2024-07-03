public class Solution
{
    public bool IsAnagram(string s, string t)
    {
       
        if(t.Length==s.Length){
        for(int i = 0; i < t.Length; i++)
        {
            
           s= elemanDegistir(s,t[i],'0');
        }
        for(int a = 0; a < s.Length; a++)
        {
            if (s[a] != '0')
            {
                return false;
            }
        }
        return true;}
        return false;
        

    }
    public string elemanDegistir(string kaynak,char bul,char degis){
        int sub=kaynak.IndexOf(bul);
        if(sub<0){
            return kaynak;
        }
        return(kaynak.Substring(0,sub)+degis+kaynak.Substring(sub+1));
    }
}
