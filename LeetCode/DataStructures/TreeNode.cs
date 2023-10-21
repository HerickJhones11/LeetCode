public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
    public TreeNode BuildTree(int?[] values)
    {
        if(values == null || values.Length == 0)
            return null;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        TreeNode root = new TreeNode(values[0].HasValue ? values[0].Value : 0);
        queue.Enqueue(root);

        for(int i = 1; i < values.Length; i += 2)
        {
            TreeNode current = queue.Dequeue();
            if (values[i].HasValue)
            {
                current.left = new TreeNode(values[i].Value);
                queue.Enqueue(current.left);
            }
            if(i + 1 < values.Length && values[i + 1].HasValue)
            {
                current.right = new TreeNode(values[i + 1].Value);
                queue.Enqueue(current.right);
            }
        }
        return root;
    }
}
