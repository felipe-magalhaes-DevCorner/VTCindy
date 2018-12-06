namespace ProjetoBasicoCindy
{
    partial class ButtonControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonControl));
            this.btSave = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btNewFunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSave.Location = new System.Drawing.Point(0, 0);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(60, 60);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Salvar";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btlimpar.FlatAppearance.BorderSize = 0;
            this.btlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlimpar.ForeColor = System.Drawing.Color.White;
            this.btlimpar.Image = ((System.Drawing.Image)(resources.GetObject("btlimpar.Image")));
            this.btlimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btlimpar.Location = new System.Drawing.Point(60, 0);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(60, 60);
            this.btlimpar.TabIndex = 10;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btlimpar.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btEdit.FlatAppearance.BorderSize = 0;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEdit.Location = new System.Drawing.Point(120, 0);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(60, 60);
            this.btEdit.TabIndex = 11;
            this.btEdit.Text = "Editar";
            this.btEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btNewFunc
            // 
            this.btNewFunc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btNewFunc.FlatAppearance.BorderSize = 0;
            this.btNewFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewFunc.ForeColor = System.Drawing.Color.White;
            this.btNewFunc.Image = ((System.Drawing.Image)(resources.GetObject("btNewFunc.Image")));
            this.btNewFunc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btNewFunc.Location = new System.Drawing.Point(180, 0);
            this.btNewFunc.Name = "btNewFunc";
            this.btNewFunc.Size = new System.Drawing.Size(60, 60);
            this.btNewFunc.TabIndex = 12;
            this.btNewFunc.Text = "Novo";
            this.btNewFunc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btNewFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btNewFunc.UseVisualStyleBackColor = true;
            // 
            // ButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btNewFunc);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btSave);
            this.Name = "ButtonControl";
            this.Size = new System.Drawing.Size(279, 60);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btSave;
        public System.Windows.Forms.Button btlimpar;
        public System.Windows.Forms.Button btEdit;
        public System.Windows.Forms.Button btNewFunc;
    }
}
