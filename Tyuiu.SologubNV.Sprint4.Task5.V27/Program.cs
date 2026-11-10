using Tyuiu.SologubNV.Sprint4.Task5.V27.Lib;
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
        WriteLine("* Тема: Двумерные массивы.                                                *");
        WriteLine("* Задание #5                                                              *");
        WriteLine("* Вариант #16                                                             *");
        WriteLine("* Выполнил: Сологуб Николай Витальевич | ИБКСб-26-1                       *");
        WriteLine("***************************************************************************");
        WriteLine("* УСЛОВИЕ;                                                                *");
        WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        WriteLine("* случайными значениями в диапазоне от -5 до 7.                           *");
        WriteLine("* Найти количество отрицательных элементов.                               *");
        WriteLine("* Заменить четные элементы массива на 1.                                  *");
        WriteLine("***************************************************************************");
        WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        WriteLine("***************************************************************************");
        int rows = 5;
        int cols = 5;
        int[,] array = new int[rows, cols];
        WriteLine("Матрица: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = rand.Next(-5,7);
                WriteLine($"Элемент {i}{j} имеет значение {array[i, j]}");
            }
        }
        WriteLine("***************************************************************************");
        WriteLine("* РЕЗУЛЬТАТ                                                               *");
        WriteLine("***************************************************************************");
        int summodd = ds.Calculate(array);
        WriteLine(summodd);
        ReadLine();
    }
}