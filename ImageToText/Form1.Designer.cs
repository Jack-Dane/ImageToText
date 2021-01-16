namespace ImageToText
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
            this.uiSelectImageButton = new System.Windows.Forms.Button();
            this.uiFileNameTextBox = new System.Windows.Forms.TextBox();
            this.uiOpenWithComboBox = new System.Windows.Forms.ComboBox();
            this.uiCreateTextFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiSelectImageButton
            // 
            this.uiSelectImageButton.Location = new System.Drawing.Point(12, 12);
            this.uiSelectImageButton.Name = "uiSelectImageButton";
            this.uiSelectImageButton.Size = new System.Drawing.Size(141, 95);
            this.uiSelectImageButton.TabIndex = 0;
            this.uiSelectImageButton.Text = "Choose Image";
            this.uiSelectImageButton.UseVisualStyleBackColor = true;
            this.uiSelectImageButton.Click += new System.EventHandler(this.UploadImage);
            // 
            // uiFileNameTextBox
            // 
            this.uiFileNameTextBox.Location = new System.Drawing.Point(12, 141);
            this.uiFileNameTextBox.Name = "uiFileNameTextBox";
            this.uiFileNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.uiFileNameTextBox.TabIndex = 1;
            // 
            // uiOpenWithComboBox
            // 
            this.uiOpenWithComboBox.FormattingEnabled = true;
            this.uiOpenWithComboBox.Location = new System.Drawing.Point(13, 114);
            this.uiOpenWithComboBox.Name = "uiOpenWithComboBox";
            this.uiOpenWithComboBox.Size = new System.Drawing.Size(140, 21);
            this.uiOpenWithComboBox.TabIndex = 2;
            this.uiOpenWithComboBox.SelectedIndexChanged += new System.EventHandler(this.uiOpenWithComboBox_SelectedIndexChanged);
            // 
            // uiCreateTextFileButton
            // 
            this.uiCreateTextFileButton.Location = new System.Drawing.Point(46, 167);
            this.uiCreateTextFileButton.Name = "uiCreateTextFileButton";
            this.uiCreateTextFileButton.Size = new System.Drawing.Size(75, 23);
            this.uiCreateTextFileButton.TabIndex = 3;
            this.uiCreateTextFileButton.Text = "Create";
            this.uiCreateTextFileButton.UseVisualStyleBackColor = true;
            this.uiCreateTextFileButton.Click += new System.EventHandler(this.CreateTxtFile);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 198);
            this.Controls.Add(this.uiCreateTextFileButton);
            this.Controls.Add(this.uiOpenWithComboBox);
            this.Controls.Add(this.uiFileNameTextBox);
            this.Controls.Add(this.uiSelectImageButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uiSelectImageButton;
        private System.Windows.Forms.TextBox uiFileNameTextBox;
        private System.Windows.Forms.ComboBox uiOpenWithComboBox;
        private System.Windows.Forms.Button uiCreateTextFileButton;
    }
}

