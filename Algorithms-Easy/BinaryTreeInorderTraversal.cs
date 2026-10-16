namespace Algorithms_Easy;

/// <summary>
/// 94. Binary Tree Inorder Traversal
/// Given the root of a binary tree, return the inorder traversal of its nodes' values.
/// </summary>
public class BinaryTreeInorderTraversal
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости - Жёлтый). Решил через алгоритм обхода DFS(In-Order)
    /// 1) Доходим до крайних левых элементов, после поднимаемся выше, порядок прохода по узлам: Левый - Корень - Правый
    /// 2) Используем Stack что бы не реализовывать через отдельный метод с рекурсией.
    /// 3) Stack помогает нам с очерёдностью добавление в Result.
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public IList<int> InorderTraversal(TreeNode root) 
    {
        IList<int> result = new List<int>();
        Stack<TreeNode> whileStack = new Stack<TreeNode>();
        TreeNode current = root;

        while (current != null || whileStack.Count > 0)
        {
            while (current != null)
            {
                whileStack.Push(current);
                current = current.left;
            }

            current = whileStack.Pop();
            result.Add(current.val);

            current = current.right;
        }
        
        return result;
    }
    
    public class TreeNode {
         public int val;
             public TreeNode left;
             public TreeNode right;
             public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) 
             {
                 this.val = val;
                 this.left = left;
                 this.right = right;
             }
     }
}