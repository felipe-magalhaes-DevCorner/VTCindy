namespace ProjetoBasicoCindy.Controls.Funcionarios
{
    partial class Funcionarios
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionarios));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.txtdn = new System.Windows.Forms.TextBox();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.txtxnumero = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Complemento = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mskcpf = new System.Windows.Forms.MaskedTextBox();
            this.mskcep = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 601);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(304, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(220, 116);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sexo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de Nascimento: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rua: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(857, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nº: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Bairro: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(668, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cidade: ";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(530, 17);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(309, 20);
            this.txtnome.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtsexo
            // 
            this.txtsexo.Location = new System.Drawing.Point(530, 67);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(96, 20);
            this.txtsexo.TabIndex = 14;
            // 
            // txtdn
            // 
            this.txtdn.Location = new System.Drawing.Point(754, 41);
            this.txtdn.Name = "txtdn";
            this.txtdn.Size = new System.Drawing.Size(85, 20);
            this.txtdn.TabIndex = 15;
            // 
            // txtrua
            // 
            this.txtrua.Location = new System.Drawing.Point(530, 99);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(321, 20);
            this.txtrua.TabIndex = 16;
            // 
            // txtxnumero
            // 
            this.txtxnumero.Location = new System.Drawing.Point(888, 99);
            this.txtxnumero.Name = "txtxnumero";
            this.txtxnumero.Size = new System.Drawing.Size(35, 20);
            this.txtxnumero.TabIndex = 17;
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(530, 136);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(110, 20);
            this.txtbairro.TabIndex = 18;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(720, 136);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(144, 20);
            this.txtcidade.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Estado: ";
            // 
            // Complemento
            // 
            this.Complemento.AutoSize = true;
            this.Complemento.Location = new System.Drawing.Point(591, 184);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(74, 13);
            this.Complemento.TabIndex = 21;
            this.Complemento.Text = "Complemento:";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(538, 181);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(42, 20);
            this.txtestado.TabIndex = 22;
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(671, 181);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(168, 20);
            this.txtcomplemento.TabIndex = 23;
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(671, 234);
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(239, 20);
            this.txtobs.TabIndex = 24;
            this.txtobs.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(591, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Observação: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(869, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "CEP:";
            // 
            // mskcpf
            // 
            this.mskcpf.Location = new System.Drawing.Point(530, 41);
            this.mskcpf.Mask = "999.999.999-99";
            this.mskcpf.Name = "mskcpf";
            this.mskcpf.Size = new System.Drawing.Size(100, 20);
            this.mskcpf.TabIndex = 28;
            // 
            // mskcep
            // 
            this.mskcep.Location = new System.Drawing.Point(906, 177);
            this.mskcep.Mask = "99.999-999";
            this.mskcep.Name = "mskcep";
            this.mskcep.Size = new System.Drawing.Size(100, 20);
            this.mskcep.TabIndex = 29;
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mskcep);
            this.Controls.Add(this.mskcpf);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.txtcomplemento);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.Complemento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.txtxnumero);
            this.Controls.Add(this.txtrua);
            this.Controls.Add(this.txtdn);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Funcionarios";
            this.Size = new System.Drawing.Size(1082, 601);
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtsexo;
        private System.Windows.Forms.TextBox txtdn;
        private System.Windows.Forms.TextBox txtrua;
        private System.Windows.Forms.TextBox txtxnumero;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Complemento;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskcpf;
        private System.Windows.Forms.MaskedTextBox mskcep;
    }
}
