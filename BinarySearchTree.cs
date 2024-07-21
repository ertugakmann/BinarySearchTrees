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

        public bool InsertNode(int data)
        {
            Node newNode = new Node(data);

            if(root == null)
            {
                root = newNode;
                return true;
            }
            else
            {
                Node temp = root;

                while (true)
                {
                    if (newNode.data == temp.data)
                        return false;

                    if(newNode.data < temp.data)
                    {
                        if (temp.left == null)
                        {
                            temp.left = newNode;
                            return true;
                        }
                        temp.left = temp;
                    }
                    else
                    {
                        if(temp.right == null)
                        {
                            temp.right = newNode;
                            return true;
                        }
                        temp.right = temp;
                    }
                }
            }
        }

    }
}
