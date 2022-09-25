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
        //use Dictionary to store key and first value of each vertical order
        Dictionary<int,int> map = new Dictionary<int,int>();
        Queue<Tuple> q = new Queue<Tuple>();
        List<int> res = new List<int>();
        Tuple t = new Tuple(A,0);
        //add root with 0 distance
        q.Enqueue(t);

        //first add in queue 
        while(q.Count > 0){
            Tuple tuple = q.Dequeue();
            TreeNode tempNode = tuple.node;
            int d = tuple.dist;
            if(!map.ContainsKey(d)){
                map.Add(d,tempNode.val);
            }
            if(tempNode.left != null){
                //distance -1 for left nodes
                q.Enqueue(new Tuple(tempNode.left, d-1));
            }
            if(tempNode.right != null){
                //distance +1 for right nodes
                q.Enqueue(new Tuple(tempNode.right, d+1));
            }
        }


    foreach (KeyValuePair<int,int> item in map)
    {
        res.Add(item.Value);
    }
        return res;
    }
}

class Tuple{
    public TreeNode node;
    public int dist;
    public Tuple(TreeNode n, int d){
        node = n;
        dist = d;

    }
}