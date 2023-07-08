namespace Task3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openFormButton_Click(object sender, EventArgs e)
        {
            ReplacementForm replacement = new ReplacementForm();
            replacement.replace = (input, replacement) => userTextTextBox.Text=userTextTextBox.Text.Replace(input, replacement);
            replacement.ShowDialog();
        }
    }
}