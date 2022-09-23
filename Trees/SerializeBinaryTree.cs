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

    List<int> list = new List<int>();
    Queue<TreeNode> queue = new Queue<TreeNode>();
    queue.Enqueue(A);
    list.Add(A.val);
    while(queue.Count != 0 )
        {
            TreeNode node = queue.Dequeue();
            if(node != null){
                
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
        
                if(node.left != null){
                    list.Add(node.left.val);
                }
                else{
                    list.Add(-1);
                }
                if(node.right != null){
                    list.Add(node.right.val);
                }
                else{
                     list.Add(-1);
                }   
            }

        }
        return list;
    }

}
