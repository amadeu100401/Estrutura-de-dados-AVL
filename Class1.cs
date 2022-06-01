using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL
{
    public class Node
    {
        public int Id;
        public int Height;
        public Node RightNode;
        public Node LeftNode;
        
        public Node(int id)
        {
            Id = id;
            Height = 1;
        }
    }

     public class AVLTree
        {
            public Node root;

            int NodeHeight(Node node)
            {
                if (node is null)
                {
                    return 0;
                }

                return node.Height;
            }

            int Balance(Node node)
            {
                if (node is null)
                {
                    return 0;
                }

                return NodeHeight(node.LeftNode) - NodeHeight(node.RightNode);
            }

            Node LeftRotate(Node p)
            {
                Node pivot = p.RightNode;  
                Node aux = pivot.LeftNode;

                pivot.LeftNode = p;
                p.RightNode = aux;

                p.Height = Math.Max(NodeHeight(p.LeftNode),NodeHeight(p.RightNode)) + 1;
                pivot.Height = Math.Max(NodeHeight(pivot.LeftNode),NodeHeight(pivot.RightNode)) + 1;

                return pivot;
            }

            Node RightRotate(Node p)
            {
                Node pivot = p.LeftNode;
                Node aux = pivot.RightNode;

                pivot.RightNode = p;
                p.LeftNode = aux;

                p.Height = Math.Max(NodeHeight(p.LeftNode), NodeHeight(p.RightNode)) + 1;
                pivot.Height = Math.Max(NodeHeight(pivot.LeftNode), NodeHeight(pivot.RightNode)) + 1;

                return pivot;

            }

            public Node InsertionNode(Node node, int id)
            {

                if (node == null)
                    return new Node(id);

                if (id < node.Id)
                    node.LeftNode = InsertionNode(node.LeftNode, id);
                else if (id > node.Id)
                    node.RightNode = InsertionNode(node.RightNode, id);
                else 
                    return node;

                node.Height = 1 + Math.Max(NodeHeight(node.LeftNode),NodeHeight(node.RightNode));

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

            public void ShowUpTree(Node node)
            {
                if (node != null)
                {
                    if (node.Height - root.Height == 0)
                    {
                        Console.WriteLine($"Raiz da árvore: {node.Id}" + " ");
                        Console.WriteLine("Filhos do lado esquerdo da raiz:");
                        ShowUpTree(node.LeftNode);
                        Console.WriteLine("Filhos do lado direito da raiz:");
                        ShowUpTree(node.RightNode);
                    }
                    else
                    {
                        Console.WriteLine($"Nodo: {node.Id}" + " ");
                        ShowUpTree(node.LeftNode);
                        ShowUpTree(node.RightNode);
                    }
                }
            }
        }
}
