using System;

namespace FourthTerm
{
    public class Node
    {
        public int Data;
        public Node? Left;
        public Node? Right;

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    public class BST
    {
        public Node? Root;

        public void Insert(int data)
        {
            Node newNode = new Node(data);

            if (Root == null)
            {
                Root = newNode;
                return;
            }

            Node current = Root;
            while (true)
            {
                if (data < current.Data)
                {
                    if (current.Left == null)
                    {
                        current.Left = newNode;
                        return;
                    }
                    current = current.Left;
                }
                else if (data > current.Data)
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                        return;
                    }
                    current = current.Right;
                }
                else
                {
                    Console.WriteLine($"{data} already exists in the tree.");
                    return;
                }
            }
        }

        public void Delete(int data)
        {
            Root = DeleteNode(Root, data);
        }

        private Node? DeleteNode(Node? node, int data)
        {
            if (node == null)
            {
                Console.WriteLine($"{data} not found in the tree.");
                return null;
            }

            if (data < node.Data)
            {
                node.Left = DeleteNode(node.Left, data);
            }
            else if (data > node.Data)
            {
                node.Right = DeleteNode(node.Right, data);
            }
            else
            {
                if (node.Left == null)
                    return node.Right;
                if (node.Right == null)
                    return node.Left;

                Node successor = node.Right;
                while (successor.Left != null)
                    successor = successor.Left;

                node.Data = successor.Data;
                node.Right = DeleteNode(node.Right, successor.Data);
            }

            return node;
        }

        public void PreOrder(Node? node)
        {
            if (node == null) return;
            Console.Write(node.Data + " ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public void InOrder(Node? node)
        {
            if (node == null) return;
            InOrder(node.Left);
            Console.Write(node.Data + " ");
            InOrder(node.Right);
        }

        public void PostOrder(Node? node)
        {
            if (node == null) return;
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Data + " ");
        }
    }

    public class Program
    {
        static BST tree = new BST();

        public static void Menu()
        {
            Console.WriteLine("<>===<> Binary Search Tree <>===<>");
            Console.WriteLine("1. Input Nodes");
            Console.WriteLine("2. Display BST");
            Console.WriteLine("3. Exit program");
        }

        static void InputNodes()
        {
            Console.WriteLine("Enter numbers to insert (-1 to stop):");
            while (true)
            {
                Console.Write("Enter a number: ");
                try
                {
                    int input = int.Parse(Console.ReadLine()!);
                    if (input == -1) break;
                    tree.Insert(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        static void DisplayBST()
        {
            if (tree.Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            
            Console.WriteLine();
            Console.Write("Pre order: ");
            tree.PreOrder(tree.Root);
            Console.WriteLine();

            Console.Write("\nIn order: ");
            tree.InOrder(tree.Root);
            Console.WriteLine();

            Console.Write("\nPost order: ");
            tree.PostOrder(tree.Root);
            Console.WriteLine("\n");
        }

        public static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Menu();
                Console.Write("select action: ");
                try
                {
                    int action = int.Parse(Console.ReadLine()!);

                    switch (action)
                    {
                        case 1:
                            InputNodes();
                            break;
                        case 2:
                            DisplayBST();
                            break;
                        case 3:
                            Console.WriteLine("Exiting...");
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Invalid selection.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}
