//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.Использовать рекурсию, не использовать циклы.


//void NaturalNumbers(int M, int N)
//{
//  if (M == N)
//    {
//        Console.Write(M);
//        return;
//    }
//    Console.Write(M + " ");
//    NaturalNumbers(M + 1, N);
//}
//NaturalNumbers(5, 50);

//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void PrinReversedArray(int[] array, int z)
{
    if (z == 0)
    {
        Console.Write(array[z]);
        return;
    }
    Console.Write(array[z] - 1);
}
PrinReversedArray(new int[] { 1, 2, 3, 4 });