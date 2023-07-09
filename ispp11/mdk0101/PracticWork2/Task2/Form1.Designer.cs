namespace Task2
{
    partial class InfoFilesForm
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
            this.infoButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(12, 120);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(265, 50);
            this.infoButton.TabIndex = 0;
            this.infoButton.Text = "Вывести информацию";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(12, 52);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(265, 23);
            this.pathTextBox.TabIndex = 1;
            // 
            // InfoFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 182);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.infoButton);
            this.Name = "InfoFilesForm";
            this.Text = "Информация о файлах";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button infoButton;
        private TextBox pathTextBox;
    }
}