/**

A = [1, 2, 3, 4, 5, -1, -1, -1, -1, -1, -1]
Input 2:

 A = [1, 2, 3, 4, 5, -1, 6, -1, -1, -1, -1, -1, -1]


Example Output
Output 1:

           1
         /   \
        2     3
       / \
      4   5

 Output 2:

            1
          /   \
         2     3
        / \ .   \
       4   5 .   6     

       
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */
class Solution {
    public TreeNode solve(List<int> A) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if(A.Count == 0){
            return null;
        }
        TreeNode root = new TreeNode(A[0]);
        queue.Enqueue(root);
        int i= 0;
        while(queue.Count> 0){
            TreeNode node = queue.Dequeue();
            if(node!=null){
                if(A[i+1]!=-1){
                    node.left = new TreeNode(A[i+1]);
                }
                else{
                    node.left = null;
                }
                if(A[i+2]!=-1){
                    node.right = new TreeNode(A[i+2]);
                }
                else{
                    node.right = null;
                }
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
                i= i+2;
            }
        }
        return root;
    }
}


