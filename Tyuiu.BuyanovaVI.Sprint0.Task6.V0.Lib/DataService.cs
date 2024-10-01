namespace Tyuiu.BuyanovaVI.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        //Пример циклической структыры (цикл с параметрами) for
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            return total;
        }
        //Пример циклической структыры (цикл с предусловием) while
        public static object SubtractionArray(int[] numbers)
        {
            var total = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                total = total - numbers[index];
                index++;
            }
            return total;
        }
        //Пример циклической структыры (цикл с постусловием) do while
        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total = total * numbers[index];
                index++;
            }
            while (index < numbers.Length);
            return total;
        }
    }
}

