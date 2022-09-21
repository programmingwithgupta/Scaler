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

    public List<List<int>> levelOrder(TreeNode A) {
       
       List<List<int>> res = new List<List<int>>();
       if(A ==  null) return res;
       Queue<TreeNode> q = new Queue<TreeNode>();
       q.Enqueue(A);
       while(q.Count != 0){               
           List<int> level = new List<int>();
           int level_Size = q.Count;
           for(int i = 0; i < level_Size; i++){
               
               TreeNode tempNode = q.Dequeue();
               level.Add(tempNode.val);
                if(tempNode.left != null){
                    q.Enqueue(tempNode.left);
                }
                if(tempNode.right != null){
                    q.Enqueue(tempNode.right);
                }
           }
           
           res.Add(level);
       }
       return res;
    }
}
