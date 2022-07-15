int[,] arr1 = new int[4, 4];

// Посмотрев множество решений задачи с "разворотами" индекса и введением кучи дополнительных переменных
// и учитывая то, что размер матрицы заранее для задачи известен, решил заполнять ее "поэтапно",
// что является очень костыльным решением, но рабочим и придуманным самостоятельно. 

for (int i = 0; i<4; i++)  // C первой строкой никаких проблем
{
    Console.WriteLine("Enter a number"); 
    arr1[0, i]= int.Parse(Console.ReadLine());
}

for (int i = 1; i<4; i++)  // Заполняем правый столбец "ниже" 1-го элемента
{
    Console.WriteLine("Enter a number"); 
    arr1[i, 3]= int.Parse(Console.ReadLine());
}

for (int j = 2; j>-1; j--)  // Заполняем "оставшиеся" элементы нижней строки (реверс)
{
    Console.WriteLine("Enter a number"); 
    arr1[3, j]= int.Parse(Console.ReadLine());
}

// На этом этапе заполнено уже больше половины массива, ура!!!

for (int i = 2; i>0; i--)  // Вписываем оставшиеся 2 элемента 1-го столбца (реверс)
{
    Console.WriteLine("Enter a number"); 
    arr1[i, 0]= int.Parse(Console.ReadLine());
}

for (int i = 1; i<3; i++)  // Во второй строке осталось два элемента
{
    Console.WriteLine("Enter a number"); 
    arr1[1, i]= int.Parse(Console.ReadLine());
}

for (int j = 2; j>0; j--)  // "добиваем" третью строку (реверс)
{
    Console.WriteLine("Enter a number"); 
    arr1[2, j]= int.Parse(Console.ReadLine());
}

Console.WriteLine("Spiral array is:"); 
for (int i = 0; i<4; i++)  
{
    for (int j = 0; j<4; j++)
    {
        Console.Write("{0}\t", arr1[i, j]);
    }
    Console.WriteLine();
}