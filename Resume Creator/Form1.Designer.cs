
namespace Resume_Creator
{
    partial class Form1
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.txtbxSelect = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.txtbxFilePath = new System.Windows.Forms.TextBox();
            this.buttonFilePath = new System.Windows.Forms.Button();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.selectFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFilePath = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(311, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(155, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Convert Your JSON File to PDF";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(656, 52);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(92, 35);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Select File";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(338, 203);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(92, 35);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert File";
            this.buttonConvert.UseVisualStyleBackColor = true;
            // 
            // txtbxSelect
            // 
            this.txtbxSelect.Location = new System.Drawing.Point(36, 52);
            this.txtbxSelect.Multiline = true;
            this.txtbxSelect.Name = "txtbxSelect";
            this.txtbxSelect.Size = new System.Drawing.Size(614, 35);
            this.txtbxSelect.TabIndex = 3;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(351, 90);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(54, 13);
            this.labelFileName.TabIndex = 4;
            this.labelFileName.Text = "File Name";
            // 
            // txtbxFilePath
            // 
            this.txtbxFilePath.Location = new System.Drawing.Point(36, 130);
            this.txtbxFilePath.Multiline = true;
            this.txtbxFilePath.Name = "txtbxFilePath";
            this.txtbxFilePath.Size = new System.Drawing.Size(614, 35);
            this.txtbxFilePath.TabIndex = 5;
            // 
            // buttonFilePath
            // 
            this.buttonFilePath.Location = new System.Drawing.Point(656, 130);
            this.buttonFilePath.Name = "buttonFilePath";
            this.buttonFilePath.Size = new System.Drawing.Size(92, 35);
            this.buttonFilePath.TabIndex = 6;
            this.buttonFilePath.Text = "Select Path";
            this.buttonFilePath.UseVisualStyleBackColor = true;
            this.buttonFilePath.Click += new System.EventHandler(this.buttonFilePath_Click);
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(351, 168);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(48, 13);
            this.labelFilePath.TabIndex = 7;
            this.labelFilePath.Text = "File Path";
            // 
            // selectFile
            // 
            this.selectFile.FileName = "SelectFile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 264);
            this.Controls.Add(this.labelFilePath);
            this.Controls.Add(this.buttonFilePath);
            this.Controls.Add(this.txtbxFilePath);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.txtbxSelect);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox txtbxSelect;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.TextBox txtbxFilePath;
        private System.Windows.Forms.Button buttonFilePath;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.OpenFileDialog selectFile;
        private System.Windows.Forms.FolderBrowserDialog saveFilePath;
    }
}

