using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL
{
    public class Node1
    {
        public int Id;
        public int Height;
        public Node1 LeftNode;
        public Node1 RightNode;

        public Node1(int id)
        {
            Id = id;
            Height = 1;
        }
    }

    public class AVLTree
    {
        public Node1 root;

        int NodeHeight(Node1 node)
        {
            if (node is null)
            {
                return 0;
            }

            return node.Height;
        }

        Node1 LeftRotate(Node1 p)
        {
            Node1 pivot = p.RightNode;
            Node1 aux = pivot.LeftNode;

            pivot.LeftNode = p;
            p.RightNode = aux;

            p.Height = Math.Max(NodeHeight(p.LeftNode), NodeHeight(p.RightNode)) + 1;
            pivot.Height = Math.Max(NodeHeight(pivot.LeftNode), NodeHeight(pivot.RightNode)) + 1;

            return pivot;
        }

        Node1 RightRotate(Node1 p)
        {
            Node1 pivot = p.LeftNode;
            Node1 aux = pivot.RightNode;

            pivot.RightNode = p;
            p.LeftNode = aux;

            p.Height = Math.Max(NodeHeight(p.LeftNode), NodeHeight(p.RightNode)) + 1;
            pivot.Height = Math.Max(NodeHeight(pivot.LeftNode), NodeHeight(pivot.RightNode)) + 1;

            return pivot;

        }

        int Balance(Node1 node)
        {
            if (node is null)
            {
                return 0;
            }

            return NodeHeight(node.LeftNode) - NodeHeight(node.RightNode);
        }

        public Node1 InsertioTree(Node1 node, int id)
        {

            if (node == null)
                return new Node1(id);

            if (id < node.Id)
                node.LeftNode = InsertioTree(node.LeftNode, id);
            else if (id > node.Id)
                node.RightNode = InsertioTree(node.RightNode, id);
            else
                return node;

            node.Height = 1 + Math.Max(NodeHeight(node.LeftNode), NodeHeight(node.RightNode));

            int b = Balance(node);


            if (b > 1 && id < node.LeftNode.Id)
                return RightRotate(node);

            if (b < -1 && id > node.RightNode.Id)
                return LeftRotate(node);

            if (b > 1 && id > node.LeftNode.Id)
            {
                node.LeftNode = LeftRotate(node.LeftNode);
                return RightRotate(node);
            }

            if (b < -1 && id < node.RightNode.Id)
            {
                node.RightNode = RightRotate(node.RightNode);
                return LeftRotate(node);
            }

            return node;
        }

        public void preOrder(Node1 node)
        {
            if (node != null)
            {
                Console.Write(node.Id + " ");
                preOrder(node.LeftNode);
                preOrder(node.RightNode);
            }
        }

        //public void ShowUpTree()
        //{
        //    if (root is null)
        //    {
        //        Console.WriteLine("A árvore está vazia.");
        //        return;
        //    }
        //    else
        //    {
        //        DisplayInOrder(root);
        //        Console.WriteLine();
        //    }
        //}

        //void DisplayInOrder(Node node)
        //{
        //    if (node is not null)
        //    {
        //        DisplayInOrder(node.LeftNode);
        //        Console.WriteLine($"Id node:{node.Id}");
        //        DisplayInOrder(node.RightNode);
        //    }
        //}
    }
}
