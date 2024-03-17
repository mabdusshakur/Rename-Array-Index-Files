namespace Rename_Array_Index_Files
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectFiles = new System.Windows.Forms.OpenFileDialog();
            this.selectFiles_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectFiles
            // 
            this.selectFiles.FileName = "selectFiles";
            // 
            // selectFiles_btn
            // 
            this.selectFiles_btn.Location = new System.Drawing.Point(191, 106);
            this.selectFiles_btn.Name = "selectFiles_btn";
            this.selectFiles_btn.Size = new System.Drawing.Size(103, 38);
            this.selectFiles_btn.TabIndex = 0;
            this.selectFiles_btn.Text = "SelectFiles";
            this.selectFiles_btn.UseVisualStyleBackColor = true;
            this.selectFiles_btn.Click += new System.EventHandler(this.selectFiles_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 259);
            this.Controls.Add(this.selectFiles_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Rename-Files-In-Array";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog selectFiles;
        private System.Windows.Forms.Button selectFiles_btn;
    }
}

