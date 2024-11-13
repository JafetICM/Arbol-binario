namespace ArbolBinarioApp
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox txtInsertNode;
        private System.Windows.Forms.Button btnInsertNode;
        private System.Windows.Forms.TextBox txtDeleteNode;
        private System.Windows.Forms.Button btnDeleteNode;
        private System.Windows.Forms.Panel treePanel;

        private void InitializeComponent()
        {
            this.txtInsertNode = new System.Windows.Forms.TextBox();
            this.btnInsertNode = new System.Windows.Forms.Button();
            this.txtDeleteNode = new System.Windows.Forms.TextBox();
            this.btnDeleteNode = new System.Windows.Forms.Button();
            this.treePanel = new System.Windows.Forms.Panel();

            // TextBox para insertar nodo
            this.txtInsertNode.Location = new System.Drawing.Point(20, 20);
            this.txtInsertNode.Size = new System.Drawing.Size(100, 20);

            // Botón para insertar nodo
            this.btnInsertNode.Location = new System.Drawing.Point(130, 20);
            this.btnInsertNode.Size = new System.Drawing.Size(100, 23);
            this.btnInsertNode.Text = "Insertar Nodo";
            this.btnInsertNode.Click += new System.EventHandler(this.btnInsertNode_Click);

            // TextBox para eliminar nodo
            this.txtDeleteNode.Location = new System.Drawing.Point(20, 60);
            this.txtDeleteNode.Size = new System.Drawing.Size(100, 20);

            // Botón para eliminar nodo
            this.btnDeleteNode.Location = new System.Drawing.Point(130, 60);
            this.btnDeleteNode.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteNode.Text = "Eliminar Nodo";
            this.btnDeleteNode.Click += new System.EventHandler(this.btnDeleteNode_Click);

            // Panel para mostrar el árbol
            this.treePanel.Location = new System.Drawing.Point(20, 100);
            this.treePanel.Size = new System.Drawing.Size(500, 300);
            this.treePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.treePanel_Paint);

            // Configuración del formulario
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Text = "Simulador de Árbol Binario de Búsqueda";

            // Añadir controles al formulario
            this.Controls.Add(this.txtInsertNode);
            this.Controls.Add(this.btnInsertNode);
            this.Controls.Add(this.txtDeleteNode);
            this.Controls.Add(this.btnDeleteNode);
            this.Controls.Add(this.treePanel);
        }
    }
}
