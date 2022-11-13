//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
Console.WriteLine("Программа создает и показывает массив длинной 8, заполненный случайными числами");

int [] array = new int [8];
int fun ()
{
    return new Random().Next (1,100);
}

for (int n=0; n<8; n++)
{
    array [n]=fun ();
}
for (int n=0; n<8; n++)
{
    Console.Write($"{array[n]}, ");
}