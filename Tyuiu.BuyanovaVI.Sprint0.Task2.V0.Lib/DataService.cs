using System.Security.Cryptography.X509Certificates;

namespace Tyuiu.BuyanovaVI.Sprint0.Task2.V0.LIb
{
    public class DataService
    {
        public static string GetMessage(string name)
        {
            return $"Привет, {name}";
        }

    }
}
