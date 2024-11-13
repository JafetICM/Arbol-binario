using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArbolBinarioApp
{
    public partial class Form1 : Form
    {
        private BinaryTree binaryTree;

        public Form1()
        {
            InitializeComponent();
            binaryTree = new BinaryTree();
        }

        private void btnInsertNode_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInsertNode.Text, out int value))
            {
                binaryTree.Insert(value);
                txtInsertNode.Clear();
                treePanel.Invalidate(); // Redibuja el panel
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnDeleteNode_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDeleteNode.Text, out int value))
            {
                binaryTree.Delete(value);
                txtDeleteNode.Clear();
                treePanel.Invalidate(); // Redibuja el panel
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void treePanel_Paint(object sender, PaintEventArgs e)
        {
            if (binaryTree.Root != null)
            {
                DrawNode(e.Graphics, binaryTree.Root, treePanel.Width / 2, 20, 100);
            }
        }

        private void DrawNode(Graphics g, Node node, int x, int y, int offset)
        {
            if (node == null) return;

            // Dibuja el nodo actual
            g.FillEllipse(Brushes.Blue, x - 15, y - 15, 30, 30);
            g.DrawString(node.Data.ToString(), this.Font, Brushes.White, x - 10, y - 10);

            // Dibuja el nodo izquierdo
            if (node.Left != null)
            {
                g.DrawLine(Pens.Black, x, y, x - offset, y + 50);
                DrawNode(g, node.Left, x - offset, y + 50, offset / 2);
            }

            // Dibuja el nodo derecho
            if (node.Right != null)
            {
                g.DrawLine(Pens.Black, x, y, x + offset, y + 50);
                DrawNode(g, node.Right, x + offset, y + 50, offset / 2);
            }
        }
    }
}
