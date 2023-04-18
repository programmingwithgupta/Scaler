/*Given a string A consisting only of '(' and ')'.

You need to find whether parentheses in A are balanced or not, if it is balanced then return 1 else return 0.



Problem Constraints
1 <= |A| <= 105



Input Format
First argument is an string A.



Output Format
Return 1 if parantheses in string are balanced else return 0.



Example Input
Input 1:

 A = "(()())"
Input 2:

 A = "(()"


Example Output
Output 1:

 1
Output 2:

 0
 
 */

class Solution {
    
    public int solve(string A) {
        
        Stack<char> mystack = new Stack<char>();

        for(int i=0; i< A.Length ; i++)
        {
            if(A[i] == '(')
            {
                mystack.Push('(');
            }
            else if(A[i] == ')' && mystack.Count != 0){
                mystack.Pop();
            }
            else{
                return 0;
            }
        }

        if(mystack.Count == 0){
            return 1;
        }
        else{
            return 0;
        }
    }
}
