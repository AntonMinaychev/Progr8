// Для упрощения задачи представим, массив кубический
Console.WriteLine("Set the size of the cubical array"); 
int a = int.Parse(Console.ReadLine());
int[,,] arr = new int[a, a, a];
int[] arr2 = new int[a*a*a];
Random rnd = new Random(); 

for (int i = 0; i<a; i++)  // Задаем массив
{
    for (int j = 0; j<a; j++)
    {
        for (int k = 0; k<a; k++)
        {
            arr[i, j, k] = rnd.Next(10,99); // Двузначные числа
        }
    }
}

for (int i = 0; i<a; i++)  
{
    for (int j = 0; j<a; j++)
    {
        for (int k = 0; k<a; k++)
        {
            arr2[i+j+k] = arr[i, j, k]; // Заносим в одномерный массив значения
            Console.Write(arr2[i+j+k]); // Сразу же выводим
            Console.Write($" ({i},{j},{k}) ");
        }
    }
}

