namespace Separacao_de_Materiais.Forms
{
    partial class FrmErase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            gbOP = new GroupBox();
            gridErase = new DataGridView();
            c1 = new DataGridViewCheckBoxColumn();
            c2 = new DataGridViewTextBoxColumn();
            c3 = new DataGridViewTextBoxColumn();
            c4 = new DataGridViewTextBoxColumn();
            btnApagar = new Button();
            rbGrupo = new RadioButton();
            rbOP = new RadioButton();
            rbItens = new RadioButton();
            gbOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridErase).BeginInit();
            SuspendLayout();
            // 
            // gbOP
            // 
            gbOP.Controls.Add(gridErase);
            gbOP.Controls.Add(btnApagar);
            gbOP.Controls.Add(rbGrupo);
            gbOP.Controls.Add(rbOP);
            gbOP.Controls.Add(rbItens);
            gbOP.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbOP.ForeColor = Color.Snow;
            gbOP.Location = new Point(6, 12);
            gbOP.Name = "gbOP";
            gbOP.Size = new Size(518, 300);
            gbOP.TabIndex = 0;
            gbOP.TabStop = false;
            gbOP.Text = "O que deseja apagar da OP:";
            // 
            // gridErase
            // 
            gridErase.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(66, 66, 66);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(228, 117, 22);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 117, 22);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridErase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridErase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridErase.Columns.AddRange(new DataGridViewColumn[] { c1, c2, c3, c4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Snow;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(66, 66, 66);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridErase.DefaultCellStyle = dataGridViewCellStyle2;
            gridErase.EnableHeadersVisualStyles = false;
            gridErase.Location = new Point(6, 52);
            gridErase.Name = "gridErase";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridErase.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridErase.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.Snow;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(227, 119, 28);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(66, 66, 66);
            gridErase.RowsDefaultCellStyle = dataGridViewCellStyle4;
            gridErase.Size = new Size(505, 173);
            gridErase.TabIndex = 1;
            // 
            // c1
            // 
            c1.HeaderText = "Check:";
            c1.Name = "c1";
            c1.Width = 50;
            // 
            // c2
            // 
            c2.HeaderText = "Grupo:";
            c2.Name = "c2";
            c2.ReadOnly = true;
            // 
            // c3
            // 
            c3.HeaderText = "Descrição:";
            c3.Name = "c3";
            c3.ReadOnly = true;
            // 
            // c4
            // 
            c4.HeaderText = "QTD:";
            c4.Name = "c4";
            c4.ReadOnly = true;
            c4.Width = 50;
            // 
            // btnApagar
            // 
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Location = new Point(171, 244);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(191, 38);
            btnApagar.TabIndex = 4;
            btnApagar.Text = "APAGAR";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // rbGrupo
            // 
            rbGrupo.AutoSize = true;
            rbGrupo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbGrupo.Location = new Point(145, 26);
            rbGrupo.Name = "rbGrupo";
            rbGrupo.Size = new Size(163, 20);
            rbGrupo.TabIndex = 3;
            rbGrupo.TabStop = true;
            rbGrupo.Text = "Apagar Grupos da OP";
            rbGrupo.UseVisualStyleBackColor = true;
            rbGrupo.CheckedChanged += rbGrupo_CheckedChanged;
            // 
            // rbOP
            // 
            rbOP.AutoSize = true;
            rbOP.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbOP.Location = new Point(6, 26);
            rbOP.Name = "rbOP";
            rbOP.Size = new Size(133, 20);
            rbOP.TabIndex = 1;
            rbOP.TabStop = true;
            rbOP.Text = "Apagar Toda  OP";
            rbOP.UseVisualStyleBackColor = true;
            rbOP.CheckedChanged += rbOP_CheckedChanged;
            // 
            // rbItens
            // 
            rbItens.AutoSize = true;
            rbItens.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbItens.Location = new Point(314, 26);
            rbItens.Name = "rbItens";
            rbItens.Size = new Size(152, 20);
            rbItens.TabIndex = 0;
            rbItens.TabStop = true;
            rbItens.Text = "Apagar Itens da OP";
            rbItens.UseVisualStyleBackColor = true;
            rbItens.CheckedChanged += rbItens_CheckedChanged;
            // 
            // FrmErase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(529, 320);
            Controls.Add(gbOP);
            Name = "FrmErase";
            Text = "FrmErase";
            Load += FrmErase_Load;
            gbOP.ResumeLayout(false);
            gbOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridErase).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbOP;
        private RadioButton rbOP;
        private RadioButton rbItens;
        private Button btnApagar;
        private RadioButton rbGrupo;
        private DataGridView gridErase;
        private DataGridViewCheckBoxColumn c1;
        private DataGridViewTextBoxColumn c2;
        private DataGridViewTextBoxColumn c3;
        private DataGridViewTextBoxColumn c4;
    }
}