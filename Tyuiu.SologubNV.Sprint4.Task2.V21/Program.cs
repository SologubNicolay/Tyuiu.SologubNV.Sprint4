using Tyuiu.SologubNV.Sprint4.Task2.V21.Lib;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        DataService ds = new DataService();
        Title = "Спринт #4 | Выполнил: Сологуб Н.В | ИБКСб-26-1";
        WriteLine("***************************************************************************");
        WriteLine("* Спринт #4                                                               *");
        WriteLine("* Тема: Одномерные массивы.                                               *");
        WriteLine("* Задание #2                                                              *");
        WriteLine("* Вариант #21                                                             *");
        WriteLine("* Выполнил: Сологуб Николай Витальевич | ИБКСб-26-1                       *");
        WriteLine("***************************************************************************");
        WriteLine("* УСЛОВИЕ;                                                                *");
        WriteLine("* Дан одномерный целочисленный массив на 15 элементов заполненный         *");
        WriteLine("* случайными в диапазоне от 1 до 7 подсчитать произведение четных         *");
        WriteLine("* элементов массива.                                                      *");
        WriteLine("***************************************************************************");
        WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        WriteLine("***************************************************************************");
        WriteLine("Введите количество элементов массива: ");
        int len = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[len];
        for (int i = 0; i < len; i++)
        {
            array[i] = rand.Next(1, 7);
        }
        WriteLine("***************************************************************************");
        WriteLine("* РЕЗУЛЬТАТ                                                               *");
        WriteLine("***************************************************************************");
        int summodd = ds.Calculate(array);
        WriteLine(summodd);
        ReadLine();
    }
}