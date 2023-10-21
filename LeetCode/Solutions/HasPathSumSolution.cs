using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    public class HasPathSumSolution
    {
        public int PathSum(TreeNode root, int current, int target)
        {
            if(root == null)
            {
                return 0;
            }
            else if(root.left == null && root.right == null)
            {
                return current;
            }
            else
            {
                int sum = -1001;
                if(root.left != null)
                {
                    if(PathSum(root.left, current + root.left.val, target) == target)
                    {
                        return target;
                    }
                }
                if(root.right != null)
                {
                    if (PathSum(root.right, current + root.right.val, target) == target)
                    {
                        return target;
                    }
                }
                return sum;
            }
        }
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;
            if (root.left == null && root.right == null)
            {
                if(root.val == targetSum)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            var res = PathSum(root, root.val, targetSum);
            if(res != -1)
                return true;
            return false;
        }

        public void Run()
        {
            var targetSum = 22;
            var values1 = new TreeNode().BuildTree(new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1 });
            var res = this.HasPathSum(values1, targetSum);
            Console.WriteLine(res);


            targetSum = 5;
            var values2 = new TreeNode().BuildTree(new int?[] { 1, 2, 3 });
            res = this.HasPathSum(values2, targetSum);
            Console.WriteLine(res);

            targetSum = 0;
            values2 = new TreeNode().BuildTree(new int?[] { });
            res = this.HasPathSum(values2, targetSum);
            Console.WriteLine(res);

            targetSum = 0;
            values2 = new TreeNode().BuildTree(new int?[] { 1 });
            res = this.HasPathSum(values2, targetSum);
            Console.WriteLine(res);
        }

    }
}
