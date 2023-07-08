namespace Task1
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
            this.filesDataGridView = new System.Windows.Forms.DataGridView();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.changeDirectoryButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.extensionButton = new System.Windows.Forms.Button();
            this.extensionCountButton = new System.Windows.Forms.Button();
            this.searchFileButton = new System.Windows.Forms.Button();
            this.searchFileTextBox = new System.Windows.Forms.TextBox();
            this.lastFilesButton = new System.Windows.Forms.Button();
            this.propertyDirectoryButton = new System.Windows.Forms.Button();
            this.lengthButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filesDataGridView
            // 
            this.filesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.filesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filesDataGridView.Location = new System.Drawing.Point(12, 69);
            this.filesDataGridView.Name = "filesDataGridView";
            this.filesDataGridView.RowTemplate.Height = 25;
            this.filesDataGridView.Size = new System.Drawing.Size(776, 317);
            this.filesDataGridView.TabIndex = 0;
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Location = new System.Drawing.Point(12, 42);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(631, 23);
            this.directoryTextBox.TabIndex = 1;
            this.directoryTextBox.Text = "C:\\Temp\\ispp11\\mdk0101";
            // 
            // changeDirectoryButton
            // 
            this.changeDirectoryButton.Location = new System.Drawing.Point(649, 44);
            this.changeDirectoryButton.Name = "changeDirectoryButton";
            this.changeDirectoryButton.Size = new System.Drawing.Size(139, 23);
            this.changeDirectoryButton.TabIndex = 2;
            this.changeDirectoryButton.Text = "Изменить папку";
            this.changeDirectoryButton.UseVisualStyleBackColor = true;
            this.changeDirectoryButton.Click += new System.EventHandler(this.ChangeDirectoryButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(13, 10);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(152, 23);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "Краткая информация";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // extensionButton
            // 
            this.extensionButton.Location = new System.Drawing.Point(171, 10);
            this.extensionButton.Name = "extensionButton";
            this.extensionButton.Size = new System.Drawing.Size(148, 23);
            this.extensionButton.TabIndex = 4;
            this.extensionButton.Text = "Вывести расширение";
            this.extensionButton.UseVisualStyleBackColor = true;
            this.extensionButton.Click += new System.EventHandler(this.ExtensionButton_Click);
            // 
            // extensionCountButton
            // 
            this.extensionCountButton.Location = new System.Drawing.Point(325, 10);
            this.extensionCountButton.Name = "extensionCountButton";
            this.extensionCountButton.Size = new System.Drawing.Size(207, 23);
            this.extensionCountButton.TabIndex = 5;
            this.extensionCountButton.Text = "Количество файлов расширений";
            this.extensionCountButton.UseVisualStyleBackColor = true;
            this.extensionCountButton.Click += new System.EventHandler(this.ExtensionCountButton_Click);
            // 
            // searchFileButton
            // 
            this.searchFileButton.Location = new System.Drawing.Point(288, 409);
            this.searchFileButton.Name = "searchFileButton";
            this.searchFileButton.Size = new System.Drawing.Size(75, 25);
            this.searchFileButton.TabIndex = 6;
            this.searchFileButton.Text = "Поиск";
            this.searchFileButton.UseVisualStyleBackColor = true;
            this.searchFileButton.Click += new System.EventHandler(this.SearchFileButton_Click);
            // 
            // searchFileTextBox
            // 
            this.searchFileTextBox.Location = new System.Drawing.Point(13, 409);
            this.searchFileTextBox.Name = "searchFileTextBox";
            this.searchFileTextBox.Size = new System.Drawing.Size(269, 23);
            this.searchFileTextBox.TabIndex = 7;
            // 
            // lastFilesButton
            // 
            this.lastFilesButton.Location = new System.Drawing.Point(538, 10);
            this.lastFilesButton.Name = "lastFilesButton";
            this.lastFilesButton.Size = new System.Drawing.Size(125, 23);
            this.lastFilesButton.TabIndex = 8;
            this.lastFilesButton.Text = "Последние файлы";
            this.lastFilesButton.UseVisualStyleBackColor = true;
            this.lastFilesButton.Click += new System.EventHandler(this.LastFilesButton_Click);
            // 
            // propertyDirectoryButton
            // 
            this.propertyDirectoryButton.Location = new System.Drawing.Point(669, 10);
            this.propertyDirectoryButton.Name = "propertyDirectoryButton";
            this.propertyDirectoryButton.Size = new System.Drawing.Size(118, 23);
            this.propertyDirectoryButton.TabIndex = 9;
            this.propertyDirectoryButton.Text = "Свойства папки";
            this.propertyDirectoryButton.UseVisualStyleBackColor = true;
            this.propertyDirectoryButton.Click += new System.EventHandler(this.PropertyDirectoryButton_Click);
            // 
            // lengthButton
            // 
            this.lengthButton.Location = new System.Drawing.Point(378, 411);
            this.lengthButton.Name = "lengthButton";
            this.lengthButton.Size = new System.Drawing.Size(206, 23);
            this.lengthButton.TabIndex = 10;
            this.lengthButton.Text = "Краткая нормальная информация";
            this.lengthButton.UseVisualStyleBackColor = true;
            this.lengthButton.Click += new System.EventHandler(this.LengthButton_Click);
            // 
            // InfoFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.lengthButton);
            this.Controls.Add(this.propertyDirectoryButton);
            this.Controls.Add(this.lastFilesButton);
            this.Controls.Add(this.searchFileTextBox);
            this.Controls.Add(this.searchFileButton);
            this.Controls.Add(this.extensionCountButton);
            this.Controls.Add(this.extensionButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.changeDirectoryButton);
            this.Controls.Add(this.directoryTextBox);
            this.Controls.Add(this.filesDataGridView);
            this.Name = "InfoFilesForm";
            this.Text = "Информация о файлах";
            this.Load += new System.EventHandler(this.InfoFilesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView filesDataGridView;
        private TextBox directoryTextBox;
        private Button changeDirectoryButton;
        private Button selectButton;
        private Button extensionButton;
        private Button extensionCountButton;
        private Button searchFileButton;
        private TextBox searchFileTextBox;
        private Button lastFilesButton;
        private Button propertyDirectoryButton;
        private Button lengthButton;
    }
}