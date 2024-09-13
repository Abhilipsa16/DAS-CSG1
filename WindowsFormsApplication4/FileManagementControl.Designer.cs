namespace WindowsFormsApplication4
{
    partial class FileManagementControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManagementControl));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_newFile = new System.Windows.Forms.Button();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.newFileControl1 = new WindowsFormsApplication4.NewFileControl();
            this.fileSidepanel = new System.Windows.Forms.Panel();
            this.openFileControl1 = new WindowsFormsApplication4.OpenFileControl();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(44, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(832, 51);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "File Management";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_newFile
            // 
            this.btn_newFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_newFile.FlatAppearance.BorderSize = 0;
            this.btn_newFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newFile.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newFile.ForeColor = System.Drawing.Color.Transparent;
            this.btn_newFile.Image = ((System.Drawing.Image)(resources.GetObject("btn_newFile.Image")));
            this.btn_newFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newFile.Location = new System.Drawing.Point(44, 132);
            this.btn_newFile.Name = "btn_newFile";
            this.btn_newFile.Size = new System.Drawing.Size(152, 56);
            this.btn_newFile.TabIndex = 3;
            this.btn_newFile.Text = "  NEW FILE";
            this.btn_newFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_newFile.UseVisualStyleBackColor = false;
            this.btn_newFile.Click += new System.EventHandler(this.btn_newFile_Click);
            // 
            // btn_openFile
            // 
            this.btn_openFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_openFile.FlatAppearance.BorderSize = 0;
            this.btn_openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openFile.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openFile.ForeColor = System.Drawing.Color.Transparent;
            this.btn_openFile.Image = ((System.Drawing.Image)(resources.GetObject("btn_openFile.Image")));
            this.btn_openFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_openFile.Location = new System.Drawing.Point(44, 209);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(152, 61);
            this.btn_openFile.TabIndex = 3;
            this.btn_openFile.Text = "  OPEN FILE";
            this.btn_openFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_openFile.UseVisualStyleBackColor = false;
            this.btn_openFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // newFileControl1
            // 
            this.newFileControl1.BackColor = System.Drawing.Color.Gray;
            this.newFileControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newFileControl1.ForeColor = System.Drawing.Color.White;
            this.newFileControl1.Location = new System.Drawing.Point(236, 121);
            this.newFileControl1.Name = "newFileControl1";
            this.newFileControl1.Size = new System.Drawing.Size(640, 172);
            this.newFileControl1.TabIndex = 4;
            // 
            // fileSidepanel
            // 
            this.fileSidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fileSidepanel.Location = new System.Drawing.Point(13, 133);
            this.fileSidepanel.Name = "fileSidepanel";
            this.fileSidepanel.Size = new System.Drawing.Size(10, 55);
            this.fileSidepanel.TabIndex = 5;
            // 
            // openFileControl1
            // 
            this.openFileControl1.BackColor = System.Drawing.Color.Gray;
            this.openFileControl1.Location = new System.Drawing.Point(236, 121);
            this.openFileControl1.Name = "openFileControl1";
            this.openFileControl1.Size = new System.Drawing.Size(642, 174);
            this.openFileControl1.TabIndex = 6;
            // 
            // FileManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.openFileControl1);
            this.Controls.Add(this.fileSidepanel);
            this.Controls.Add(this.newFileControl1);
            this.Controls.Add(this.btn_openFile);
            this.Controls.Add(this.btn_newFile);
            this.Controls.Add(this.textBox1);
            this.Name = "FileManagementControl";
            this.Size = new System.Drawing.Size(919, 345);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_newFile;
        private System.Windows.Forms.Button btn_openFile;
        private NewFileControl newFileControl1;
        private System.Windows.Forms.Panel fileSidepanel;
        private OpenFileControl openFileControl1;

    }
}
