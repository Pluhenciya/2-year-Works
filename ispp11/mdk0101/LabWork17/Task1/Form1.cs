namespace Task1
{
    public partial class InfoFilesForm : Form
    {
        FileInfo[] files;

        public InfoFilesForm()
        {
            InitializeComponent();
        }

        private void InfoFilesForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Temp\ispp11\mdk0101");
            files = directory.GetFiles("*", SearchOption.AllDirectories);
            filesDataGridView.DataSource = files;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            var result = files
                .Select(file => new { file.Name, file.DirectoryName, file.Length, file.CreationTime })
                .OrderBy(file => file.Name)
                .ThenByDescending(file => file.CreationTime).ToList();
            filesDataGridView.DataSource = result;
        }

        private void ExtensionButton_Click(object sender, EventArgs e)
        {
            var result = files.Select(file => new { file.Extension }).Distinct().ToList();
            filesDataGridView.DataSource = result;
        }

        private void ExtensionCountButton_Click(object sender, EventArgs e)
        {
            var result = files
                .GroupBy(file => file.Extension)
                .Select(group => new { Extension = group.Key, ExtensionCount = group
                .Count(file => file.Extension == group.Key) }).ToList();
            filesDataGridView.DataSource = result;
        }

        private void ChangeDirectoryButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(directoryTextBox.Text);
            files = directory.GetFiles("*", SearchOption.AllDirectories);
            filesDataGridView.DataSource = files;
        }

        private void SearchFileButton_Click(object sender, EventArgs e)
        {
            var result = files.Where(file => file.Name
            .Contains(searchFileTextBox.Text)).ToList();
            filesDataGridView.DataSource = result;
        }

        private void LastFilesButton_Click(object sender, EventArgs e)
        {
            var result = files.Where(file => file.CreationTime.Date==DateTime.Today.Date).Take(5).ToList();
            filesDataGridView.DataSource = result;
        }

        private void PropertyDirectoryButton_Click(object sender, EventArgs e)
        {
            var countFiles = files.Count(file=>true);
            var memory = files.Sum(file => file.Length)/1024/1024;
            MessageBox.Show($"Файлов всего {countFiles}. Занимаемая память: {memory} Мб.");
        }

        private void LengthButton_Click(object sender, EventArgs e)
        {
            var result = files
                .Select(file => new { file.Name, file.Extension, file.FullName, file.Length }).ToList();
            filesDataGridView.DataSource = result;
        }
    }
}