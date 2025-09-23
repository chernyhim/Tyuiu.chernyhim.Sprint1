using Tyuiu.chernyhim.Sprint1.Task4.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Sprint #1 | Made by Chernyh I. M. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                 *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #20                                                              *");
        Console.WriteLine("* Выполнил: Черных Илья Максимович | ПКТб-25-1                            *");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double x, y;

        Console.WriteLine("Введите значение X:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение Y:");
        y = Convert.ToInt32(Console.ReadLine());
       

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Результат " + ds.Calculate(x, y));
        Console.ReadLine();
    }
}