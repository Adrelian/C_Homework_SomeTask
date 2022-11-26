// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] CreatArray()
// Создаём массив из случайных и случайного размера
{
    
    //Задаём случайны размер
    int size = new Random().Next(5, 10); 
    int [] myArray = new int [size];

    // Задаём массив
    Console.Write("Массив -> ");
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(1, 100);
    }
    
    // Отображаем массив
    for (int i = 0; i < size; i++)
    {
        Console.Write($" {myArray[i] + ","}");
    }
    Console.WriteLine();
    return myArray;   
}

void multiplicationCoupleNumber(int[] array)
// ищем произведение пар чисел в массиве ([1,2,3,4] -> (1*4) (2*3))
{
    double multiply = 0;
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        Console.WriteLine ($"Произведение пары №{i+1} :{array[i]}*{array[j]} = {multiply = array[i] * array[j]}");
    }
}

multiplicationCoupleNumber(CreatArray());

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом



// 41. Выяснить являются ли три числа сторонами треугольника 