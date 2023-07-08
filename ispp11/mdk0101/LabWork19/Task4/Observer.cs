namespace Task4
{
    internal abstract class Observer
    {
        protected Subject subject;
        public abstract void Update();
    }
}
