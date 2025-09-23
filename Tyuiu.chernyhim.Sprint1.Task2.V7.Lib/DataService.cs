using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.chernyhim.Sprint1.Task2.V7.Lib
{
    public class DataService : ISprint1Task2V7
    {
        public double CalculateSquareCircle(int value)
        {
            double a = value * value * 3.1415926;
            a = Math.Round(a, 3);
            return a;
        }
    }
}
