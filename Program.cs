//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.Использовать рекурсию, не использовать циклы.

void NaturalNumbers(int M, int N)
{
 if (M == N)
   {
       Console.Write(M);
       return;
   }
   Console.Write(M + " ");
   NaturalNumbers(M + 1, N);
}
NaturalNumbers(100, 50);



//Заадча 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void PrintReversedArray(int[] array, int z)
{
    if (z == 0)
    {
        Console.Write(array[z]);
        return;
    }
    PrintReversedArray(array, z - 1);
    Console.Write(" " + array[z]);
}
int[] array = new int[] { 100, 2, 3, 33, };
PrintReversedArray(array, array.Length - 1);



//Задача 2:Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
int Akkerman(int m, int n)
{
     if(m == 0)
	{
	   return n + 1;
	}
      if(m > 0 && n == 0)
	{
	   return Akkerman(m - 1, 1);
	}
           return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine(Akkerman(2,2));
        


