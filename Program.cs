    //   Задайте прямоугольный двумерный массив. Написать программу которая будет находить строку с наименьшей суммой 
    //   элементов
Console.WriteLine("Введите количество строк");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int pol = Convert.ToInt32(Console.ReadLine());

int[,] GenAr() {
int[,] array = new int[str, pol];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
    }
} return array;
}

void PrintAr(int[,] array) {
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
    } Console.WriteLine();
} 

}

int Metretern(int[,] array) {
int resalt = 0;

 for (int i = 0; i < 1; i++)
{       
    
    for (int j = 0; j < array.GetLength(1); j++)
    { 
        
        resalt = resalt +  array[0,j];
    }
    
 }   return resalt;
 }

 int MinNamber(int[,] array) {
 int sum = 0;
 int res = Metretern(array);  


for (int i = 0; i < array.GetLength(0);)
{    
     
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
       
           sum += array[i,j];
           return sum;
           if (res > sum) res = sum;
 
    } 
 
} return res;
}


int[,] array = GenAr();
PrintAr(array);
int resalt = Metretern(array);
Console.WriteLine("Первая сумма -" +  resalt);
int res = MinNamber(array);
Console.WriteLine("Минимальная сумма -" +  res);