namespace Task1_2
{
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args"> Аргументы. </param>
        static void Main(string[] args)
        {
            double a = GetNumber("Катет a = ");
            double b = GetNumber("Катет b = ");

            double c = GetHypotenuse(a, b);
            double p = GetPerimeter(a, b, c);
            double s = GetArea(a, b);

            Console.WriteLine($"Гипотенуза c = {c}");
            Console.WriteLine($"Периметр P = {p}");
            Console.WriteLine($"Площадь S = {s}");
        }

        /// <summary>
        /// Находит гипотенузу треугольника.
        /// </summary>
        /// <param name="a"> Катет a.</param>
        /// <param name="b"> Катет b.</param>
        /// <returns> Длина гипотенузы.</returns>
        private static double GetHypotenuse(
            double a,
            double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        /// <summary>
        /// Находит периметр треугольника.
        /// </summary>
        /// <param name="a"> Катет a.</param>
        /// <param name="b"> Катет b.</param>
        /// <param name="c"> Гипотенуза c.</param>
        /// <returns> Периметр.</returns>
        private static double GetPerimeter(
            double a,
            double b,
            double c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Находит площадь треугольника.
        /// </summary>
        /// <param name="a"> Катет a.</param>
        /// <param name="b"> Катет b.</param>
        /// <returns> Площадь.</returns>
        private static double GetArea(
            double a,
            double b)
        {
            return a * b / 2.0;
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