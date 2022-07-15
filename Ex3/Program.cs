// Для упрощения задачи представим, что обе матрицы квадратные

Console.WriteLine("Set the size of the square matrices"); 
int a = int.Parse(Console.ReadLine());
int[,] arr1 = new int[a, a];
int[,] arr2 = new int[a, a];
int[,] arr3 = new int[a, a];    
Random rnd = new Random(); 

Console.WriteLine("First matrix"); 
for (int i = 0; i<a; i++)  
{
    for (int j = 0; j<a; j++)
    {
       arr1[i, j] = rnd.Next(0,10); // Для облегчения значения 0-10
        Console.Write("{0}\t", arr1[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine("Second matrix"); 
for (int i = 0; i<a; i++)  
{
    for (int j = 0; j<a; j++)
    {
       arr2[i, j] = rnd.Next(0,10); // Для облегчения значения 0-10
       Console.Write("{0}\t", arr2[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine("Result matrix"); 
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < a; j++)
    {
        for (int k = 0; k < a; k++)
        {
            arr3[i, j] += arr1[i, k] * arr2[k, j]; // "складываем" с присвоением в arr3 нужное произведение
        }
        Console.Write("{0}\t", arr3[i, j]);    // Вывод самих значений
    }
    Console.WriteLine(); // Перевод строки
}