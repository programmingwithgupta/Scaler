class Solution {
    public int solve(List<int> A){

       
        int n = A.Count;
        
        int[] pfodd = new int[n];
        int[] pfeven = new int[n];

        
        pfeven[0] = A[0];
        pfodd[0] = 0;
        for(int i = 1 ; i < n; i++){
            if(i%2 == 0){
                pfeven[i] = pfeven[i-1] + A[i];
            }
            else{
                pfeven[i] = pfeven[i-1];
            }
        }
        
        //j = 1;
        for(int i = 1 ; i < A.Count; i++){
            if(i%2 != 0){
                pfodd[i] = pfodd[i-1] + A[i];
            }
            else{
                pfodd[i] = pfodd[i-1];
            }
        }
        // for(int i = 0 ; i < n; i++){
        //     Console.Write(pfodd[i]);
        // }
        // Console.WriteLine("");
        // for(int i = 0 ; i < n; i++){
        //     Console.Write(pfeven[i]);
        // }
        
        int count = 0;
        
        for(int i = 0 ; i < n ; i++){
            int totalSumOdd= 0 , totalSumEven = 0;
            
            if(i == 0){
                totalSumEven = pfeven[0] + pfodd[n-1] ;
                totalSumOdd =  pfeven[n-1] - pfeven[i];
            }
            else{
                totalSumEven = pfeven[i-1] + pfodd[n-1] - pfodd[i];
                totalSumOdd = pfodd[i-1] + pfeven[n-1] - pfeven[i];
            }
            //Console.WriteLine(sum(0, i , pfeven));
            

            if(totalSumEven == totalSumOdd){
                count++;
            }
        }
        return count;

    }

    // private int sum(int l, int r,int[] pfsum){
    //     if(l == 0){
    //         return pfsum[r-1];
    //     }
    //     else{
    //         return (pfsum[r-1] - pfsum[l]);
    //     }
    // }
}
