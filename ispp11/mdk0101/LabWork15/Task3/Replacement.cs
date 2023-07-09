namespace Task3
{
    public partial class ReplacementForm : Form
    {
        public Action< string, string> replace;

        public ReplacementForm()
        {
            InitializeComponent();
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            replace(searchTextBox.Text, replacementTextBox.Text);
        }
    }
}
