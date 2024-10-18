namespace Separacao_de_Materiais
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnImprimir = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtPedido = new TextBox();
            panel2 = new Panel();
            gridMateriais = new DataGridView();
            clNumber = new DataGridViewTextBoxColumn();
            clPedido = new DataGridViewTextBoxColumn();
            clOP = new DataGridViewTextBoxColumn();
            clCliente = new DataGridViewTextBoxColumn();
            clVisualizar = new DataGridViewButtonColumn();
            clApagar = new DataGridViewButtonColumn();
            panelDescription = new Panel();
            btnVoltar = new Button();
            treePedido = new TreeView();
            lblCli = new Label();
            lblPed = new Label();
            lblOP = new Label();
            printDialog1 = new PrintDialog();
            printMaterial = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridMateriais).BeginInit();
            panelDescription.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 31, 31);
            panel1.Controls.Add(btnImprimir);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPedido);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 75);
            panel1.TabIndex = 0;
            // 
            // btnImprimir
            // 
            btnImprimir.FlatAppearance.BorderColor = Color.FromArgb(66, 66, 66);
            btnImprimir.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 112, 33);
            btnImprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(88, 88, 88);
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.Snow;
            btnImprimir.Image = (Image)resources.GetObject("btnImprimir.Image");
            btnImprimir.ImageAlign = ContentAlignment.MiddleRight;
            btnImprimir.Location = new Point(408, 0);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(183, 72);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.TextAlign = ContentAlignment.MiddleLeft;
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Baldi;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 72);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(158, 29);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 1;
            label1.Text = "Pedido:";
            // 
            // txtPedido
            // 
            txtPedido.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPedido.Location = new Point(235, 26);
            txtPedido.Name = "txtPedido";
            txtPedido.Size = new Size(100, 27);
            txtPedido.TabIndex = 0;
            txtPedido.KeyDown += txtPedido_KeyDown;
            // 
            // panel2
            // 
            panel2.Controls.Add(gridMateriais);
            panel2.Location = new Point(3, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 363);
            panel2.TabIndex = 1;
            // 
            // gridMateriais
            // 
            gridMateriais.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(66, 66, 66);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 112, 33);
            dataGridViewCellStyle1.SelectionForeColor = Color.Snow;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridMateriais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridMateriais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMateriais.Columns.AddRange(new DataGridViewColumn[] { clNumber, clPedido, clOP, clCliente, clVisualizar, clApagar });
            gridMateriais.EnableHeadersVisualStyles = false;
            gridMateriais.Location = new Point(3, 11);
            gridMateriais.Name = "gridMateriais";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 31, 31);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(228, 112, 33);
            dataGridViewCellStyle2.SelectionForeColor = Color.Snow;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridMateriais.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridMateriais.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.Snow;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(228, 112, 33);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(228, 112, 33);
            dataGridViewCellStyle3.SelectionForeColor = Color.Snow;
            gridMateriais.RowsDefaultCellStyle = dataGridViewCellStyle3;
            gridMateriais.Size = new Size(585, 349);
            gridMateriais.TabIndex = 0;
            gridMateriais.CellContentClick += gridMateriais_CellContentClick;
            // 
            // clNumber
            // 
            clNumber.HeaderText = "Nº:";
            clNumber.Name = "clNumber";
            clNumber.Width = 40;
            // 
            // clPedido
            // 
            clPedido.HeaderText = "Pedido:";
            clPedido.Name = "clPedido";
            clPedido.Width = 60;
            // 
            // clOP
            // 
            clOP.HeaderText = "OP:";
            clOP.Name = "clOP";
            clOP.Width = 60;
            // 
            // clCliente
            // 
            clCliente.HeaderText = "Cliente:";
            clCliente.Name = "clCliente";
            clCliente.Width = 220;
            // 
            // clVisualizar
            // 
            clVisualizar.FlatStyle = FlatStyle.Flat;
            clVisualizar.HeaderText = "Visualizar";
            clVisualizar.Name = "clVisualizar";
            // 
            // clApagar
            // 
            clApagar.FlatStyle = FlatStyle.Flat;
            clApagar.HeaderText = "Apagar";
            clApagar.Name = "clApagar";
            // 
            // panelDescription
            // 
            panelDescription.Controls.Add(btnVoltar);
            panelDescription.Controls.Add(treePedido);
            panelDescription.Controls.Add(lblCli);
            panelDescription.Controls.Add(lblPed);
            panelDescription.Controls.Add(lblOP);
            panelDescription.Location = new Point(599, 78);
            panelDescription.Name = "panelDescription";
            panelDescription.Size = new Size(414, 363);
            panelDescription.TabIndex = 2;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Firebrick;
            btnVoltar.FlatAppearance.BorderColor = Color.FromArgb(88, 88, 88);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.Snow;
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(3, 327);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(82, 33);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextAlign = ContentAlignment.MiddleRight;
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // treePedido
            // 
            treePedido.BackColor = Color.FromArgb(88, 88, 88);
            treePedido.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            treePedido.ForeColor = Color.Snow;
            treePedido.Location = new Point(0, 114);
            treePedido.Name = "treePedido";
            treePedido.Size = new Size(411, 213);
            treePedido.TabIndex = 3;
            // 
            // lblCli
            // 
            lblCli.AutoSize = true;
            lblCli.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCli.ForeColor = Color.Snow;
            lblCli.Location = new Point(12, 83);
            lblCli.Name = "lblCli";
            lblCli.Size = new Size(73, 19);
            lblCli.TabIndex = 2;
            lblCli.Text = "Cliente:";
            // 
            // lblPed
            // 
            lblPed.AutoSize = true;
            lblPed.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPed.ForeColor = Color.Snow;
            lblPed.Location = new Point(12, 48);
            lblPed.Name = "lblPed";
            lblPed.Size = new Size(71, 19);
            lblPed.TabIndex = 1;
            lblPed.Text = "Pedido:";
            // 
            // lblOP
            // 
            lblOP.AutoSize = true;
            lblOP.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOP.ForeColor = Color.Snow;
            lblOP.Location = new Point(12, 11);
            lblOP.Name = "lblOP";
            lblOP.Size = new Size(38, 19);
            lblOP.TabIndex = 0;
            lblOP.Text = "OP:";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printMaterial
            // 
            printMaterial.BeginPrint += printMaterial_BeginPrint;
            printMaterial.EndPrint += printMaterial_EndPrint;
            printMaterial.PrintPage += printMaterial_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(88, 88, 88);
            ClientSize = new Size(1025, 448);
            Controls.Add(panelDescription);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmPrincipal";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridMateriais).EndInit();
            panelDescription.ResumeLayout(false);
            panelDescription.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtPedido;
        private Panel panel2;
        private DataGridView gridMateriais;
        private Button btnImprimir;
        private Panel panelDescription;
        private Label lblPed;
        private Label lblOP;
        private TreeView treePedido;
        private Label lblCli;
        private Button btnVoltar;
        private DataGridViewTextBoxColumn clNumber;
        private DataGridViewTextBoxColumn clPedido;
        private DataGridViewTextBoxColumn clOP;
        private DataGridViewTextBoxColumn clCliente;
        private DataGridViewButtonColumn clVisualizar;
        private DataGridViewButtonColumn clApagar;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printMaterial;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
