namespace Task1_1
{
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args"> Аргументы. </param>
        static void Main(string[] args)
        {
            const double a = 1;
            const double b = 2;
            const double c = 2;
            double x = GetNumber("x = ");
            double y = GetResult(a, b, c, x);
            Console.WriteLine($"x = {x}, y = {y}");
        }

        /// <summary>
        /// Рассчитывает значение заданной функции.
        /// </summary>
        /// <param name="a"> Аргумент a.</param>
        /// <param name="b"> Аргумент b.</param>
        /// <param name="c"> Аргумент c.</param>
        /// <param name="x"> Переменная x.</param>
        /// <returns> Значение функции.</returns>
        private static double GetResult(
            double a,
            double b,
            double c,
            double x)
        {
            return (a * Math.Abs(x * x * x) + 4.0 / 5.0 * b) /
                    (c * Math.Sqrt(x * x + 1) + Math.Sin(x));
        }

        /// <summary>
        /// Считывает число с клавиатуры.
        /// </summary>
        /// <param name="message"> Надпись для пользователя. </param>
        /// <returns> Число.</returns>
        private static double GetNumber(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return double.Parse(input);
        }
    }
}