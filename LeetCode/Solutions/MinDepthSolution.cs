public class MinDepthSolution
{
    public int MinDepth(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        } 
        else if (root.left == null && root.right == null)
        {
            return 1;
        } else
        {
            int min = 1000000;
            if(root.left != null)
            {
                min = Math.Min(min, MinDepth(root.left));
            }
            if(root.right != null)
            {
                min = Math.Min(min, MinDepth(root.right));
            }
            return min + 1;
        }
    }
    public void Run()
    {
        int?[] values1 = new int?[] { 3, 9, 20, null, null, 15, 7 };
        int?[] values2 = new int?[] { 2, null, 3, null, 4, null, 5, null, 6 };

        int res;
        TreeNode teste1 = new TreeNode().BuildTree(values1);
        res = this.MinDepth(teste1);
        Console.WriteLine(res);

        TreeNode teste2 = new TreeNode().BuildTree(values2);
        res = this.MinDepth(teste2);
        Console.WriteLine(res);
    }
}