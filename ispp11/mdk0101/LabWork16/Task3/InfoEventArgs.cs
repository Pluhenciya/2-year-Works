namespace Task3
{
    public class InfoEventArgs : EventArgs
    {
        public string NameProperty { get; set; }

        public string TextError { get; set; }

        public DateTime DateChange { get; set; }
    }
}
