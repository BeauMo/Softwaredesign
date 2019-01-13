using System;
using System.Collections.Generic;

namespace A10
{
    class TreeNode<T>
    {
        public TreeNode()
        {
            children = new List<TreeNode<T>> { };
        }

        public int id;

        public List<TreeNode<T>> children;

        public TreeNode<T> parent;

        public T content;

        public List<TreeNode<T>> getAllNodes()
        {
            List<TreeNode<T>> list = new List<TreeNode<T>>();
            return getAllNodesHelper(list);

        }

        private List<TreeNode<T>> getAllNodesHelper(List<TreeNode<T>> list)
        {
            foreach (TreeNode<T> child in children)
            {
                list.Add(child);
                return child.getAllNodesHelper(list);
            }
            return list;
        }

        public void remove()
        {
            int i = 0;
            TreeNode<T> test = this;
            foreach (TreeNode<T> pChild in parent.children)
            {
                if (pChild.id.Equals(id))
                {
                    break;
                }
                i++;
            }
            parent.children.Remove(parent.children[i]);
            foreach (TreeNode<T> child in children)
            {
                child.parent = parent;
                parent.children.Add(child);
            }
            parent = null;
        }
    }
}