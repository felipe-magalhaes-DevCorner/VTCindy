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
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
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
            // btEdit
            // 
            this.btEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btEdit.FlatAppearance.BorderSize = 0;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEdit.Location = new System.Drawing.Point(60, 0);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(60, 60);
            this.btEdit.TabIndex = 5;
            this.btEdit.Text = "Editar";
            this.btEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btDelete.FlatAppearance.BorderSize = 0;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDelete.Location = new System.Drawing.Point(120, 0);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(60, 60);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Excluir";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btlimpar
            // 
            this.btlimpar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btlimpar.FlatAppearance.BorderSize = 0;
            this.btlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlimpar.ForeColor = System.Drawing.Color.White;
            this.btlimpar.Image = ((System.Drawing.Image)(resources.GetObject("btlimpar.Image")));
            this.btlimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btlimpar.Location = new System.Drawing.Point(180, 0);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(60, 60);
            this.btlimpar.TabIndex = 7;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btlimpar.UseVisualStyleBackColor = true;
            // 
            // ButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btSave);
            this.Name = "ButtonControl";
            this.Size = new System.Drawing.Size(382, 60);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btSave;
        public System.Windows.Forms.Button btEdit;
        public System.Windows.Forms.Button btDelete;
        public System.Windows.Forms.Button btlimpar;
    }
}
