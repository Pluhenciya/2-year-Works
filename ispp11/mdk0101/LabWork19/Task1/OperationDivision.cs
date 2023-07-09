namespace Task1
{
    internal class OperationDivision : IStrategy
    {
        public int DoOperation(int num1, int num2)
        {
            return num2 == 0 ? -1 : num1 / num2;
        }
    }
}
