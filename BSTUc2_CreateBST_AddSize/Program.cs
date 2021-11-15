using System;

namespace BSTUc2_CreateBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(45);
            bst.Insert(12);
            bst.Insert(88);
            bst.Insert(55);
            bst.Insert(33);
            bst.Insert(64);
            bst.display();
            bst.GetSize();
        }
    }
}
