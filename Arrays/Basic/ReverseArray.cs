using System;

class Solution
{
    public List<int> solve(List<int> A)
    {
        int temp, i, j;
        int n = A.Count;
        i = 0;
        j = n - 1;
        while (i < j)
        {
            temp = A[i];
            A[i] = A[j];
            A[j] = temp;
            i++;
            j--;
        }
        return A;
    }
}

//TC : O(N/2)