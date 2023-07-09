namespace LabWorkLibrary
{
    public class Maths
    {
        /// <summary>
        /// 2 в 10 степени
        /// </summary>
        int BINARY_FACTOR = 1024;

        /// <summary>
        /// Вычисляет сумму
        /// </summary>
        /// <param name="a">Первое слагаемое</param>
        /// <param name="b">Второе слагаемое</param>
        /// <returns>Сумма</returns>
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Вычисляет разность
        /// </summary>
        /// <param name="a">Уменьшаемое</param>
        /// <param name="b">Вычитаемое</param>
        /// <returns>Разность</returns>
        public static double Subtraction(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Вычисляет произведение
        /// </summary>
        /// <param name="a">Первый множитель</param>
        /// <param name="b">Второй множитель</param>
        /// <returns>Произведение</returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Вычисляет частное
        /// </summary>
        /// <param name="a">Делимое</param>
        /// <param name="b">Делитель</param>
        /// <returns>Частное</returns>
        /// <exception cref="System.DivideByZeroException">На ноль делить нельзя</exception>
        public static double Division(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("На ноль делить нельзя");
            return a / b;
        }

        /// <summary>
        /// Вычисляет площадь прямоугольника
        /// </summary>
        /// <param name="a">Длина</param>
        /// <param name="b">Ширина</param>
        /// <returns>Площадь</returns>
        /// <exception cref="System.ArgumentException">Стороны прямоугольника не могут быть неположительными</exception>
        public static double Square(double a, double b)
        {
            if (a <= 0 || b <= 0)
                throw new ArgumentException("Стороны прямоугольника не могут быть неположительными");
            return a * b;
        }
    }
}