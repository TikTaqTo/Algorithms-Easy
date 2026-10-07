using System.Security.AccessControl;

namespace Algorithms_Easy;

/// <summary>
/// 653. Two Sum IV - Input is a BST
/// Given the root of a binary search tree and an integer k,
/// return true if there exist two elements in the BST such that their sum is equal to k, or false otherwise.
/// </summary>
public class TwoSumIV
{
    /// <summary>
    /// Standart(Базовое решение). Решил через HashSet и Queue.
    /// 1) Queue для прохождения по двоичному дереву
    /// 2) HashSet для проверки соотвествия
    /// </summary>
    /// <param name="root">[5,3,6,2,4,null,7]</param>
    /// <param name="k">9</param>
    /// <returns>true</returns>
    public bool FindTarget(TreeNode root, int k)
    {
        HashSet<int> value = new HashSet<int>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();

            if (value.Contains(k - current.val))
                return true;

            value.Add(current.val);
            
            if (current.left != null)
            {
                queue.Enqueue(current.left);
            }
            if (current.right != null)
            {
                queue.Enqueue(current.right);
            }
        }
        
        return false;
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Для каждого элемента пытаемся найти соотвествующий элемент который даст в сумме k
    /// 1) Queue для прохождения по двоичному дереву
    /// 2) BST - поиск 2 числа который в сумме даст: k
    /// </summary>
    /// <param name="root"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public bool FindTargetBestSpeed(TreeNode root, int k) {
        
        bool BST(TreeNode Node, TreeNode node, int target)
        {
            if(Node == null) return false;
            if(Node.val == target && Node != node) 
                return true;
            if(Node.val > target) 
                return BST(Node.left, node, target); 
            else 
                return  BST(Node.right, node, target);
        }
        
        Queue<TreeNode> Q = new();
        Q.Enqueue(root);
        while(Q.Count > 0)
        {
            var node = Q.Dequeue();
            if(node == null) continue;
            
            if(BST(root, node, k - node.val)) 
                return true;
            
            Q.Enqueue(node.left);
            Q.Enqueue(node.right);
        }
        return false;
    }
    
    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode? left = left;
        public TreeNode? right = right;
    }
}