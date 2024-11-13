using System;
using System.Text;

public class Node
{
    public int Data { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

public class BinaryTree
{
    public Node Root { get; set; }

    // Método para insertar un nodo en el árbol
    public void Insert(int data)
    {
        if (Root == null)
        {
            Root = new Node(data);
        }
        else
        {
            InsertRec(Root, data);
        }
    }

    private void InsertRec(Node root, int data)
    {
        if (data < root.Data)
        {
            if (root.Left == null)
                root.Left = new Node(data);
            else
                InsertRec(root.Left, data);
        }
        else
        {
            if (root.Right == null)
                root.Right = new Node(data);
            else
                InsertRec(root.Right, data);
        }
    }

    // Método para eliminar un nodo del árbol
    public void Delete(int data)
    {
        Root = DeleteRec(Root, data);
    }

    private Node DeleteRec(Node root, int data)
    {
        if (root == null) return root;

        if (data < root.Data)
        {
            root.Left = DeleteRec(root.Left, data);
        }
        else if (data > root.Data)
        {
            root.Right = DeleteRec(root.Right, data);
        }
        else
        {
            // Nodo con un solo hijo o sin hijos
            if (root.Left == null)
                return root.Right;
            else if (root.Right == null)
                return root.Left;

            // Nodo con dos hijos: obtener el sucesor en el subárbol derecho
            root.Data = MinValue(root.Right);

            // Eliminar el sucesor
            root.Right = DeleteRec(root.Right, root.Data);
        }
        return root;
    }

    private int MinValue(Node node)
    {
        int minValue = node.Data;
        while (node.Left != null)
        {
            minValue = node.Left.Data;
            node = node.Left;
        }
        return minValue;
    }

    // Método para imprimir el árbol en un formato de texto
    public string PrintTree()
    {
        StringBuilder result = new StringBuilder();
        PrintTreeRec(Root, "", result);
        return result.ToString();
    }

    private void PrintTreeRec(Node node, string indent, StringBuilder result)
    {
        if (node != null)
        {
            PrintTreeRec(node.Right, indent + "   ", result);
            result.AppendLine(indent + node.Data);
            PrintTreeRec(node.Left, indent + "   ", result);
        }
    }
}
