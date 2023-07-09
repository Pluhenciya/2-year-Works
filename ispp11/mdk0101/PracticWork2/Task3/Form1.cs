using Excel = Microsoft.Office.Interop.Excel;
namespace Task3
{
    public partial class MultiplyForm : Form
    {
        public MultiplyForm()
        {
            InitializeComponent();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            var workbook = excelApp.Workbooks.Add();
            var multiplyWorksheet = workbook.Worksheets.Add();
            multiplyWorksheet.Name = "Умножение";
            for (int i = 2; i < 10; i++)
            {
                multiplyWorksheet.Cells[i + 3][11] = i;
                multiplyWorksheet.Cells[4][i + 10] = i;
                multiplyWorksheet.Cells[i + 3][11].Interior.Color =
                    multiplyWorksheet.Cells[4][i + 10].Interior.Color =
                    ColorTranslator.ToOle(Color.Aqua);
            }
            Excel.Range range = multiplyWorksheet.range[
                multiplyWorksheet.Cells[5][12],
                multiplyWorksheet.Cells[12][19]];
            range.Formula = $"=E$11*$D12";
            range = multiplyWorksheet.range[multiplyWorksheet.Cells[4][11],
                multiplyWorksheet.Cells[12][19]];
            range.Font.Size = 15;
            range = multiplyWorksheet.range[multiplyWorksheet.Cells[4][10],
                multiplyWorksheet.Cells[12][10]];
            range.Merge();
            multiplyWorksheet.Cells[4][10] = "Таблица умножения";
            range.Font.Italic = true;
            range.Font.Bold = true;
            range.Font.Size = 20;
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range = multiplyWorksheet.range[multiplyWorksheet.Cells[4][10],
                multiplyWorksheet.Cells[12][19]];
            range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
        }
    }
}