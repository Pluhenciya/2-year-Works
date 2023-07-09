using Word = Microsoft.Office.Interop.Word;
namespace Task1
{
    public partial class WordForm : Form
    {
        public WordForm()
        {
            InitializeComponent();
        }

        private void ׁreateFileButton_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = true;
            var document = wordApp.Documents.Add(@$"{Environment.CurrentDirectory}\״אבכמם.docx");
            document.Content.Find.Execute(FindText: "ׂוךסעָחֿמכÿֲגמהא", ReplaceWith: textTextBox.Text, Replace: Word.WdReplace.wdReplaceAll);
            document.Content.Find.Execute(FindText: "הה.לל.דדדד קק:לל", ReplaceWith: DateTime.Now, Replace: Word.WdReplace.wdReplaceAll);
            int rowsCount = Convert.ToInt32(numberTextBox.Text);
            for (int i = 1; i < rowsCount; i++)
            {
                document.Tables[1].Rows.Add(document.Tables[1].Rows[i + 1]);
                document.Tables[1].Cell(i + 1, 1).Range.Text = i.ToString();
            }
            document.Tables[1].Cell(rowsCount + 1, 1).Range.Text = rowsCount.ToString();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "װאיכ ג פמנלאעו *.docx|*.docx|װאיכ ג פמנלאעו *.pdf|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName.EndsWith(".pdf"))
                {
                    document.SaveAs(saveFileDialog.FileName, Word.WdSaveFormat.wdFormatPDF);
                }
                else
                {
                    document.SaveAs(saveFileDialog.FileName);
                }
            }
        }
    }
}