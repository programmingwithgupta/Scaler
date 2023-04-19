/*Given two Integers A, B. You have to calculate (A ^ (B!)) % (1e9 + 7).

"^" means power,

"%" means "mod", and

"!" means factorial.
*/

class Solution {
    public int solve(int A, int B) {

        int p = 1000000007;
        int x = (int)fact(B,p-1);

        int res = pow(A,x,p);

        return res;
    }

    private long fact(int B, int P){
        if(B==1){
            return 1;
        }
        return ((B%P) * fact(B-1,P))%P;
    }

    public int pow(int A, int B, int P) {
        if(A==0)
        return 0;
        if (B == 0)
        return 1;
         else{
             long halfpow =(long)pow(A,B/2,P);
               if(B%2 == 0){
               return (int)((halfpow* halfpow)%P);
           }
           else{
               return (int)(((A * halfpow)%P * halfpow)%P);
           }
         
         }
    }
}
