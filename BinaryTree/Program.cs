using System;

namespace BinaryTree
{
    class TreeNode
    {
        private int data;
        private TreeNode left;
        private TreeNode right;

        public TreeNode(int _data, TreeNode _left, TreeNode _right)
        {
            this.data = _data;
            this.left = _left;
            this.right = _right;
        }

        public int Data { get => data; set => data = value; }
        public TreeNode Left { get => left; set => left = value; }
        public TreeNode Right { get => right; set => right = value; }
    }

    class Tree
    {
        private TreeNode root;

        public Tree(TreeNode _root)
        {
            this.root = _root;
        }

        public void Preorder(TreeNode _root)
        {
            if (_root != null)
            {
                Console.Write(_root.Data + " ");
                Preorder(_root.Left);
                Preorder(_root.Right);
            }
        }
        public void Inorder(TreeNode _root)
        {
            if (_root != null)
            {
                Inorder(_root.Left);
                Console.Write(_root.Data + " ");
                Inorder(_root.Right);
            }
        }
        public void Postorder(TreeNode _root)
        {
            if (_root != null)
            {
                Postorder(_root.Left);
                Postorder(_root.Right);
                Console.Write(_root.Data + " ");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode n0 = new TreeNode(50, null, null);
            TreeNode n1 = new TreeNode(12, null, null);
            TreeNode n2 = new TreeNode(35, null, null);
            TreeNode n3 = new TreeNode(13, null, null);
            TreeNode n4 = new TreeNode(32, null, null);
            TreeNode n5 = new TreeNode(7, null, null);

            n0.Left = n1;
            n0.Right = n2;
            n1.Right = n3;
            n2.Left = n4;
            n2.Right = n5;

            Console.Write(n0.Data + " " + n0.Left.Data);
            Tree tree = new Tree(n0);
            Console.WriteLine("전위 순회");
            tree.Preorder(n0);
            Console.WriteLine("\n중위 순회");
            tree.Inorder(n0);
            Console.WriteLine("\n후위 순회");
            tree.Postorder(n0);
        }
    }
}
