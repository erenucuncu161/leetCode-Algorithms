public class Solution {
    public int RomanToInt(string s) {
        int sum=0;
        int onceki=0;
        var rakamlar = new Dictionary<char,int>();
        //Diğer listelerde olduğu gibi Add() metodu ile ekleme yapıyoruz..
        rakamlar.Add('I',1);
        rakamlar.Add('V',5 );
        rakamlar.Add('X',10 );
        rakamlar.Add('L',50 );
        rakamlar.Add('C',100 );
        rakamlar.Add('D',500 );
        rakamlar.Add('M',1000 );
        for(int i=s.Length-1;i>=0;i--){
           int simdikiDeger=rakamlar[s[i]];
           if(simdikiDeger<onceki){
            sum-=simdikiDeger;
           }
           else sum+=simdikiDeger;
           onceki=simdikiDeger;
            
        }
        return sum;
    }}
