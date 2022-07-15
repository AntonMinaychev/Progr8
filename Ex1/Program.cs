Console.WriteLine("Set the vertical size of the array"); 
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Set the horizontal size of the array"); 
int b = int.Parse(Console.ReadLine());
int[,] arr = new int[a, b]; 

Random rnd = new Random(); 

for (int i = 0; i<a; i++)  
{
    for (int j = 0; j<b; j++)
    {
       arr[i, j] = rnd.Next(-500,500); 
        Console.Write("{0}\t", arr[i, j]);
    }
    Console.WriteLine();
}

int[] temp = new int[b]; // Инициализация временного одномерного массива, внутри которого будет производится сортировка 

Console.WriteLine("Sorted array:"); 

for (int i = 0; i < b; i++)
{
    for (int j = 0; j < b; j++)
    temp[j] = arr[i, j];
    Array.Sort(temp);    // Сортировка Sort по возрастанию
    Array.Reverse(temp);  // Реверс для убывания
    for (int k = 0; k < b; k++)
        {
            // "Подменяем" линию нашего массива через одномерный
            arr[i, k] = temp[k];
            Console.Write("{0}\t", arr[i, k]);
        }
Console.WriteLine();
}