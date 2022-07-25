using System;

namespace Solutions
{
    class Program
    {
        #region Constants.
        private const double MULTIPLE = 2.0f;
        #endregion

        #region Entry point.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число:");
            string input = Console.ReadLine();
            double doubleInput;
            try
            {
                doubleInput = double.Parse(input);
                //doubleInput = double.MaxValue +2.0; Не параллелил. Очень долгое выполнение. Грани в задании не указаны.
                if (doubleInput == 0.0)
                    throw new ArgumentException();
                if (firstSolution(doubleInput) && secondSolutions(doubleInput) && thirdSolution(doubleInput))
                    Console.WriteLine("Число является четным.");
                else
                    Console.WriteLine("Число не является четным");
            }
            catch(FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                Main(null);
            }
            catch(ArgumentException aEx)
            {
                Console.WriteLine(aEx.Message);
                Main(null);
            }
            catch(Exception ex)
            {
                //Общий.
                Console.WriteLine(ex.Message);
            }
            Main(null);
        }
        #endregion

        #region Methods for check.
        /// <summary>
        /// Метод проверяет число, введеное пользователем, на кратность 2.
        /// Алгоритм проверки - остаток от деления.
        /// </summary>
        /// <param name="number"> Число, которое проверяется. </param>
        /// <returns> Результат проверки. Истина, если число кратно 2.(Четное). </returns>
        private static bool firstSolution(double number)
        {
            double result = Math.Abs(number) % MULTIPLE;
            if (result == 0.0)
                return true;
            return false;
        }

        /// <summary>
        /// Метод проверяет число, введеное пользователем, на кратность 2.
        /// Алгоритм проверки - цикл for.
        /// </summary>
        /// <param name="number"> Число, которое проверяется. </param>
        /// <returns> Результат проверки. Истина, если число кратно 2.(Четное). </returns>
        private static bool secondSolutions(double number)
        {
            bool result = false;
            double absNumber = Math.Abs(number);
            for (double n = 0.0; n <= absNumber; n += 2.0)
                if (n == absNumber)
                    result = true;
            return result;
        }

        /// <summary>
        /// Метод проверяет число, введеное пользователем, на кратность 2.
        /// Алгоритм проверки - цикл while.
        /// </summary>
        /// <param name="number"> Число, которое проверяется. </param>
        /// <returns> Результат проверки. Истина, если число кратно 2.(Четное). </returns>
        private static bool thirdSolution(double number)
        {
            double i = 0.0;
            double absNumber = Math.Abs(number);
            while (i <= absNumber) 
            {
                if (i == absNumber)
                    return true;
                i += 2.0;
            }
            return false;
        }
        #endregion
    }


}
