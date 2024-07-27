namespace BSTTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree(52);
            bst.InsertNode(27);
            bst.InsertNode(15);
            bst.InsertNode(30);
            bst.InsertNode(78);
            bst.InsertNode(65);
            bst.InsertNode(53);
            bst.InsertNode(80);

            Node root = bst.GetRoot();

            Console.WriteLine(root.right.right.data);
        }
    }
}
