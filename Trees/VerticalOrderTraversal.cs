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
    public List<List<int>> verticalOrderTraversal(TreeNode A) {

        //use sorted Dictionary to store keys  
        SortedDictionary<int,List<int>> map = new SortedDictionary<int,List<int>>();
        Queue<Tuple> q = new Queue<Tuple>();
        List<List<int>> res = new List<List<int>>();
        Tuple t = new Tuple(A,0);
        q.Enqueue(t);

        //first add in queue 
        while(q.Count > 0){
            Tuple tuple = q.Dequeue();
            TreeNode tempNode = tuple.node;
            int d = tuple.dist;
            if(map.ContainsKey(d)){
                List<int> list = map[d];
                list.Add(tempNode.val);
                map.Remove(d);
                map.Add(d,list);
            }
            else{
                List<int> newList = new List<int>() {tempNode.val};
                map.Add(d,newList);
            }
            if(tempNode.left != null){
                q.Enqueue(new Tuple(tempNode.left, d-1));
            }
            if(tempNode.right != null){
                q.Enqueue(new Tuple(tempNode.right, d+1));
            }
        }

        //traverse through each key in HashMap in increasing order


    foreach (KeyValuePair<int,List<int>> item in map)
    {
        //Console.WriteLine(item.Key);
        
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
