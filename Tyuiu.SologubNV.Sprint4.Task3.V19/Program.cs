using Tyuiu.SologubNV.Sprint4.Task3.V19.Lib;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Title = "Спринт #4 | Выполнил: Сологуб Н.В | ИБКСб-26-1";
        WriteLine("***************************************************************************");
        WriteLine("* Спринт #4                                                               *");
        WriteLine("* Тема: Двумерные массивы.                                                *");
        WriteLine("* Задание #3                                                              *");
        WriteLine("* Вариант #19                                                             *");
        WriteLine("* Выполнил: Сологуб Николай Витальевич | ИБКСб-26-1                       *");
        WriteLine("***************************************************************************");
        WriteLine("* УСЛОВИЕ;                                                                *");
        WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        WriteLine("* статическими значениями в диапазоне от 3 до 9.                          *");
        WriteLine("* Подсчитайте количество четных элементов во всем массиве.                *");
        WriteLine("* 6, 5, 6, 3, 8,                                                          *");
        WriteLine("* 9, 4, 4, 3, 4,                                                          *");
        WriteLine("* 3, 3, 6, 8, 6,                                                          *");
        WriteLine("* 6, 5, 3, 4, 3,                                                          *");
        WriteLine("* 9, 3, 5, 3, 7,                                                          *");
        WriteLine("***************************************************************************");
        WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        WriteLine("***************************************************************************");
        int[,] array = new int[5, 5] { {6, 5, 6, 3, 8 },{9, 4, 4, 3, 4},{3, 3, 6, 8, 6},{6, 5, 3, 4, 3},{9, 3, 5, 3, 7 }};
        WriteLine("Массив:");
        int rows = array.GetUpperBound(0) + 1;
        int cols = array.Length / rows;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                WriteLine($"{array[i,j]} \t");
            }
            WriteLine();
        }
        WriteLine("***************************************************************************");
        WriteLine("* РЕЗУЛЬТАТ                                                               *");
        WriteLine("***************************************************************************");
        int summodd = ds.Calculate(array);
        WriteLine(summodd);
        ReadLine();
    }
}