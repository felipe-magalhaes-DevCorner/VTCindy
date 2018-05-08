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
            this.cbCartao = new System.Windows.Forms.ComboBox();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.richTXTobs = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btAddBus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCartao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbCartao);
            this.groupBox1.Controls.Add(this.txtLinha);
            this.groupBox1.Controls.Add(this.richTXTobs);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btAddBus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.lbCartao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Onibus";
            // 
            // cbCartao
            // 
            this.cbCartao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCartao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCartao.FormattingEnabled = true;
            this.cbCartao.Items.AddRange(new object[] {
            "BHTRANS",
            "OTIMO"});
            this.cbCartao.Location = new System.Drawing.Point(58, 55);
            this.cbCartao.MaxDropDownItems = 3;
            this.cbCartao.Name = "cbCartao";
            this.cbCartao.Size = new System.Drawing.Size(90, 21);
            this.cbCartao.TabIndex = 10;
            // 
            // txtLinha
            // 
            this.txtLinha.Location = new System.Drawing.Point(58, 23);
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(90, 20);
            this.txtLinha.TabIndex = 9;
            // 
            // richTXTobs
            // 
            this.richTXTobs.Location = new System.Drawing.Point(154, 26);
            this.richTXTobs.Name = "richTXTobs";
            this.richTXTobs.Size = new System.Drawing.Size(142, 79);
            this.richTXTobs.TabIndex = 8;
            this.richTXTobs.Text = "Observação";
            this.richTXTobs.Click += new System.EventHandler(this.richTXTobs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAddBus
            // 
            this.btAddBus.Location = new System.Drawing.Point(190, 111);
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
            // lbCartao
            // 
            this.lbCartao.AutoSize = true;
            this.lbCartao.Location = new System.Drawing.Point(16, 58);
            this.lbCartao.Name = "lbCartao";
            this.lbCartao.Size = new System.Drawing.Size(41, 13);
            this.lbCartao.TabIndex = 3;
            this.lbCartao.Text = "Cartão:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Linha:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(58, 85);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(90, 20);
            this.txtPreco.TabIndex = 4;
            // 
            // AddBussViewModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "AddBussViewModel";
            this.Size = new System.Drawing.Size(315, 160);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCartao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddBus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTXTobs;
        private System.Windows.Forms.TextBox txtLinha;
        private System.Windows.Forms.ComboBox cbCartao;
        private System.Windows.Forms.TextBox txtPreco;
    }
}
