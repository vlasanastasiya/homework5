// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

void Zadacha35()
{
      int size = 5;
      Random random = new Random();
      double[] array = new double[size];
      array = FillArray(size);
      PrintArray(array);
      Console.WriteLine($"Максимальное значение равно {FindMax(array)}");
      Console.WriteLine($"Минимальное значение равно {FindMin(array)}");
      Console.WriteLine($"Разницу между max и min элементами массива равна {Math.Round(FindMax(array) - FindMin(array), 2)}");
      Console.WriteLine();

 double[] FillArray(int size)
{
    double[] fillArray = new double [size];
    Random random = new Random();
   for (int i = 0; i < fillArray.Length; i++)
   {
        fillArray[i] = random.NextDouble() * 100;
   }
    return fillArray;
}
void PrintArray(double[] array)
{
      Console.WriteLine("Вывод массива");
      Console.Write("[");
      for(int i = 0; i < array.Length; i++)
      {
            Console.Write(Math.Round(array[i], 2) + " "); 
      }
      Console.Write("]");
      Console.WriteLine();     
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {   
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return (Math.Round(max, 2));
}
double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {   
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return (Math.Round(min, 2));
} 
}
Zadacha35();

