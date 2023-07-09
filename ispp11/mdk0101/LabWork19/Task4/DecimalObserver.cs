namespace Task4
{
    internal class DecimalObserver : Observer
    {
        public DecimalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Decimal String: " + Convert.ToString(subject.State, 10));
        }
    }
}
