/*
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
int[] RandomArray(int size){
    int[] array = new int[size];
    for (int i=0; i < size; i++){
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

void ShowArray(int[] array){
    int n = 0;
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++){
        Console.Write(array[i]+" ");
        int num = array[i] % 2; 
        if (num == 0){
            n += 1;}
    }
    Console.Write("]");
    Console.WriteLine(" ");
    Console.WriteLine($"Количество четных чисел в массиве равно {n}");
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(RandomArray(size));

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] RandomArray(int size){
Console.Write("Введите минимальное значение элементов массива: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элементов массива: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i=0; i < size; i++){
        array[i] = new Random().Next(min,max);
    }
    return array;
}

void ShowArray(int[] array){
    int sum = 0;
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++){
        Console.Write(array[i]+" ");
        int num = i % 2; 
        if (num > 0){
            sum += array[i];}
    }
    Console.Write("]");
    Console.WriteLine(" ");
    Console.WriteLine($"Сумму элементов массива, стоящих на нечётных позициях равна {sum}");
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(RandomArray(size));
*/
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] RandomArray(int size){
Console.Write("Введите минимальное значение элементов массива: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элементов массива: ");
    int max = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[size];
    Random rand = new Random();
    for (int i=0; i < size; i++){
       array[i] = rand.Next(min,max) + rand.NextDouble();
    }
    return array;
}

void ShowArray(double[] array){
    double diff = 0;
    double max1 = array[0];
    double min1 = array[0];
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++){
        
        Console.Write(array[i]+" ");
        if (array[i] > max1) max1 = array[i];
        if (array[i] < min1) min1 = array[i];
        
    }
    diff = max1 - min1;
    Console.Write("]");
    Console.WriteLine(" ");
    Console.WriteLine($"Разница между максимальным {max1}  и минимальным {min1} элементами массива равна {diff}");
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(RandomArray(size));