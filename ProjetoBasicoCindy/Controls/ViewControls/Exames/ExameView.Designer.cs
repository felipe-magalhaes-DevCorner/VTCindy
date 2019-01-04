namespace ProjetoBasicoCindy.Exames
{
    partial class Exame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelExansOK = new System.Windows.Forms.Panel();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.picOpen = new System.Windows.Forms.PictureBox();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelExansOK);
            this.panel1.Controls.Add(this.lbDescricao);
            this.panel1.Controls.Add(this.picOpen);
            this.panel1.Controls.Add(this.panelChild);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 30);
            this.panel1.TabIndex = 0;
            // 
            // panelExansOK
            // 
            this.panelExansOK.BackColor = System.Drawing.Color.Transparent;
            this.panelExansOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelExansOK.Location = new System.Drawing.Point(579, 0);
            this.panelExansOK.Name = "panelExansOK";
            this.panelExansOK.Size = new System.Drawing.Size(200, 30);
            this.panelExansOK.TabIndex = 3;
            // 
            // lbDescricao
            // 
            this.lbDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDescricao.Location = new System.Drawing.Point(52, 0);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(727, 30);
            this.lbDescricao.TabIndex = 2;
            this.lbDescricao.Text = "label1";
            this.lbDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDescricao.Click += new System.EventHandler(this.lbDescricao_Click);
            // 
            // picOpen
            // 
            this.picOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.picOpen.Location = new System.Drawing.Point(26, 0);
            this.picOpen.Name = "picOpen";
            this.picOpen.Size = new System.Drawing.Size(26, 30);
            this.picOpen.TabIndex = 1;
            this.picOpen.TabStop = false;
            this.picOpen.Tag = "arrowClosed";
            this.picOpen.Click += new System.EventHandler(this.PicOpen_Click);
            // 
            // panelChild
            // 
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChild.Location = new System.Drawing.Point(0, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(26, 30);
            this.panelChild.TabIndex = 0;
            this.panelChild.Visible = false;
            // 
            // Exame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "Exame";
            this.Size = new System.Drawing.Size(779, 30);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOpen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDescricao;
        public System.Windows.Forms.Panel panelChild;
        public System.Windows.Forms.PictureBox picOpen;
        public System.Windows.Forms.Panel panelExansOK;
    }
}
