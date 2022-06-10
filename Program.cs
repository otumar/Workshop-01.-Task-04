Console.Write("Введите число => ");
string paramString = Console.ReadLine();
int Paramint1 = int.Parse(paramString);
int Paramint2 = 1;

while (Paramint2 < Paramint1)
{
    if (Paramint2 % 2 == 0)
    {
        Console.Write($"{Paramint2} ");
    }
    Paramint2 = Paramint2 + 1;   
}