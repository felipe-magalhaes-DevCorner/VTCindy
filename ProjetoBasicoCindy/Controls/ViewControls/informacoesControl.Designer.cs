namespace ProjetoBasicoCindy
{
    partial class informacoesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informacoesControl));
            this.mskDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtIdentidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkInativo = new System.Windows.Forms.CheckBox();
            this.btRemoveBus = new System.Windows.Forms.Button();
            this.btAddBus = new System.Windows.Forms.Button();
            this.rtxtObs = new System.Windows.Forms.RichTextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.mskcep = new System.Windows.Forms.MaskedTextBox();
            this.mskcpf = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.Complemento = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtxnumero = new System.Windows.Forms.TextBox();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelAddBus = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mskInativoData = new System.Windows.Forms.MaskedTextBox();
            this.lbinativo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskDataNasc
            // 
            this.mskDataNasc.Location = new System.Drawing.Point(485, 85);
            this.mskDataNasc.Mask = "99/99/9999";
            this.mskDataNasc.Name = "mskDataNasc";
            this.mskDataNasc.Size = new System.Drawing.Size(78, 20);
            this.mskDataNasc.TabIndex = 72;
            // 
            // txtIdentidade
            // 
            this.txtIdentidade.ForeColor = System.Drawing.Color.Red;
            this.txtIdentidade.Location = new System.Drawing.Point(502, 8);
            this.txtIdentidade.Name = "txtIdentidade";
            this.txtIdentidade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIdentidade.Size = new System.Drawing.Size(156, 20);
            this.txtIdentidade.TabIndex = 69;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(445, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 102;
            this.label13.Text = "Identidade:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.ForeColor = System.Drawing.Color.Red;
            this.txtMatricula.Location = new System.Drawing.Point(266, 8);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 101;
            this.label12.Text = "Mat:";
            // 
            // checkInativo
            // 
            this.checkInativo.AutoSize = true;
            this.checkInativo.Location = new System.Drawing.Point(444, 35);
            this.checkInativo.Name = "checkInativo";
            this.checkInativo.Size = new System.Drawing.Size(58, 17);
            this.checkInativo.TabIndex = 100;
            this.checkInativo.Text = "Inativo";
            this.checkInativo.UseVisualStyleBackColor = true;
            this.checkInativo.CheckedChanged += new System.EventHandler(this.checkInativo_CheckedChanged);
            // 
            // btRemoveBus
            // 
            this.btRemoveBus.FlatAppearance.BorderSize = 0;
            this.btRemoveBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveBus.Image = ((System.Drawing.Image)(resources.GetObject("btRemoveBus.Image")));
            this.btRemoveBus.Location = new System.Drawing.Point(246, 48);
            this.btRemoveBus.Name = "btRemoveBus";
            this.btRemoveBus.Size = new System.Drawing.Size(20, 20);
            this.btRemoveBus.TabIndex = 84;
            this.btRemoveBus.UseVisualStyleBackColor = true;
            this.btRemoveBus.Click += new System.EventHandler(this.btRemoveBus_Click);
            // 
            // btAddBus
            // 
            this.btAddBus.FlatAppearance.BorderSize = 0;
            this.btAddBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddBus.Image = ((System.Drawing.Image)(resources.GetObject("btAddBus.Image")));
            this.btAddBus.Location = new System.Drawing.Point(246, 22);
            this.btAddBus.Name = "btAddBus";
            this.btAddBus.Size = new System.Drawing.Size(20, 20);
            this.btAddBus.TabIndex = 83;
            this.btAddBus.UseVisualStyleBackColor = true;
            this.btAddBus.Click += new System.EventHandler(this.btAddBus_Click);
            // 
            // rtxtObs
            // 
            this.rtxtObs.Location = new System.Drawing.Point(222, 273);
            this.rtxtObs.Name = "rtxtObs";
            this.rtxtObs.Size = new System.Drawing.Size(436, 116);
            this.rtxtObs.TabIndex = 82;
            this.rtxtObs.Tag = "";
            this.rtxtObs.Text = "";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbEstado.Location = new System.Drawing.Point(266, 216);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(55, 21);
            this.cbEstado.TabIndex = 81;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(212, 114);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(52, 13);
            this.lbTelefone.TabIndex = 99;
            this.lbTelefone.Text = "Telefone:";
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(266, 111);
            this.mskTel.Mask = "(999) 99999-9999";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(100, 20);
            this.mskTel.TabIndex = 73;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(485, 111);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(55, 21);
            this.cbSexo.TabIndex = 74;
            // 
            // mskcep
            // 
            this.mskcep.Location = new System.Drawing.Point(266, 164);
            this.mskcep.Mask = "99.999-999";
            this.mskcep.Name = "mskcep";
            this.mskcep.Size = new System.Drawing.Size(100, 20);
            this.mskcep.TabIndex = 77;
            // 
            // mskcpf
            // 
            this.mskcpf.Location = new System.Drawing.Point(266, 85);
            this.mskcpf.Mask = "999.999.999-99";
            this.mskcpf.Name = "mskcpf";
            this.mskcpf.Size = new System.Drawing.Size(99, 20);
            this.mskcpf.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(233, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 98;
            this.label11.Text = "CEP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "Observação: ";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(444, 164);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(214, 20);
            this.txtcomplemento.TabIndex = 78;
            // 
            // Complemento
            // 
            this.Complemento.AutoSize = true;
            this.Complemento.Location = new System.Drawing.Point(371, 167);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(74, 13);
            this.Complemento.TabIndex = 96;
            this.Complemento.Text = "Complemento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 95;
            this.label9.Text = "Estado: ";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(430, 190);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(228, 20);
            this.txtcidade.TabIndex = 80;
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(266, 190);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(110, 20);
            this.txtbairro.TabIndex = 79;
            // 
            // txtxnumero
            // 
            this.txtxnumero.Location = new System.Drawing.Point(613, 138);
            this.txtxnumero.Name = "txtxnumero";
            this.txtxnumero.Size = new System.Drawing.Size(45, 20);
            this.txtxnumero.TabIndex = 76;
            // 
            // txtrua
            // 
            this.txtrua.Location = new System.Drawing.Point(266, 138);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(321, 20);
            this.txtrua.TabIndex = 75;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(266, 59);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(393, 20);
            this.txtnome.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 94;
            this.label8.Text = "Cidade: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "Bairro: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 92;
            this.label6.Text = "Nº: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Rua: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "Data de Nascimento: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Sexo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "CPF: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Nome: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // panelAddBus
            // 
            this.panelAddBus.Location = new System.Drawing.Point(266, 130);
            this.panelAddBus.Name = "panelAddBus";
            this.panelAddBus.Size = new System.Drawing.Size(315, 200);
            this.panelAddBus.TabIndex = 103;
            this.panelAddBus.VisibleChanged += new System.EventHandler(this.Label_VisibleChanged);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(6, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(232, 125);
            this.listView1.TabIndex = 104;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.btRemoveBus);
            this.groupBox1.Controls.Add(this.btAddBus);
            this.groupBox1.Location = new System.Drawing.Point(222, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 152);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Onibus";
            // 
            // mskAdmissao
            // 
            this.mskAdmissao.Location = new System.Drawing.Point(266, 33);
            this.mskAdmissao.Mask = "99/99/9999";
            this.mskAdmissao.Name = "mskAdmissao";
            this.mskAdmissao.Size = new System.Drawing.Size(78, 20);
            this.mskAdmissao.TabIndex = 106;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(212, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 107;
            this.label14.Text = "Admissão:";
            // 
            // mskInativoData
            // 
            this.mskInativoData.Location = new System.Drawing.Point(580, 34);
            this.mskInativoData.Mask = "99/99/9999";
            this.mskInativoData.Name = "mskInativoData";
            this.mskInativoData.Size = new System.Drawing.Size(78, 20);
            this.mskInativoData.TabIndex = 108;
            this.mskInativoData.Visible = false;
            // 
            // lbinativo
            // 
            this.lbinativo.AutoSize = true;
            this.lbinativo.Location = new System.Drawing.Point(518, 37);
            this.lbinativo.Name = "lbinativo";
            this.lbinativo.Size = new System.Drawing.Size(60, 13);
            this.lbinativo.TabIndex = 109;
            this.lbinativo.Text = "Inativação:";
            this.lbinativo.Visible = false;            
            // 
            // informacoesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mskInativoData);
            this.Controls.Add(this.lbinativo);
            this.Controls.Add(this.mskAdmissao);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mskDataNasc);
            this.Controls.Add(this.txtIdentidade);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkInativo);
            this.Controls.Add(this.rtxtObs);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.mskcep);
            this.Controls.Add(this.mskcpf);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtcomplemento);
            this.Controls.Add(this.Complemento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.txtxnumero);
            this.Controls.Add(this.txtrua);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelAddBus);
            this.Name = "informacoesControl";
            this.Size = new System.Drawing.Size(779, 575);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskDataNasc;
        private System.Windows.Forms.TextBox txtIdentidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkInativo;
        private System.Windows.Forms.Button btRemoveBus;
        private System.Windows.Forms.Button btAddBus;
        private System.Windows.Forms.RichTextBox rtxtObs;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.MaskedTextBox mskcep;
        private System.Windows.Forms.MaskedTextBox mskcpf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label Complemento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtxnumero;
        private System.Windows.Forms.TextBox txtrua;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelAddBus;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskAdmissao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mskInativoData;
        private System.Windows.Forms.Label lbinativo;
    }
}
