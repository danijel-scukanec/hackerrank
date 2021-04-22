using System;

namespace HackerRank.Tree.HeightOfABinaryTree
{
    class Node
    {
        public Node Left { get; set; }

        public Node Right { get; set; }

        public int Data { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var tree1 = CreateTree1();
            Console.WriteLine(height(tree1));

            var tree2 = CreateTree2();
            Console.WriteLine(height(tree2));

            var tree3 = CreateTree3();
            Console.WriteLine(height(tree3));
        }

        public static int height(Node root)
        {
            if (root == null)
            {
                return -1;
            }

            Console.WriteLine($"Current node data is {root.Data}");
            var h = 1 + Math.Max(height(root.Left), height(root.Right));
            Console.WriteLine($"Current height is {h}");
            return h;
        }

        static Node CreateTree1()
        {
            var rootNode = new Node { Data = 4 };
            rootNode.Left = new Node { Data = 2 };
            rootNode.Left.Left = new Node { Data = 1 };
            rootNode.Left.Right = new Node { Data = 3 };
            rootNode.Right = new Node { Data = 6 };
            rootNode.Right.Left = new Node { Data = 5 };
            rootNode.Right.Right = new Node { Data = 7 };
            return rootNode;
        }

        static Node CreateTree2()
        {
            var rootNode = new Node { Data = 3 };
            rootNode.Left = new Node { Data = 2 };
            rootNode.Left.Left = new Node { Data = 1 };
            rootNode.Right = new Node { Data = 5 };
            rootNode.Right.Left = new Node { Data = 4 };
            rootNode.Right.Right = new Node { Data = 6 };
            rootNode.Right.Right.Right = new Node { Data = 7 };
            return rootNode;
        }

        static Node CreateTree3()
        {
            var rootNode = new Node { Data = 3 };
            return rootNode;
        }
    }
}
