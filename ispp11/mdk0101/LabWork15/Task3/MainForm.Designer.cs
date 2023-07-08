namespace Task3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userTextTextBox = new System.Windows.Forms.TextBox();
            this.openFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userTextTextBox
            // 
            this.userTextTextBox.Location = new System.Drawing.Point(12, 12);
            this.userTextTextBox.Multiline = true;
            this.userTextTextBox.Name = "userTextTextBox";
            this.userTextTextBox.Size = new System.Drawing.Size(776, 368);
            this.userTextTextBox.TabIndex = 0;
            // 
            // openFormButton
            // 
            this.openFormButton.Location = new System.Drawing.Point(579, 386);
            this.openFormButton.Name = "openFormButton";
            this.openFormButton.Size = new System.Drawing.Size(209, 50);
            this.openFormButton.TabIndex = 1;
            this.openFormButton.Text = "Замена";
            this.openFormButton.UseVisualStyleBackColor = true;
            this.openFormButton.Click += new System.EventHandler(this.openFormButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openFormButton);
            this.Controls.Add(this.userTextTextBox);
            this.Name = "MainForm";
            this.Text = "Окошко с текстом ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox userTextTextBox;
        private Button openFormButton;
    }
}