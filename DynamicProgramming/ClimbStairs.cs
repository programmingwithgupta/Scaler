

//Bottom Up Approach
class Solution {
    public int climbStairs(int n) {


        int[] cache = new int[n+1];

        cache[0] = 1;
        cache[1] = 1;

        for(int i=2 ; i <=n ; i++){
            cache[i] = ( cache[i-1]% 1000000007 + cache[i-2]% 1000000007)% 1000000007;
        }

        return cache[n] % 1000000007;
    }
}
