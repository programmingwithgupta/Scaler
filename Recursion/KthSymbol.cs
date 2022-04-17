/*
 * On the first row, we write a 0. Now in every subsequent row, we look at the previous row and replace each occurrence of 0 with 01, and each occurrence of 1 with 10.

Given row A and index B, return the Bth indexed symbol in row A. (The values of B are 1-indexed.) (1 indexed).



Problem Constraints

1 <= A <= 20

1 <= B <= 2A - 1



Input Format

First argument is an integer A.

Second argument is an integer B.



Output Format

Return an integer denoting the Bth indexed symbol in row A.



Example Input

Input 1:

 A = 2
 B = 1
Input 2:

 A = 2
 B = 2

*/



class Solution
{
    public int solve(int N, int K)
    {
        if (K == 1)
            return 0;

        if (K % 2 == 0) return (solve(N - 1, K / 2) == 0) ? 1 : 0;
        else return (solve(N - 1, (K + 1) / 2) == 0) ? 0 : 1;

    }
}