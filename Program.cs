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

 int[] SumNamberArray(int[,] array) {
 int[] SumArray = new int[array.GetLength(0)];
 for (int i = 0; i < array.GetLength(0); i++)
 {
     int sum = 0;
     for (int j = 0; j < array.GetLength(1); j++)
     {
         sum +=array[i,j];
     }
     SumArray[i] = sum;

 } return SumArray;
 }

 int Count (int[] SumArray, int resalt) {
int min = resalt;
for (int i = 0; i < SumArray.Length; i++)
{
    if(min >= SumArray[i]) min = SumArray[i];
} return min;

 }

int CountString(int[] SumArray, int min) {
int namber = 0;
for (int i = 0; i < SumArray.Length; i++)
{
    if(SumArray[i] == min) namber = i + 1;
    
} return namber;

 }



int[,] array = GenAr();
PrintAr(array);
int resalt = Metretern(array);
Console.WriteLine("Первая сумма -" +  resalt);

int[] SumArray = SumNamberArray(array);
for (int i = 0; i < SumArray.Length; i++)
{
    Console.Write(SumArray[i] + " ");
}
int min1 = Count (SumArray, resalt);
Console.WriteLine("Минимальная сумма - " + min1);
int namber = CountString(SumArray, min1);
Console.WriteLine("Строка с минимальной  суммой - " + namber);
