using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL
{
    public class Node
    {
        public int Id { get; set;}
        public int Height { get; set; }
        public Node RightNode { get; set; }
        public Node LeftNode { get; set; }

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

            Node LeftRotation(Node p)
            {
                Node pivot = p.RightNode;  
                Node aux = pivot.LeftNode;

                pivot.LeftNode = p;
                p.RightNode = aux;

                p.Height = Math.Max(NodeHeight(p.LeftNode),NodeHeight(p.RightNode)) + 1;
                pivot.Height = Math.Max(NodeHeight(pivot.LeftNode),NodeHeight(pivot.RightNode)) + 1;

                return pivot;
            }

            Node RightRotation(Node p)
            {
                Node pivot = p.LeftNode;
                Node aux = pivot.RightNode;

                pivot.RightNode = p;
                p.LeftNode = aux;

                p.Height = Math.Max(NodeHeight(p.LeftNode), NodeHeight(p.RightNode)) + 1;
                pivot.Height = Math.Max(NodeHeight(pivot.LeftNode), NodeHeight(pivot.RightNode)) + 1;

                return pivot;

            }

            public Node InsertionNode(Node n, int id)
            {

                if (n == null)
                    return new Node(id);

                if (id < n.Id)
                    n.LeftNode = InsertionNode(n.LeftNode, id);
                else if (id > n.Id)
                    n.RightNode = InsertionNode(n.RightNode, id);
                else 
                    return n;

                n.Height = 1 + Math.Max(NodeHeight(n.LeftNode),NodeHeight(n.RightNode));

                int b = Balance(n);

                if (b < -1 && id > n.RightNode.Id)
                    return LeftRotation(n);

    
                if (b > 1 && id < n.LeftNode.Id)
                    return RightRotation(n);

                if (b > 1 && id > n.LeftNode.Id)
                {
                    n.LeftNode = LeftRotation(n.LeftNode);
                    return RightRotation(n);
                }

                if (b < -1 && id < n.RightNode.Id)
                {
                    n.RightNode = RightRotation(n.RightNode);
                    return LeftRotation(n);
                }

                return n;
            }

            public void ShowUpTree(Node node)
            {
                if (node != null)
                {
                    if (node.Height - root.Height == 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine($"Raiz da árvore: {node.Id}" + " ");
                        Console.WriteLine("Nodos do lado esquerdo da raiz:");
                        ShowUpTree(node.LeftNode);
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Nodos do lado direito da raiz:");
                        ShowUpTree(node.RightNode);
                    }
                    else
                    {
                        Console.Write($"Nodo: {node.Id}" + " ");
                        Console.WriteLine(" ");
                        if (node.LeftNode is not null)
                        {
                            Console.WriteLine($"Filho esquerdo do nodo {node.Id}: ");
                            ShowUpTree(node.LeftNode);
                        }
                        if (node.RightNode is not null)
                        {
                            Console.WriteLine($"Filho direito do nodo {node.Id}: ");
                            ShowUpTree(node.RightNode);
                        }

                    }
                }
            }
        }
}
