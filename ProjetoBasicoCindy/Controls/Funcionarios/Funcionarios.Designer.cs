namespace ProjetoBasicoCindy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionarios));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDoc = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listviewDocuments = new System.Windows.Forms.ListView();
            this.btNewPic = new System.Windows.Forms.Button();
            this.panelUploadControl = new System.Windows.Forms.Panel();
            this.tabFerias = new System.Windows.Forms.TabPage();
            this.tabVacinas = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Vacina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataVacina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proximaVacina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabExames = new System.Windows.Forms.TabPage();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabVacinas.SuspendLayout();
            this.tabInfo.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInfo);
            this.tabControl1.Controls.Add(this.tabDoc);
            this.tabControl1.Controls.Add(this.tabFerias);
            this.tabControl1.Controls.Add(this.tabVacinas);
            this.tabControl1.Controls.Add(this.tabExames);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(295, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 601);
            this.tabControl1.TabIndex = 1;
            // 
            // tabDoc
            // 
            this.tabDoc.Controls.Add(this.pictureBox2);
            this.tabDoc.Controls.Add(this.button3);
            this.tabDoc.Controls.Add(this.listviewDocuments);
            this.tabDoc.Controls.Add(this.btNewPic);
            this.tabDoc.Controls.Add(this.panelUploadControl);
            this.tabDoc.Location = new System.Drawing.Point(4, 22);
            this.tabDoc.Name = "tabDoc";
            this.tabDoc.Size = new System.Drawing.Size(779, 575);
            this.tabDoc.TabIndex = 3;
            this.tabDoc.Text = "Documentos";
            this.tabDoc.UseVisualStyleBackColor = true;
            this.tabDoc.Click += new System.EventHandler(this.tabDoc_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(463, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(316, 384);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(193, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Excluir";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listviewDocuments
            // 
            this.listviewDocuments.Location = new System.Drawing.Point(22, 17);
            this.listviewDocuments.Name = "listviewDocuments";
            this.listviewDocuments.Size = new System.Drawing.Size(165, 370);
            this.listviewDocuments.TabIndex = 1;
            this.listviewDocuments.UseCompatibleStateImageBehavior = false;
            // 
            // btNewPic
            // 
            this.btNewPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewPic.Image = ((System.Drawing.Image)(resources.GetObject("btNewPic.Image")));
            this.btNewPic.Location = new System.Drawing.Point(193, 17);
            this.btNewPic.Name = "btNewPic";
            this.btNewPic.Size = new System.Drawing.Size(103, 35);
            this.btNewPic.TabIndex = 0;
            this.btNewPic.Text = "Upload";
            this.btNewPic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNewPic.UseCompatibleTextRendering = true;
            this.btNewPic.UseVisualStyleBackColor = true;
            this.btNewPic.Click += new System.EventHandler(this.btNewPic_Click);
            // 
            // panelUploadControl
            // 
            this.panelUploadControl.BackColor = System.Drawing.Color.Transparent;
            this.panelUploadControl.Location = new System.Drawing.Point(151, 140);
            this.panelUploadControl.Name = "panelUploadControl";
            this.panelUploadControl.Size = new System.Drawing.Size(628, 435);
            this.panelUploadControl.TabIndex = 4;
            this.panelUploadControl.Visible = false;
            // 
            // tabFerias
            // 
            this.tabFerias.Location = new System.Drawing.Point(4, 22);
            this.tabFerias.Name = "tabFerias";
            this.tabFerias.Padding = new System.Windows.Forms.Padding(3);
            this.tabFerias.Size = new System.Drawing.Size(779, 575);
            this.tabFerias.TabIndex = 1;
            this.tabFerias.Text = "Ferias";
            this.tabFerias.UseVisualStyleBackColor = true;
            // 
            // tabVacinas
            // 
            this.tabVacinas.Controls.Add(this.listView2);
            this.tabVacinas.Location = new System.Drawing.Point(4, 22);
            this.tabVacinas.Name = "tabVacinas";
            this.tabVacinas.Size = new System.Drawing.Size(779, 575);
            this.tabVacinas.TabIndex = 2;
            this.tabVacinas.Text = "Vacinação";
            this.tabVacinas.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Vacina,
            this.DataVacina,
            this.proximaVacina});
            this.listView2.Location = new System.Drawing.Point(4, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(679, 381);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // DataVacina
            // 
            this.DataVacina.Text = "Data Vacina";
            // 
            // proximaVacina
            // 
            this.proximaVacina.Text = "Proxima Vacina";
            // 
            // tabExames
            // 
            this.tabExames.Location = new System.Drawing.Point(4, 22);
            this.tabExames.Name = "tabExames";
            this.tabExames.Size = new System.Drawing.Size(779, 575);
            this.tabExames.TabIndex = 4;
            this.tabExames.Text = "Exames";
            this.tabExames.UseVisualStyleBackColor = true;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.panelInfo);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(779, 575);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "Informações";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // panelInfo
            // 
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(3, 3);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(773, 569);
            this.panelInfo.TabIndex = 0;
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBox1);
            this.Name = "Funcionarios";
            this.Size = new System.Drawing.Size(1082, 601);
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabVacinas.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFerias;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage tabVacinas;
        private System.Windows.Forms.TabPage tabExames;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader Vacina;
        private System.Windows.Forms.ColumnHeader DataVacina;
        private System.Windows.Forms.ColumnHeader proximaVacina;
        private System.Windows.Forms.TabPage tabDoc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listviewDocuments;
        private System.Windows.Forms.Button btNewPic;
        public System.Windows.Forms.Panel panelUploadControl;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.Panel panelInfo;
    }

}
