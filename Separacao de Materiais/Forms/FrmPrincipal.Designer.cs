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
            SbtnImprimir = new Styles.Style_Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            treePedido = new TreeView();
            lblCli = new Label();
            lblPed = new Label();
            lblOP = new Label();
            printDialog1 = new PrintDialog();
            printMaterial = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            SpanelTree = new Styles.Style_Panel();
            style_Button2 = new Styles.Style_Button();
            SpanelInfo = new Styles.Style_Panel();
            StxtPedido = new Styles.Style_TextBox();
            SpanelGrid = new Styles.Style_Panel();
            SgridPedido = new Styles.Style_Grid();
            scl1 = new DataGridViewTextBoxColumn();
            scl2 = new DataGridViewTextBoxColumn();
            scl3 = new DataGridViewTextBoxColumn();
            scl4 = new DataGridViewTextBoxColumn();
            clVisu = new DataGridViewButtonColumn();
            clApag = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SpanelTree.SuspendLayout();
            SpanelInfo.SuspendLayout();
            SpanelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SgridPedido).BeginInit();
            SuspendLayout();
            // 
            // SbtnImprimir
            // 
            SbtnImprimir.Cursor = Cursors.Hand;
            SbtnImprimir.FlatAppearance.BorderColor = Color.White;
            SbtnImprimir.FlatAppearance.BorderSize = 0;
            SbtnImprimir.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 112, 40);
            SbtnImprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 112, 33);
            SbtnImprimir.FlatStyle = FlatStyle.Flat;
            SbtnImprimir.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SbtnImprimir.ForeColor = Color.Snow;
            SbtnImprimir.Image = (Image)resources.GetObject("SbtnImprimir.Image");
            SbtnImprimir.ImageAlign = ContentAlignment.MiddleRight;
            SbtnImprimir.Location = new Point(376, 14);
            SbtnImprimir.Name = "SbtnImprimir";
            SbtnImprimir.Size = new Size(194, 69);
            SbtnImprimir.TabIndex = 3;
            SbtnImprimir.Text = "Imprimir";
            SbtnImprimir.TextAlign = ContentAlignment.MiddleLeft;
            SbtnImprimir.UseVisualStyleBackColor = true;
            SbtnImprimir.Click += SbtnImprimir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Baldi;
            pictureBox1.Location = new Point(19, 14);
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
            label1.Location = new Point(177, 37);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 1;
            label1.Text = "Pedido:";
            // 
            // treePedido
            // 
            treePedido.BackColor = Color.FromArgb(88, 88, 88);
            treePedido.BorderStyle = BorderStyle.None;
            treePedido.Cursor = Cursors.Hand;
            treePedido.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            treePedido.ForeColor = Color.Snow;
            treePedido.Location = new Point(3, 107);
            treePedido.Name = "treePedido";
            treePedido.Size = new Size(408, 213);
            treePedido.TabIndex = 3;
            // 
            // lblCli
            // 
            lblCli.AutoSize = true;
            lblCli.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCli.ForeColor = Color.Snow;
            lblCli.Location = new Point(11, 85);
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
            lblPed.Location = new Point(11, 50);
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
            lblOP.Location = new Point(11, 13);
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
            // SpanelTree
            // 
            SpanelTree.BackColor = Color.FromArgb(88, 88, 88);
            SpanelTree.Controls.Add(treePedido);
            SpanelTree.Controls.Add(style_Button2);
            SpanelTree.Controls.Add(lblCli);
            SpanelTree.Controls.Add(lblPed);
            SpanelTree.Controls.Add(lblOP);
            SpanelTree.CornerRadius = 30;
            SpanelTree.Location = new Point(599, 118);
            SpanelTree.Name = "SpanelTree";
            SpanelTree.Size = new Size(414, 363);
            SpanelTree.TabIndex = 3;
            // 
            // style_Button2
            // 
            style_Button2.BackColor = Color.Firebrick;
            style_Button2.Cursor = Cursors.Hand;
            style_Button2.FlatAppearance.BorderSize = 0;
            style_Button2.FlatStyle = FlatStyle.Flat;
            style_Button2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            style_Button2.ForeColor = Color.Snow;
            style_Button2.Image = (Image)resources.GetObject("style_Button2.Image");
            style_Button2.ImageAlign = ContentAlignment.MiddleLeft;
            style_Button2.Location = new Point(3, 325);
            style_Button2.Name = "style_Button2";
            style_Button2.Size = new Size(81, 35);
            style_Button2.TabIndex = 0;
            style_Button2.Text = "Voltar";
            style_Button2.TextAlign = ContentAlignment.MiddleRight;
            style_Button2.UseVisualStyleBackColor = false;
            // 
            // SpanelInfo
            // 
            SpanelInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SpanelInfo.BackColor = Color.FromArgb(31, 31, 31);
            SpanelInfo.Controls.Add(StxtPedido);
            SpanelInfo.Controls.Add(SbtnImprimir);
            SpanelInfo.Controls.Add(pictureBox1);
            SpanelInfo.Controls.Add(label1);
            SpanelInfo.CornerRadius = 30;
            SpanelInfo.Location = new Point(12, 12);
            SpanelInfo.Name = "SpanelInfo";
            SpanelInfo.Size = new Size(998, 100);
            SpanelInfo.TabIndex = 4;
            // 
            // StxtPedido
            // 
            StxtPedido.BorderColor = Color.Gray;
            StxtPedido.BorderSize = 2;
            StxtPedido.BorderStyle = BorderStyle.FixedSingle;
            StxtPedido.CornerRadius = 15;
            StxtPedido.Cursor = Cursors.IBeam;
            StxtPedido.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StxtPedido.Location = new Point(254, 37);
            StxtPedido.Margin = new Padding(10);
            StxtPedido.Name = "StxtPedido";
            StxtPedido.Size = new Size(100, 23);
            StxtPedido.TabIndex = 4;
            StxtPedido.KeyDown += StxtPedido_KeyDown;
            // 
            // SpanelGrid
            // 
            SpanelGrid.BackColor = Color.FromArgb(88, 88, 88);
            SpanelGrid.Controls.Add(SgridPedido);
            SpanelGrid.CornerRadius = 30;
            SpanelGrid.Location = new Point(12, 118);
            SpanelGrid.Name = "SpanelGrid";
            SpanelGrid.Size = new Size(581, 363);
            SpanelGrid.TabIndex = 5;
            // 
            // SgridPedido
            // 
            SgridPedido.BackgroundColor = Color.Snow;
            SgridPedido.BorderColor = Color.Gray;
            SgridPedido.BorderSize = 2;
            SgridPedido.BorderStyle = BorderStyle.None;
            SgridPedido.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(66, 66, 66);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 112, 33);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            SgridPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            SgridPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SgridPedido.Columns.AddRange(new DataGridViewColumn[] { scl1, scl2, scl3, scl4, clVisu, clApag });
            SgridPedido.CornerRadius = 15;
            SgridPedido.Cursor = Cursors.Hand;
            SgridPedido.EnableHeadersVisualStyles = false;
            SgridPedido.Location = new Point(9, 13);
            SgridPedido.Name = "SgridPedido";
            SgridPedido.ReadOnly = true;
            SgridPedido.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.Snow;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(228, 112, 33);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(228, 112, 33);
            dataGridViewCellStyle2.SelectionForeColor = Color.Snow;
            SgridPedido.RowsDefaultCellStyle = dataGridViewCellStyle2;
            SgridPedido.Size = new Size(561, 336);
            SgridPedido.TabIndex = 6;
            SgridPedido.CellContentClick += SgridPedido_CellContentClick;
            // 
            // scl1
            // 
            scl1.HeaderText = "Nº:";
            scl1.Name = "scl1";
            scl1.ReadOnly = true;
            scl1.Width = 40;
            // 
            // scl2
            // 
            scl2.HeaderText = "Pedido:";
            scl2.Name = "scl2";
            scl2.ReadOnly = true;
            scl2.Width = 60;
            // 
            // scl3
            // 
            scl3.HeaderText = "OP:";
            scl3.Name = "scl3";
            scl3.ReadOnly = true;
            scl3.Width = 60;
            // 
            // scl4
            // 
            scl4.HeaderText = "Cliente";
            scl4.Name = "scl4";
            scl4.ReadOnly = true;
            scl4.Width = 220;
            // 
            // clVisu
            // 
            clVisu.FlatStyle = FlatStyle.Flat;
            clVisu.HeaderText = "Visulaizar:";
            clVisu.Name = "clVisu";
            clVisu.ReadOnly = true;
            clVisu.Width = 90;
            // 
            // clApag
            // 
            clApag.FlatStyle = FlatStyle.Flat;
            clApag.HeaderText = "Apagar:";
            clApag.Name = "clApag";
            clApag.ReadOnly = true;
            clApag.Width = 90;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 120, 120);
            ClientSize = new Size(1022, 490);
            Controls.Add(SpanelGrid);
            Controls.Add(SpanelInfo);
            Controls.Add(SpanelTree);
            Name = "FrmPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SpanelTree.ResumeLayout(false);
            SpanelTree.PerformLayout();
            SpanelInfo.ResumeLayout(false);
            SpanelInfo.PerformLayout();
            SpanelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SgridPedido).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblPed;
        private Label lblOP;
        private TreeView treePedido;
        private Label lblCli;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printMaterial;
        private PrintPreviewDialog printPreviewDialog1;
        private Styles.Style_Button SbtnImprimir;
        private Styles.Style_Panel SpanelTree;
        private Styles.Style_Button style_Button2;
        private Styles.Style_Panel SpanelInfo;
        private Styles.Style_Panel SpanelGrid;
        private Styles.Style_Grid SgridPedido;
        private DataGridViewTextBoxColumn scl1;
        private DataGridViewTextBoxColumn scl2;
        private DataGridViewTextBoxColumn scl3;
        private DataGridViewTextBoxColumn scl4;
        private DataGridViewButtonColumn clVisu;
        private DataGridViewButtonColumn clApag;
        private Styles.Style_TextBox StxtPedido;
    }
}
