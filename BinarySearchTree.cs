using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTTrees
{
    class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public BinarySearchTree(int data)
        {
            root = new Node(data);
        }

        public Node GetRoot() {
            return root;
        }

        public bool InsertNode(int data)
        {
            Node newNode = new Node(data);

            if (root == null)
            {
                root = newNode;
                return true;
            }
            else
            {
                Node tmp = root;

                while (true)
                {
                    if (newNode.data == tmp.data)
                        return false;

                    if (newNode.data < tmp.data)
                    {
                        if (tmp.left == null)
                        {
                            tmp.left = newNode;
                            return true;
                        }
                        tmp = tmp.left;
                    }
                    else if (newNode.data > tmp.data)
                    {
                        if (tmp.right == null)
                        {
                            tmp.right = newNode;
                            return true;
                        }
                        tmp = tmp.right;
                    }
                }
            }
        }

        public void DFSPreOrderSearchPrintAll(Node node)
        {
            Console.Write(node.data + ", ");

            if (node.left != null)
            {
                DFSPreOrderSearchPrintAll(node.left);
            }

            if (node.right != null)
            {
                DFSPreOrderSearchPrintAll(node.right);
            }
        }

        public Node DFSPreOrderSearch(Node node, int searchValue)
        {
            if (node == null || node.data == searchValue)
                return node;

            if(searchValue < node.data)
            {
                return DFSPreOrderSearch(node.left, searchValue);
            }
            else
            {
                return DFSPreOrderSearch(node.right, searchValue);
            }
        }
        public void DFSPostOrderSearchPrintAll(Node node)
        {
          
            if (node.left != null)
            {
                DFSPostOrderSearchPrintAll(node.left);
            }

            if (node.right != null)
            {
                DFSPostOrderSearchPrintAll(node.right);
            }

            Console.Write(node.data + ", ");
        }

        public void DFSInOrderSearchPrintAll(Node node)
        {
            if(node.left != null)
            {
                DFSInOrderSearchPrintAll(node.left);
            }

            Console.Write(node.data + ", ");

            if(node.right != null)
            {
                DFSInOrderSearchPrintAll(node.right);
            }
        }

        public void BreadthFirstSearch()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                Node node = queue.Dequeue();
                Console.Write(node.data + ", ");

                if(node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if(node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
        }

    }
}
