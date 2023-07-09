namespace Task3
{
    partial class MultiplyForm
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
            multiplyButton = new Button();
            SuspendLayout();
            // 
            // multiplyButton
            // 
            multiplyButton.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            multiplyButton.Location = new Point(12, 12);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(376, 124);
            multiplyButton.TabIndex = 0;
            multiplyButton.Text = "Таблица умножения";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += MultiplyButton_Click;
            // 
            // MultiplyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 148);
            Controls.Add(multiplyButton);
            Name = "MultiplyForm";
            Text = "Таблица умножения";
            ResumeLayout(false);
        }

        #endregion

        private Button multiplyButton;
    }
}