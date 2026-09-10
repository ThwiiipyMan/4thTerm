using System;

class Node{
    public int Data;
    public Node Right;
    public Node Left;
    public Node Parent;

    public Node(int data){
        this.Data = data;
        this.Right = null;
        this.Left = null;
        this.Parent = null;
    }
}

class BST{
    public Node Root;
    public Node currentNode;

    public BST(Node node) {
        if (Root == null) {
            Root = currentNode;
        }
    }

    public void addNode(Node node){

        currentNode = node;
        while (currentNode.Data > node.Data) {
            
        }
    }
}

class Presentation {
    static void Main(){
        
    }
}