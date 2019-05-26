namespace ClassFour
{
    partial class ListForm
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
            this.shoeButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.showRichTextBox = new System.Windows.Forms.RichTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // shoeButton
            // 
            this.shoeButton.Location = new System.Drawing.Point(153, 26);
            this.shoeButton.Name = "shoeButton";
            this.shoeButton.Size = new System.Drawing.Size(75, 23);
            this.shoeButton.TabIndex = 0;
            this.shoeButton.Text = "Show";
            this.shoeButton.UseVisualStyleBackColor = true;
            this.shoeButton.Click += new System.EventHandler(this.shoeButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(153, 83);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // showRichTextBox
            // 
            this.showRichTextBox.Location = new System.Drawing.Point(12, 61);
            this.showRichTextBox.Name = "showRichTextBox";
            this.showRichTextBox.Size = new System.Drawing.Size(100, 96);
            this.showRichTextBox.TabIndex = 2;
            this.showRichTextBox.Text = "";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(153, 125);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.showRichTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.shoeButton);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shoeButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.RichTextBox showRichTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}