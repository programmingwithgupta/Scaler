/*
Given a binary tree of integers denoted by root A. Return an array of integers representing the right view of the Binary tree.

Right view of a Binary Tree is a set of nodes visible when the tree is visited from Right side.



Problem Constraints
1 <= Number of nodes in binary tree <= 100000

0 <= node values <= 10^9



Input Format
First and only argument is head of the binary tree A.



Output Format
Return an array, representing the right view of the binary tree.



Example Input
Input 1:

 
            1
          /   \
         2    3
        / \  / \
       4   5 6  7
      /
     8 
Input 2:

 
            1
           /  \
          2    3
           \
            4
             \
              5


Example Output
Output 1:

 [1, 3, 7, 8]
Output 2:

 [1, 3, 4, 5]
*/


/**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */
class Solution {
    public List<int> solve(TreeNode A) {
        List<int> res = new List<int>();
       if(A ==  null) return res;
       Queue<TreeNode> q = new Queue<TreeNode>();
       q.Enqueue(A);
       while(q.Count != 0){               
           int level_Size = q.Count;
           for(int i = 0; i < level_Size; i++){
               
               TreeNode tempNode = q.Dequeue();

                if(tempNode.left != null){
                    q.Enqueue(tempNode.left);
                }
                if(tempNode.right != null){
                    q.Enqueue(tempNode.right);
                }
                if(i == level_Size-1){
                    res.Add(tempNode.val);
                }
           }
       }
       return res;
    }
}
