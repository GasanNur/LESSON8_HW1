// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2




int InputUser(string msg) // тип возвращаемого значение (int) название метода. в скобках тип параметра который метод принемает. 
{
    Console.Write($"{msg} = >");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
// Метод заполнения массива случайными положительнымиnht трехзначными  числами
int[] FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    Console.WriteLine();
    return array;
}

//   метод показывает количество четных чисел в массиве

int ShowEvenArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }
    return result;
}
//  метод вывода массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();

}

int userNumber = InputUser("Введите колличество элементов массива ");
int[] myArray = new int[userNumber];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine($"Колличество четных чисел в массиве  {ShowEvenArray(myArray)} ");