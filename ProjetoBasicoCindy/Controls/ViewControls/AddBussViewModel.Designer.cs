namespace ProjetoBasicoCindy
{
    partial class AddBussViewModel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTXTobs = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btAddBus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.Cartão = new System.Windows.Forms.Label();
            this.cbCartao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLinhas = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.richTXTobs);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btAddBus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.Cartão);
            this.groupBox1.Controls.Add(this.cbCartao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbLinhas);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Onibus";
            // 
            // richTXTobs
            // 
            this.richTXTobs.Location = new System.Drawing.Point(154, 26);
            this.richTXTobs.Name = "richTXTobs";
            this.richTXTobs.Size = new System.Drawing.Size(142, 121);
            this.richTXTobs.TabIndex = 8;
            this.richTXTobs.Text = "Observação";
            this.richTXTobs.Click += new System.EventHandler(this.richTXTobs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btAddBus
            // 
            this.btAddBus.Location = new System.Drawing.Point(190, 153);
            this.btAddBus.Name = "btAddBus";
            this.btAddBus.Size = new System.Drawing.Size(50, 25);
            this.btAddBus.TabIndex = 6;
            this.btAddBus.Text = "Ok";
            this.btAddBus.UseVisualStyleBackColor = true;
            this.btAddBus.Click += new System.EventHandler(this.btAddBus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(58, 85);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(73, 20);
            this.txtPreco.TabIndex = 4;
            // 
            // Cartão
            // 
            this.Cartão.AutoSize = true;
            this.Cartão.Location = new System.Drawing.Point(16, 58);
            this.Cartão.Name = "Cartão";
            this.Cartão.Size = new System.Drawing.Size(36, 13);
            this.Cartão.TabIndex = 3;
            this.Cartão.Text = "Linha:";
            // 
            // cbCartao
            // 
            this.cbCartao.FormattingEnabled = true;
            this.cbCartao.Location = new System.Drawing.Point(58, 55);
            this.cbCartao.Name = "cbCartao";
            this.cbCartao.Size = new System.Drawing.Size(73, 21);
            this.cbCartao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Linha:";
            // 
            // cbLinhas
            // 
            this.cbLinhas.FormattingEnabled = true;
            this.cbLinhas.Location = new System.Drawing.Point(58, 23);
            this.cbLinhas.Name = "cbLinhas";
            this.cbLinhas.Size = new System.Drawing.Size(73, 21);
            this.cbLinhas.TabIndex = 0;
            // 
            // AddBussViewModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "AddBussViewModel";
            this.Size = new System.Drawing.Size(315, 200);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label Cartão;
        private System.Windows.Forms.ComboBox cbCartao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLinhas;
        private System.Windows.Forms.Button btAddBus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTXTobs;
    }
}
