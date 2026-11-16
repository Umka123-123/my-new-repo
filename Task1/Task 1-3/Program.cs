namespace Task1_3
{
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args"> Аргументы. </param>
        static void Main(string[] args)
        {
            double m = GetNumber("Масса m (кг) = ");
            double lambda = GetNumber("Удельная теплота плавления λ (Дж/кг) = ");

            double q = GetHeat(m, lambda);

            Console.WriteLine($"Масса m = {m} кг");
            Console.WriteLine($"Количество теплоты Q = {q} Дж");
        }

        /// <summary>
        /// Рассчитывает количество теплоты для плавления.
        /// </summary>
        /// <param name="m"> Масса вещества. </param>
        /// <param name="lambda"> Удельная теплота плавления. </param>
        /// <returns> Количество теплоты.</returns>
        private static double GetHeat(
            double m,
            double lambda)
        {
            return m * lambda;
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