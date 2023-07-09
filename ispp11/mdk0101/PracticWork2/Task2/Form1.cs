using Excel = Microsoft.Office.Interop.Excel;
namespace Task2
{
    public partial class InfoFilesForm : Form
    {
        public InfoFilesForm()
        {
            InitializeComponent();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            var workbook = excelApp.Workbooks.Add(@$"{Environment.CurrentDirectory}\pattern");
            string directoryName = pathTextBox.Text;
            DirectoryInfo directory = new(directoryName);
            FileInfo[] files = directory.GetFiles();
            var filesWorksheet = workbook.Worksheets[1];
            for (int i = 0; i < files.Length; i++)
            {
                filesWorksheet.Cells[1][i + 2] = i+1;
                filesWorksheet.Cells[2][i + 2] = files[i].Name;
                filesWorksheet.Cells[3][i + 2] = files[i].Length;
            }
            DirectoryInfo[] directories = directory.GetDirectories();
            var directoriesWorksheet = workbook.Worksheets[2];
            for (int i = 0; i < directories.Length; i++)
            {
                directoriesWorksheet.Cells[1][i + 2] = i+1;
                directoriesWorksheet.Cells[2][i + 2] = directories[i].Name;
            }
        }
    }
}