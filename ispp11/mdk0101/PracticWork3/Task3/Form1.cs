using Word = Microsoft.Office.Interop.Word;
namespace Task3
{
    public partial class WordForm : System.Windows.Forms.Form
    {
        public WordForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = true;
            var document = wordApp.Documents.Add();
            var range = document.Paragraphs[1].Range;
            range.Text = textTextBox.Text;
            range.Font.Name = "Times New Roman";
            range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            range.Font.Size = 14;
            range = document.Paragraphs[2].Range;
            var table = document.Tables.Add(range, )
        }
    }
}