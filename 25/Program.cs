// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
Console.Clear();
Console.WriteLine("Введите два числа. Первое возводится в степень второго числа");
int fun ()
{
    return int.Parse(Console.ReadLine());
}
int osnov = fun();
int step = fun();
int rez = 1;
for (int n=0; n<step; n++)
{rez=rez*osnov;}
Console.WriteLine ($"Число {osnov} в степени {step} равно {rez}");