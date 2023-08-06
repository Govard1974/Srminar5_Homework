
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

/*

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    return count;
}

Console.Write("input a Length of array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] userArray = new int[arraySize];
for(int i = 0; i < arraySize; i++)
{
     Console.Write($"Input a three-digit number {i + 1}: ");
     userArray[i] = Convert.ToInt32(Console.ReadLine());
}
int evenCount = CountEvenNumbers(userArray);
Console.WriteLine($"The number of even numbers in the array: {evenCount}");

*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

/*

 int arraySize = 5;
 Random random = new Random();
 int[] randomArray = new int[arraySize];
 for (int i = 0; i < arraySize; i++)
 {
    randomArray[i] = random.Next(-100,100);
 }
Console.WriteLine("Generated array: ");
for (int i = 0; i < arraySize; i++)
{
    Console.Write(randomArray[i] + " ");
}
Console.WriteLine();

int oddPositionSum = 0;
for (int i = 1; i < arraySize; i+=2)
{
    oddPositionSum += randomArray[i];
}
Console.WriteLine("Summ of elements in odd positions: " + oddPositionSum);

*/


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

/*

double[] realNumbersArray = { 1.5, -2.8, 3.2, -4.1, 5.7, 6.3 };

double max = realNumbersArray[0];
double min = realNumbersArray[0];

for (int i = 1; i < realNumbersArray.Length; i++)
{
    if (realNumbersArray[i] > max)
    {
        max = realNumbersArray[i];
    }

    if (realNumbersArray[i] < min)
    {
        min = realNumbersArray[i];
    }
}

double difference = max - min;

Console.WriteLine( "Array" );
for (int i = 0; i < realNumbersArray.Length; i++)
{
    Console.Write(realNumbersArray[i] + "  ");
}
Console.WriteLine();

Console.WriteLine("Max number: " + max);
Console.WriteLine("Min number: " + min);
Console.WriteLine("Difference between maximum and minimum: " + difference);

*/