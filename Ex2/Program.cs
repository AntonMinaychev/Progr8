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

if (a == b)
Console.WriteLine("The number of rows is equal to the number of columns"); 
else

{    
int Sum = 0, Sum1 = int.MaxValue,  Sum2 = 0, Row = 0; // Объявление дополнительных служебных переменных

// Sum1 = int.MaxValue нужен для того, чтобы на первой итерации проверки сравнить сумму строки с максимально возможным в рамках int 
// тем самым сделав гарантированным непрохождение первого условия if 

for(int i = 0; i < a; i++) 
    {
        Sum2 = 0; // Обнуление для новой итерации
        for(int j = 0; j < b; j++) 
            {   Sum2 += arr[i, j];  } // Сумма элементов 1-й (нулевой) строки
            if(Sum2 > Sum1)
            {  Sum = Sum2; Row = i;} // Запоминаем номер строки и сохраняем сумму если находим что сумма больше предыдущей
            Sum1 = Sum2; // Возвращаемся к предыдущей сохраненной сумме если сумма строки НЕ больше
    }
            Console.WriteLine("\t Max sum is = {0}", Sum);
            Console.WriteLine("\t Number of line is = {0}", Row+1); // +1 чтобы не начинать отсчет с 0
}