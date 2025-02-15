namespace AtidadeEliasCRUD.Formularios
{
    partial class TelaIncial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaIncial));
            btPesquisar = new Button();
            textBox1 = new TextBox();
            btADD = new Button();
            button1 = new Button();
            btExcluir = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btPesquisar
            // 
            btPesquisar.BackColor = Color.Silver;
            btPesquisar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPesquisar.Image = Properties.Resources.lupa1;
            btPesquisar.ImageAlign = ContentAlignment.MiddleRight;
            btPesquisar.Location = new Point(615, 51);
            btPesquisar.Name = "btPesquisar";
            btPesquisar.Size = new Size(97, 32);
            btPesquisar.TabIndex = 0;
            btPesquisar.Text = "Pesquisar";
            btPesquisar.TextAlign = ContentAlignment.MiddleLeft;
            btPesquisar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(466, 23);
            textBox1.TabIndex = 1;
            // 
            // btADD
            // 
            btADD.AutoSize = true;
            btADD.BackColor = Color.FromArgb(0, 192, 0);
            btADD.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btADD.ForeColor = SystemColors.Control;
            btADD.ImageAlign = ContentAlignment.MiddleLeft;
            btADD.Location = new Point(615, 89);
            btADD.Name = "btADD";
            btADD.Size = new Size(90, 36);
            btADD.TabIndex = 26;
            btADD.Text = "Adicionar";
            btADD.TextAlign = ContentAlignment.MiddleRight;
            btADD.UseVisualStyleBackColor = false;
            btADD.Click += btADD_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(615, 131);
            button1.Name = "button1";
            button1.Size = new Size(90, 36);
            button1.TabIndex = 28;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            // 
            // btExcluir
            // 
            btExcluir.AutoSize = true;
            btExcluir.BackColor = Color.Red;
            btExcluir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btExcluir.ForeColor = SystemColors.Control;
            btExcluir.Image = (Image)resources.GetObject("btExcluir.Image");
            btExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btExcluir.Location = new Point(614, 173);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(91, 36);
            btExcluir.TabIndex = 29;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new Point(142, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(467, 274);
            dataGridView1.TabIndex = 30;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // TelaIncial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btExcluir);
            Controls.Add(button1);
            Controls.Add(btADD);
            Controls.Add(textBox1);
            Controls.Add(btPesquisar);
            Name = "TelaIncial";
            Text = "TelaIncial";
            Load += TelaIncial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btPesquisar;
        private TextBox textBox1;
        private Button btADD;
        private Button button1;
        private Button btExcluir;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
    }
}