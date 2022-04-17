/*Implement pow(A, B) % C.
In other words, given A, B and C, Find (AB % C).*/

class Solution {
    public int pow(int A, int B, int C) {
        if(A==0)
        return 0;
        if (B == 0)
        return 1;
         else{
             long halfpow =(long)pow(A,B/2,C)%C;
               if(B%2 == 0){
               return (int)((halfpow* halfpow)%C);
           }
           else{
               return (int)((((A+C)%C * halfpow)%C * halfpow)%C);
           }
         
         }
    }
}
