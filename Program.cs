// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// int[] CreatArray()
// // Создаём массив из случайных и случайного размера
// {
//     //Задаём случайны размер
//     int size = new Random().Next(5, 10); 
//     int [] myArray = new int [size];

//     // Задаём массив
//     Console.Write("Массив -> ");
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(1, 100);
//     }
    
//     // Отображаем массив
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($" {myArray[i] + ","}");
//     }
//     Console.WriteLine();
//     return myArray;   
// }

// void multiplicationCoupleNumber(int[] array)
// // ищем произведение пар чисел в массиве ([1,2,3,4] -> (1*4) (2*3))
// {
//     double multiply = 0; // переменная для произведений
//     for (int i = 0, j = array.Length - 1; i < j; i++, j--)
//     {
//         Console.WriteLine ($"Произведение пары №{i+1} :{array[i]}*{array[j]} = {multiply = array[i] * array[j]}");
//     }
// }

// multiplicationCoupleNumber(CreatArray());

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// void CreatArray()
// // Создаём массив из случайных и случайного размера
// {
//     //Задаём случайны размер
//     int size = new Random().Next(5, 10); 
//     int [] myArray = new int [size];

//     // Задаём массив
//     Console.Write("Массив -> ");
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(1, 100);
//     }
    
//     // Отображаем массив
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($" {myArray[i] + ","}");
//     }
//     Console.WriteLine();
// }


// 41. Выяснить являются ли три числа сторонами треугольника 

// void inputLengthTriangleSide(int a, int b, int c)
// {
//     if ((a+b>c) && (b+c>a) && (c+a)>b) 
//     {
//         Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует");
//     }
//     else Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} НЕ существует");
//     }

// Console.Write("Введите сторону а: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите сторону b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите сторону c: ");
// int c = Convert.ToInt32(Console.ReadLine());

// inputLengthTriangleSide(a, b, c);


// 30. Показать кубы чисел, заканчивающихся на четную цифру

// double [] CreatArray()
// // Создаём массив из случайных и случайного размера
// {
//     //Задаём случайны размер
//     int size = new Random().Next(5, 10); 
//     double [] myArray = new double [size];

//     // Задаём массив
//     Console.Write("Массив -> ");
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(1, 100);
//     }
    
//     // Отображаем массив
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($" {myArray[i] + ","}");
//     }
//     Console.WriteLine();
//     return myArray;
// }

// // Создаём новый массив из кубов чисел прошлого массива
// double[] CubeNumber (double [] cubeArray)
// {
//     // Возводим каждый элемент в куб
//     for(int i = 0; i < cubeArray.Length; i++)
//     {
//         cubeArray[i] = Math.Pow(cubeArray[i], 3);
//     }
//     // Отображаем массив
//     Console.Write("Массив -> ");
//     for (int i = 0; i < cubeArray.Length; i++)
//     {
//         Console.Write($" {cubeArray[i] + ","}");
//     }
//     Console.WriteLine();
//     return cubeArray;
// }

// // Поиск элементов с чётным последним числом
// void findEvenLastNumber(double [] cubeArray)
// {
//     for(int i = 0; i < cubeArray.Length; i++)
//     {
//         if (cubeArray[i] % 2 == 0) 
//         Console.WriteLine($"Число {cubeArray[i]} - цифра {cubeArray[i]%10} чётное");
//     }
// }

// double [] myArray = CreatArray();
// double [] cube = CubeNumber(myArray);
// findEvenLastNumber(cube);

// 43. Написать программу преобразования десятичного числа в двоичное

void decimalToBool(int number)
{
    // Двоичное число, но задом наперёд
    int boolNumber = 0; // двоичное число
    int numberForChange = number; // создаём число для изменений, что бы введёное не
    while (numberForChange>0)
    {
        int numberBool = (numberForChange % 2);
        numberForChange = numberForChange / 2;
        boolNumber = boolNumber * 10 + numberBool;
    }

    // Разворот двоичного числа
    int newBoolNumber = 0; // новопе (правильное) двоичное число
    int wronghtBoolNumber = boolNumber; // присваиваем неверному числу (для изменения) полученное число из цикла выше

    // После каждой иттерации уменьшаем неверное число на 1 разряд
    while (wronghtBoolNumber > 0)
    {
        int alongBoolNumber = wronghtBoolNumber % 10; // берём правое число
        wronghtBoolNumber = wronghtBoolNumber / 10; // уменьшаем разряд на 1
        newBoolNumber = newBoolNumber * 10 + alongBoolNumber; //собираем новое двоичное число ПРАВИЛЬНОЕ
    }
    Console.WriteLine($"{number} -> {newBoolNumber}");
}

Console.Write("Введите число: ");
int decNumber = Convert.ToInt32(Console.ReadLine());
decimalToBool(decNumber);