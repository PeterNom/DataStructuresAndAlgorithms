using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    internal class BinaryTree
    {
        public Node? Root { get; set; }

        public bool AddNode(int nodeValue)
        {
            if (Root == null)
            {
                this.Root = new Node(nodeValue);

                return true;
            }

            Node node = this.Root;

            while (node != null)
            {
                if (nodeValue == node.Data)
                {
                    return false;
                }

                if (nodeValue > node.Data)
                {
                    if (node.RightNode == null)
                    {
                        node.RightNode = new Node(nodeValue);

                        return true;
                    }
                    else
                    {
                        node = node.RightNode;
                        continue;
                    }
                }

                if (nodeValue < node.Data)
                {
                    if (node.LeftNode == null)
                    {
                        node.LeftNode = new Node(nodeValue);
                        return true;
                    }
                    else
                    {
                        node = node.LeftNode;
                        continue;
                    }
                }
            }

            return false;
        }

        public Node? Find(int value)
        {
            return this.Find(value, Root);
        }
        
        private Node? Find(int value, Node? parent)
        {
            if(parent!=null)
            {
                if (value == parent.Data) return parent;
                if (value < parent.Data)
                {
                    return Find(value, parent.LeftNode);
                }
                else
                {
                    return Find(value, parent.RightNode);
                }
            }
            return null;
        }

        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }

        private Node? Remove(Node? parent, int key)
        {
            if (parent == null) return parent;

            if (key < parent.Data)
            {
                parent.LeftNode = Remove(parent.LeftNode, key);
            }
            else if (key > parent.Data)
            {
                parent.RightNode = Remove(parent.RightNode, key);
            }
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
        private int MinValue(Node node)
        {
            int minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }

        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.Root);
        }
    
        private int GetTreeDepth(Node? parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.LeftNode), GetTreeDepth(parent.RightNode)) + 1;
        }
        
        public void TraversePreOrder(Node? parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        public void TraverseInOrder(Node? parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }
        
        public void TraversePostOrder(Node? parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);

                Console.Write(parent.Data + " ");
            }
        }
    }

    class Node
    {
        public Node(int value) 
        {
            this.Data = value;
            this.LeftNode = null;
            this.RightNode = null;
        }

        public Node? LeftNode { get; set; }
        public Node? RightNode { get; set; }
        public int Data { get; set; }
    }

}
