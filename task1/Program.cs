// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] array = new int[10];
int count =0;
Random rand = new Random();
    for(int i = 0; i <array.Length; i++)
    {
        array[i] = rand.Next(1,200);
    }

Console.WriteLine('['+ string.Join(", ", array) +']');
int SumCountArray( int[] array)
{
    
    for(int j = 0; j < array.Length; j++)
    {
        if(array[j]>10 && array[j] < 99)
        {
           count++;
        }
    }
return count;
}
SumCountArray(array);

Console.WriteLine(count);