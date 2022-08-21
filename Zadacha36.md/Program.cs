// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
void Zadacha35()
{
     
      int size = 5;
      int[] array = new int[size];
      Fillarray(array, 1, 10);
      PrintArray(array);
      Findsum(array);
      

void Fillarray(int[] array, int start = 0, int finish = 0)
{
      finish++;
      Random random = new Random();

      for(int i = 0; i < array.Length; i++)
      {
            array[i] = random.Next(start, finish);
      }
}
void PrintArray(int[] array)
{
      Console.WriteLine("Вывод массива");
      Console.Write("[");
      for(int i = 0; i < array.Length; i++)
      {
            Console.Write(array[i]+ " ");
      }
      Console.Write("]");
      Console.WriteLine();     
}

void Findsum(int[] array)
{
      int sum = 0;
      for(int i = 0; i < array.Length; i= i+2)
      {
            sum = sum + array[i];  
      }
      Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");
}
}
Zadacha35();
