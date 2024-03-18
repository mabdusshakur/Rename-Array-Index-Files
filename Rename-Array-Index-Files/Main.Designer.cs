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
            this.startNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // selectFiles
            // 
            this.selectFiles.FileName = "selectFiles";
            // 
            // selectFiles_btn
            // 
            this.selectFiles_btn.Location = new System.Drawing.Point(15, 50);
            this.selectFiles_btn.Name = "selectFiles_btn";
            this.selectFiles_btn.Size = new System.Drawing.Size(215, 38);
            this.selectFiles_btn.TabIndex = 0;
            this.selectFiles_btn.Text = "SelectFiles";
            this.selectFiles_btn.UseVisualStyleBackColor = true;
            this.selectFiles_btn.Click += new System.EventHandler(this.selectFiles_btn_Click);
            // 
            // startNumber
            // 
            this.startNumber.Location = new System.Drawing.Point(110, 9);
            this.startNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.startNumber.Name = "startNumber";
            this.startNumber.Size = new System.Drawing.Size(120, 20);
            this.startNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Starting Number : ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 96);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startNumber);
            this.Controls.Add(this.selectFiles_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Rename-Files-In-Array";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog selectFiles;
        private System.Windows.Forms.Button selectFiles_btn;
        private System.Windows.Forms.NumericUpDown startNumber;
        private System.Windows.Forms.Label label1;
    }
}

