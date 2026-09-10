using System;

class Node
{
    private int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        this.Data = data;
        this.Left = null;
        this.Right = null;
    }

    public int getData()
    {
        return this.Data;
    }

    public int getLeft()
    {
        return this.Left.getData();
    }

    public int getRight()
    {
        return this.Right.getData();
    }
}

class Tree
{
    public Node Root;

    public Tree()
    {
        this.Root = null;
    }

    public void InsertTree(Node node)
    {
        if (this.Root == null)
        {
            this.Root = node;
        }

        if (node.getData() < this.Root.getData())
        {
            if (this.Root.Left != null)
                InsertTree(node);
            else
                this.Root.Left = node;
        }
        else
        {
            if (this.Root.Right != null)
                InsertTree(node);
            else
                this.Root.Right = node;
        }
    }

    DisplayTree(Node node)
    {
        if (node != null)
        {
            DisplayTree(node.Left);
            Console.WriteLine(node.getData());
            DisplayTree(node.Right);
        }
    }
}

class BinSeaTree
{
    public static void Main(string[] args)
    {
        boolean exitCondition = true;

        while (exitCondition)
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            if (input == -1) { }
            exitCondition = false;
            else
            {
                newNode = new Node(input);
                tree.InsertTree(newNode);
            }
        }
    }
}