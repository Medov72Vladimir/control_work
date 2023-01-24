// Задача.
// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых <= 3 символа.
int N = 4; 
string[] array = new string[N];
string[] secondarray = new string[N];
int number = 0;
int j = 0;
for( int i = 0; i < N; i++)
{
    Console.Write($"Введите {i+1} элемент массива -> ");
    array[i] = Console.ReadLine()??"";
    number = array[i].Length;
    if( number <= 3)
    {
     secondarray[j] = array[i]; j++;
    }
}
Console.Write("Искомый массив -> [");
for(int k = 0; k < secondarray.Length; k++)
{
 Console.Write(secondarray[k]+" ");
}
Console.WriteLine("]");
