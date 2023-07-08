namespace Task1
{
    public partial class RegistrationForm : System.Windows.Forms.Form
    {
        string fileName = $@"{Environment.CurrentDirectory}\logins.csv";

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }
            string[] lines = File.ReadAllLines(fileName);
            bool isExistLogin = false;
            foreach (string line in lines)
            {
                if (line.Split(";")[0] == loginTextBox.Text)
                {
                    MessageBox.Show("Логин уже занят");
                    isExistLogin = true;
                    break;
                }
            }
            if (!isExistLogin)
            {
                MessageBox.Show("Вы зарегистрированы");
                File.AppendAllText(fileName,
                    $"{loginTextBox.Text};{passwordTextBox.Text};{DateTime.Now.Date}\n");
            }
        }
    }
}