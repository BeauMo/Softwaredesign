using System;
using System.Collections.Generic;

namespace A10
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode<String> root = new TreeNode<String>();
            root.id = 0;

            Tree<String> tree = new Tree<String>(root);

            TreeNode<String> tn1 = new TreeNode<string>
            {
                content = "Vater"
            };

            TreeNode<String> tn2 = new TreeNode<string>
            {
                content = "Kind"
            };

            TreeNode<String> tn3 = new TreeNode<string>
            {
                content = "Enkel"
            };

            tree.AddToTree(root, tn1);
            tree.AddToTree(tn1, tn2);
            tree.AddToTree(tn2, tn3);

            //Console.WriteLine(root.id);
            tn2.remove();

            tree.print();
        }
    }
}
