// Задача 1
Console.Write("Введите первое число: ");
int N1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int N2 = int.Parse(Console.ReadLine()!);
if (N1 > N2)
    Console.WriteLine("Первое число больше, а второе меньше.");
else
    Console.WriteLine("Второе число больше, а первое меньше.");

// Задача 2
Console.Write("Введите третье число: ");
int N3 = int.Parse(Console.ReadLine()!);
Console.Write("Максимальное число из трех: ");
if (N1>N2 && N1>N3)
{
    Console.Write("первое");
}
else if (N2>N1 && N2>N3)
{
    Console.Write("второе");
}
else if (N3>N1 && N3>N2)
{
    Console.Write("третье");
}
else 
{
    Console.Write("не единственное"); 
}       

// Задача 3
Console.Write($"\nЧисло {N1} является ");
if (N1%2==0)
{
 Console.Write("четным"); 
}
else
{
 Console.Write("нечетным"); 
}

// Задача 4
Console.Write("\nВведите число N: ");
N1 = int.Parse(Console.ReadLine()!);
int count=2;
while (count<=N1)
{
Console.Write($"{count}; ");
count+=2;
}

/*
while (A<=N)
{
Console.Write($"{A} ");
A++;
}

Console.Write ("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine ()!);

Console.Write (N%10);
*/
