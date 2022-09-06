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

        public int GetData()
        {
            return data;
        }
        public TreeNode GetLeft()
        {
            return left;
        }
        public TreeNode GetRight()
        {
            return right;
        }

        public void SetLeft(TreeNode node)
        {
            this.left = node;
        }

        public void SetRight(TreeNode node)
        {
            this.right = node;
        }
    }
    class Tree
    {
        private TreeNode root;

        public Tree(TreeNode _root)
        {
            this.root = _root;
        }

        public TreeNode GetRoot()
        {
            return this.root;
        }

        public void PreorderTraversal()
        {
            Preorder(this.root);
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

        public TreeNode Insert(int value)
        {
            if (this.root == null)
            {
                this.root = new TreeNode(value, null, null);
                return this.root;
            }
            TreeNode node = this.root;
            while (node != null)
            {
                int data = node.GetData();
                if (data == value)
                {
                    Console.WriteLine("찾았습니다.");
                    return node;
                }
                else if (data > value)
                {
                    if (node.GetLeft() == null)
                    {
                        TreeNode temp = new TreeNode(value, null, null);
                        node.SetLeft(temp);
                        return temp;
                    }
                    node = node.GetLeft();

                }
                else
                {
                    if (node.GetRight() == null)
                    {
                        TreeNode temp = new TreeNode(value, null, null);
                        node.SetRight(temp);
                        return temp;
                    }
                    node = node.GetRight();
                }
            }
            return null;
        }

        public TreeNode Search(int value)
        {
            if (this.root == null)
            {
                Console.WriteLine("Tree is not zonzae");
                return null;
            }

            TreeNode node = this.root;

            Console.WriteLine("\n검색 시작 ==>");
            while (node != null)
            {
                int data = node.GetData();
                if (data == value)
                {
                    Console.WriteLine("찾았습니다");
                    return node;
                }
                else if (data > value) node = node.GetLeft();
                else node = node.GetRight();
            }

            Console.WriteLine("\n못 찾았습니다 ㅜㅜ");
            return null;
        }

        public TreeNode FindMin(TreeNode _root)
        {
            if(_root == null)
            {
                Console.WriteLine("트리가 비었습니다.");
                return null;
            }

            TreeNode node = _root;

            Console.WriteLine("\n검색 시작 ==>");
            Console.Write("{0} ", node.GetData());
            while(node.GetLeft() != null)
            {
                node = node.GetLeft();
                Console.Write("{0} ", node.GetData());
            }

            return node;
        }
        public TreeNode FindMax(TreeNode _root)
        {
            if (_root == null)
            {
                Console.WriteLine("트리가 비었습니다.");
                return null;
            }

            TreeNode node = _root;

            Console.WriteLine("\n검색 시작 ==>");
            Console.Write("{0} ", node.GetData());
            while (node.GetRight() != null)
            {
                node = node.GetRight();
                Console.Write("{0} ", node.GetData());
            }

            return node;
        }

        public TreeNode Delete(int value)
        {
            if (this.root == null)
            {
                Console.WriteLine("트리가 비었습니다.");
                return null;
            }

            TreeNode node = this.root;
            TreeNode parent = node;
            TreeNode left, right;
            TreeNode pleft, pright;

            left = right = pleft = pright = null;

            Console.Write("\n검색 시작 ==>");
            while (node != null)
            {
                int data = node.GetData();
                Console.Write("{0} ", data);

                if(data == value)
                {
                    Console.WriteLine("찾았습니다.");

                    left = node.GetLeft();
                    right = node.GetRight();

                    if (left != null && right != null)
                    {
                        TreeNode temp = FindMax(left);
                        Delete(temp.GetData());
                        if(node == this.root)
                        {
                            this.root = temp;
                            if (temp != left) root.SetLeft(left);
                            root.SetRight(right);
                            return root;
                        }
                        if(temp != left) temp.SetLeft(left);
                        else
                        {
                            if (parent.GetData() > data) parent.SetLeft(temp);
                            else parent.SetRight(temp);
                        }
                        temp.SetRight(right);
                    }
                    else if (left == null && right == null)
                    {
                        if(this.root == node) this.root = null;
                        else
                        {
                            if (parent.GetData() > data) parent.SetLeft(null);
                            else parent.SetRight(null);
                        }
                    }
                    else
                    {
                        
                    }
                }
                else if(data > value)
                {
                    node = node.GetLeft();
                }
                else
                {

                }
            }

            Console.Write("\n존재하지 않는다");
            return null;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree(null);

            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(6);
            tree.Insert(1);
            tree.Insert(7);

            tree.Preorder(tree.GetRoot());
        }
    }
}
