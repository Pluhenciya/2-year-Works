namespace Task2
{
    public class User
    {
        private string _login;
        private string _password;

        public User(string login, string password)
        {
            _login = login;
            _password = password;
        }

        public bool IsCorrectUserData(string confirm)
        {
            bool isLoginCorrect = _login != "";
            bool isPasswordCorrect = _password != "";
            bool isConfirmCorrect = confirm == _password;
            return isLoginCorrect && isPasswordCorrect && isConfirmCorrect;
        }
    }
}
