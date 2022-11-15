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
    public int lca(TreeNode A, int B, int C) {
        
        if(!(find(A,B) && find(A,C))){
            return -1;
        }
        TreeNode root = LCA(A,B,C);

        if(root == null){
            return -1;
        }
        return root.val;
    }


    TreeNode LCA(TreeNode A, int B, int C){
        if(A == null){
            return null;
        }

        if( A.val == B || A.val == C){
            return A;
        }

        TreeNode lLCA = LCA(A.left, B, C);

        TreeNode rLCA = LCA(A.right, B, C);

        if(lLCA != null && rLCA != null){
            return A;
        }
        else if(lLCA == null){
            return rLCA;
        }
        return lLCA;
    }

    bool find(TreeNode root, int val){
        if(root == null)
            return false;
        else if(root.val == val){
            return true;
        }
        return (find(root.left, val) || find(root.right, val));
    }
}
