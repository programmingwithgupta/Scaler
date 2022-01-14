/*You are given an array of integers A of size N.
Return the difference between the maximum among all even numbers of A and the minimum among all odd numbers in A.
*/


class Solution {
    public int solve(List<int> A) {
        int maxEven = int.MinValue , minOdd = int.MaxValue , res;

        if(A.Count < 2)
             return -1;
        for(int i = 0; i< A.Count; i++){
            if(A[i]%2 == 0 ){
                if(A[i] > maxEven){
                    maxEven = A[i];
                }
            }
            else{
                if(A[i]< minOdd){
                    minOdd = A[i];
                }
            }
        }
        res = maxEven - minOdd;
        return res;
    }
}
