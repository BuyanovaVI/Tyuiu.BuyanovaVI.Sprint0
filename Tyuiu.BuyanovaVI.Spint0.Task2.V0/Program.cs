using Tyuiu.BuyanovaVI.Sprint0.Task2.V0.LIb;

namespace Tyuiu.BuyanovaVI.Spint0.Task2.V0
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataSErvice и метод GetMessage
            //из библиотеки Tyuiu.BuyanovaVI.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Вика"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
