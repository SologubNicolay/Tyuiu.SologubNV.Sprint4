using Tyuiu.SologubNV.Sprint4.Task4.V16.Lib;
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
        WriteLine("* Задание #4                                                              *");
        WriteLine("* Вариант #16                                                             *");
        WriteLine("* Выполнил: Сологуб Николай Витальевич | ИБКСб-26-1                       *");
        WriteLine("***************************************************************************");
        WriteLine("* УСЛОВИЕ;                                                                *");
        WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        WriteLine("* значениями с клавиатуры в диапазоне от 3 до 7.                          *");
        WriteLine("* Подсчитайте количество четных элементов во всем массиве.                *");
        WriteLine("* Заменить четные элементы массива на 1.                                  *");
        WriteLine("* 6, 5, 6, 7, 3,                                                          *");
        WriteLine("* 5, 4, 6, 7, 3,                                                          *");
        WriteLine("* 5, 5, 5, 6, 5,                                                          *");
        WriteLine("* 6, 5, 4, 4, 3,                                                          *");
        WriteLine("* 4, 5, 4, 5, 5,                                                          *");
        WriteLine("***************************************************************************");
        WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        WriteLine("***************************************************************************");
        WriteLine("Введение количество строк в массив: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        WriteLine("Введение количество столбцов в массив: ");
        int cols = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                WriteLine($"Введите {i}{j} элемент массива: ");
                array[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        WriteLine("***************************************************************************");
        WriteLine("* РЕЗУЛЬТАТ                                                               *");
        WriteLine("***************************************************************************");
        int[,] summodd = ds.Calculate(array);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                WriteLine($" {array[i,j]} \t" );
            }
        }
        ReadLine();
    }
}