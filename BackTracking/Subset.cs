class Solution {

    public List<List<int>> subsets(List<int> A) {
        List<List<int>> res  = new List<List<int>>();
        A.Sort();
        subset(A, 0 , new List<int>(), res);
        
        res.Sort((l1, l2) => {
            
            int index = 0;
            while(index < l1.Count && index < l2.Count){
                if(l1[index] != l2[index]){
                    return l1[index] - l2[index];
                }
                index++;
            }
            
            return l1.Count-l2.Count;
        });

        return res;
    }

    private void subset(List<int> A, int i, List<int> T , List<List<int>> res){
        if(i == A.Count){
            res.Add(new List<int>(T));
            return;
        }
        T.Add(A[i]);
        subset(A, i+1, T, res); //take
        T.RemoveAt(T.Count-1);
        subset(A,i+1,T, res); //skip
    }   
}
