/*Given an array A of integers and another non negative integer k, find if there exists 2 indices i and j such that A[i] - A[j] = k, i != j.

Example :

Input :

A : [1 5 3]
k : 2
Output :

1
as 3 - 1 = 2

Return 0 / 1 for this problem.*/

import java.util.*;
public class Solution {
    // DO NOT MODIFY THE ARGUMENTS WITH "final" PREFIX. IT IS READ ONLY
    public int diffPossible(final int[] A, int B) {
       Set<Integer> S = new HashSet<Integer>();
        int n = A.length;
         for(int i = 0 ; i < n; i++){
             int x = B + A[i];
             int y = A[i] - B;
             if(S.contains(x) || S.contains(y)){
                 return 1;
             }
             else{
                 S.add(A[i]);
             }
             
         }
        return 0;
    }
}
