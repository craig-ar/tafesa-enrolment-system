using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafesaEnrolmentSystem.Model
{
    
    public class Node<T>
    {
        public Node<T> LeftNode { get; set; }
        public Node<T> RightNode { get; set; }
        public T Data { get; set; }
    }

    public class BinaryTree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }
        public bool Add(T value)
        {
            Node<T> before = null;
            Node<T> after = this.Root;

            while (after != null)
            {
                before = after;
                if (value.CompareTo(after.Data) < 0) //Is new node in left tree? 
                    after = after.LeftNode;
                else if (value.CompareTo(after.Data) > 0) //Is new node in right tree?
                    after = after.RightNode;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Node<T> newNode = new Node<T>();
            newNode.Data = value;

            if (this.Root == null)//Tree is empty
                this.Root = newNode;
            else
            {
                if (value.CompareTo(before.Data) < 0)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }

            return true;

        }

        public Node<T> Find(T value)
        {
            return this.Find(value, this.Root);
        }

        private Node<T> Find(T value, Node<T> parent)
        {
            if (parent != null)
            {
                if (value.CompareTo(parent.Data) == 0)
                    return parent;

                if (value.CompareTo(parent.Data) < 0)
                    return Find(value, parent.LeftNode);
                else
                    return Find(value, parent.RightNode);
            }
            return null;
        }

        public void Remove(T value)
        {
            this.Root = Remove(this.Root, value);
        }

        private Node<T> Remove(Node<T> parent, T key)
        {
            if (parent == null) return parent;

            if (key.CompareTo(parent.Data) < 0)
                parent.LeftNode = Remove(parent.LeftNode, key);

            else if (key.CompareTo(parent.Data) > 0)
                parent.RightNode = Remove(parent.RightNode, key);

            // if value is same as parent's value, then this is the node to be deleted  
            else
            {
                // node with only one child or no child  
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                parent.Data = MinValue(parent.RightNode);

                // Delete the inorder successor  
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }

        private T MinValue(Node<T>  node)
        {
            T minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.Root); //get the whole depth from the root
        }

        private int GetTreeDepth(Node<T> current) //get the depth from a particular Node
        {
            return current == null ? 0 : Math.Max(GetTreeDepth(current.LeftNode), GetTreeDepth(current.RightNode)) + 1;
        }

        // TraversePreOrder

        // I adapted previous version of code to also output to a list
        //   for use with NUnit testing (for all traverse methods)
        public void TraversePreOrder(Node<T> parent, List<T> values)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                values.Add(parent.Data);
                TraversePreOrder(parent.LeftNode, values);
                TraversePreOrder(parent.RightNode, values);
            }
        }

        // TraverseInOrder (ascending order)
        public void TraverseInOrder(Node<T> parent, List<T> values)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode,  values);
                Console.Write(parent.Data + " ");
                values.Add(parent.Data);
                TraverseInOrder(parent.RightNode, values);
                
            }
        }

        // TraversePostOrder (LHS, print children first)
        public void TraversePostOrder(Node<T> parent, List<T> values)

        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode, values);
                TraversePostOrder(parent.RightNode, values);
                Console.Write(parent.Data + " ");
                values.Add(parent.Data);
            }
        }
    }
}
