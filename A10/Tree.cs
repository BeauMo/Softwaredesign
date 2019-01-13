using System;
using System.Collections.Generic;

namespace A10
{
    class Tree<T>
    {
        public Tree(TreeNode<T> root1)
        {
            root = root1;
            counter = 1;
        }

        public TreeNode<T> root;

        public int counter;

        public void AddToTree(TreeNode<T> newParent, TreeNode<T> newNode)
        {
            newNode.id = counter;
            counter += 1;
            newNode.parent = newParent;
            newParent.children.Add(newNode);
        }

        public TreeNode<T> getNodeById(int id)
        {
            foreach (TreeNode<T> treeNode in root.getAllNodes())
            {
                if (treeNode.id == id)
                    return treeNode;
            }
            return null;
        }

        public void print(){
            foreach (TreeNode<T> tn in root.getAllNodes())
            {
                if(tn==null)
                    Console.WriteLine("Fehler");
                else
                    Console.WriteLine(tn.id);
            }
        }
    }
}