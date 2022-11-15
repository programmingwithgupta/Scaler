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
    public int isBalanced(TreeNode A) {
        
        bool res = true;
        isBalancedHelper(A,ref res);
        if(res){
            return 1;
        }
        else{
            return 0;
        }
    }

    int isBalancedHelper(TreeNode node,ref bool res){
        if(node == null) return -1;
        int leftH = isBalancedHelper(node.left, ref res);
        int rightH = isBalancedHelper(node.right,ref res);
        if(Math.Abs(leftH - rightH) > 1){
            res = false;
        }
        return 1 + Math.Max(leftH, rightH);
    }
}
