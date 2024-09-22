//1.Kalkulyator

Console.WriteLine("Raqamlarni kiriting: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());
double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Operatsiyani kiriting (+, -, *, /): ");
char operation = Console.ReadKey().KeyChar;
Console.WriteLine("");

double result = 0;
if (operation == '+')
{
    result = firstNumber + secondNumber;
}
else if (operation == '-')
{
    result = firstNumber - secondNumber;
}
else if (operation == '*')
{
    result = firstNumber * secondNumber;
}
else if (operation == '/')
{
    if(secondNumber != 0)
    {
        result = firstNumber / secondNumber;
    }
    else
    {
        Console.WriteLine("Nolga bo'lish mumkin emas!");
        return;
    }
}
else 
{
    Console.WriteLine("Bunday operatsiya bajarish mumkin emas");
    return;
}
Console.WriteLine("Natija: " + result);



//2.Raqamlar qatorining yig‘indisini hisoblash

Console.WriteLine("Musbat butun sonni kiriting: ");
int N = Convert.ToInt32(Console.ReadLine());

int yigindi = N * (N + 1) / 2;

Console.WriteLine($"1 dan {N} gacha bolgan sonlar yig'indisi: {yigindi}");



//3.Paritet tekshiruvi

Console.WriteLine("Istalgan raqamni kiriting: ");
int x = int.Parse(Console.ReadLine());

if(x%2 == 0)
{
    Console.WriteLine("Juft");
}
else
{
    Console.WriteLine("Toq");
}
