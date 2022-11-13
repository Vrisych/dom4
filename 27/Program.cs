// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine("Введите натуральное число и я покажу сумму его цифр");
int num = int.Parse(Console.ReadLine());
int end = (int)Math.Log10(num) + 2;
int rez = 0;
int fun (int per1, int per2)
{
    int i = (int)Math.Pow(10, per2);
    int k= per1/(i/10);
    per1 = k%10;
    return per1;
}
for (int n=1; n<end; n++)
{
    rez = fun (num, n)+rez;
}

Console.WriteLine ($"Сумма чисел равна {rez}");