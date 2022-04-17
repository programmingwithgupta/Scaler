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
