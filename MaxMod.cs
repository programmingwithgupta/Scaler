/*
Given an array A of size N, Groot wants you to pick 2 indices i and j such that

1 <= i, j <= N
A[i] % A[j] is maximum among all possible pairs of (i, j).
Help Groot in finding the maximum value of A[i] % A[j] for some i, j.

*/

class Solution {
    public int solve(List<int> A) {
       
        int N = A.Count ;
        int first = 0 , second = 0;

        for(int i= 0 ; i < N; i++){
            if(first < A[i]){
                second = first;
                first = A[i];
            }
            else if( second < A[i] && A[i] != first){
                second = A[i];
            }
        }

        return second;
    }
}
