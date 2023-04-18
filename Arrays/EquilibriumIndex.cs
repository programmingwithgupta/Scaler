/*You are given an array A of integers of size N.

Your task is to find the equilibrium index of the given array

The equilibrium index of an array is an index such that the sum of elements at lower indexes is equal to the sum of elements at higher indexes.

If there are no elements that are at lower indexes or at higher indexes, then the corresponding sum of elements is considered as 0.
    
*/

class Solution {
    public int solve(List<int> A) {
        //List<int> pf = new List<int>();
        
        int sum = 0 , n = A.Count;
        int[] pf = new int[n];
        //Console.WriteLine("n "+n);

       
        //find prefix sum 
        pf[0] = A[0];
        for(int i = 1 ; i < n ; i++){
            pf[i] = pf[i-1] + A[i];
            //pf.Add()
        }

        // for(int i = 0 ; i < n; i++){
        //    Console.Write(pf[i]);
        // }

        
        for(int i = 0 ; i < n ;i++){
            int  leftsum, rightsum = 0;
            if(i == 0){
                leftsum = 0;
            }
            else{
                leftsum = pf[i-1];
            }
            rightsum = pf[n-1] - pf[i];  
            if(leftsum == rightsum){
                //Console.WriteLine(leftsum);
                //Console.WriteLine(rightsum);
                return i;  
            }
            
        }
        return -1;
        
    }
}
