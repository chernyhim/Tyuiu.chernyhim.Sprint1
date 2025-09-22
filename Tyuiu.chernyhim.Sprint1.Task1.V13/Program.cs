using Tyuiu.chernyhim.Sprint1.Task1.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Sprint #1 | Made by Chernyh I. M. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Черных Илья Максимович | ПКТб-25-1                            *");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *"); 
        Console.WriteLine("* вычисляет результат по формуле x / ( 0.5 * x) и печатает его на экране  *");                                        
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double x;

        Console.WriteLine("Введите значение X:");
        x = Convert.ToDouble(Console.ReadLine());
       
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(x));
        Console.ReadLine();
    }
}