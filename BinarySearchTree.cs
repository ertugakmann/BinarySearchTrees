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

        public void DFSPreOrderSearch(Node node)
        {
            Console.Write(node.data + ", ");

            if(node.left != null)
            {
                DFSPreOrderSearch(node.left);
            }

            if(node.right != null)
            {
                DFSPreOrderSearch(node.right);
            }
        }

    }
}
