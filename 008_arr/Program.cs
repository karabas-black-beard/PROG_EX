//task 1
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// int[] array = { 1, 2, 3, 10, 5, 6, 7, 8, 9 };
// //array[0] = 12;
// //System.Console.WriteLine(array[4]);

// int max = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
//     );
// Console.WriteLine(max);


//Task 2 узнать индекс числа в массиве
// int[] array = { 1, 2, 3, 10, 5, 6, 7, 8, 9 };
// int n = array.Length;
// int find = 8;
// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         System.Console.WriteLine(index);
//     }
//     index++;
// }

// Task 3 Работа с массивами
//метод заполнение массива проивольными числами
// void FillArray(int[] collection)
// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }
// //метод печатающий массив
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         System.Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int[] array = new int[10]; //задаем массив размером 10
// FillArray(array);
// PrintArray(array);

// Task 4 Работа с массивами2
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; //задаем массив размером 10
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int pos = IndexOf(array, 5);
System.Console.WriteLine(pos);