namespace ProjetoBasicoCindy
{
    partial class CropController
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
            this.BtnCrop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TargetPicBox = new System.Windows.Forms.PictureBox();
            this.tbCordinates = new System.Windows.Forms.TextBox();
            this.chkCropCordinates = new System.Windows.Forms.CheckBox();
            this.lbCordinates = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SrcPicBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TargetPicBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SrcPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCrop
            // 
            this.BtnCrop.Location = new System.Drawing.Point(459, 46);
            this.BtnCrop.Name = "BtnCrop";
            this.BtnCrop.Size = new System.Drawing.Size(87, 24);
            this.BtnCrop.TabIndex = 3;
            this.BtnCrop.Text = "Crop";
            this.BtnCrop.UseVisualStyleBackColor = true;
            this.BtnCrop.Click += new System.EventHandler(this.BtnCrop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TargetPicBox
            // 
            this.TargetPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TargetPicBox.Location = new System.Drawing.Point(387, 183);
            this.TargetPicBox.Name = "TargetPicBox";
            this.TargetPicBox.Size = new System.Drawing.Size(250, 250);
            this.TargetPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TargetPicBox.TabIndex = 5;
            this.TargetPicBox.TabStop = false;
            // 
            // tbCordinates
            // 
            this.tbCordinates.Location = new System.Drawing.Point(387, 153);
            this.tbCordinates.Name = "tbCordinates";
            this.tbCordinates.Size = new System.Drawing.Size(140, 20);
            this.tbCordinates.TabIndex = 10;
            this.tbCordinates.Visible = false;
            // 
            // chkCropCordinates
            // 
            this.chkCropCordinates.AutoSize = true;
            this.chkCropCordinates.Location = new System.Drawing.Point(387, 116);
            this.chkCropCordinates.Name = "chkCropCordinates";
            this.chkCropCordinates.Size = new System.Drawing.Size(202, 17);
            this.chkCropCordinates.TabIndex = 9;
            this.chkCropCordinates.Text = "Crop using coordinates ( x1,y1,x2,y2 )";
            this.chkCropCordinates.UseVisualStyleBackColor = true;
            // 
            // lbCordinates
            // 
            this.lbCordinates.AutoSize = true;
            this.lbCordinates.Location = new System.Drawing.Point(384, 89);
            this.lbCordinates.Name = "lbCordinates";
            this.lbCordinates.Size = new System.Drawing.Size(66, 13);
            this.lbCordinates.TabIndex = 8;
            this.lbCordinates.Text = "Coordinates:";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(614, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(20, 20);
            this.button5.TabIndex = 11;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.SrcPicBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 465);
            this.panel1.TabIndex = 12;
            // 
            // SrcPicBox
            // 
            this.SrcPicBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.SrcPicBox.Location = new System.Drawing.Point(0, 0);
            this.SrcPicBox.Name = "SrcPicBox";
            this.SrcPicBox.Size = new System.Drawing.Size(355, 382);
            this.SrcPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SrcPicBox.TabIndex = 2;
            this.SrcPicBox.TabStop = false;
            this.SrcPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.SrcPicBox_Paint);
            this.SrcPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SrcPicBox_MouseDown);
            this.SrcPicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SrcPicBox_MouseMove);
            this.SrcPicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SrcPicBox_MouseUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 24);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CropController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tbCordinates);
            this.Controls.Add(this.chkCropCordinates);
            this.Controls.Add(this.lbCordinates);
            this.Controls.Add(this.TargetPicBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCrop);
            this.Name = "CropController";
            this.Size = new System.Drawing.Size(637, 465);
            ((System.ComponentModel.ISupportInitialize)(this.TargetPicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SrcPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCrop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox TargetPicBox;
        private System.Windows.Forms.TextBox tbCordinates;
        private System.Windows.Forms.CheckBox chkCropCordinates;
        private System.Windows.Forms.Label lbCordinates;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox SrcPicBox;
        private System.Windows.Forms.Button button2;
    }
}
