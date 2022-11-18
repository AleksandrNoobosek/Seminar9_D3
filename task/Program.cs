
int ReadIntegerNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Показать натуральные числа от M до N, N и M заданы
string NaturalNumbersMN(int M, int N)
{
    if (M<=N) return  NaturalNumbersMN(M, N-1) + $"{N} ";
return " ";
}
//Найти сумму элементов от M до N, N и M заданы
int SumMN(int M, int N)
{
    if (M == N) return N;
    else return N + SumMN(M, N - 1);
}
//Написать программу вычисления функции Аккермана
int AckermannF (int M, int N)
{
    if (M == 0) return N + 1;
    else if (M != 0 && N == 0) return AckermannF(M - 1, 1);
    else return AckermannF(M - 1, AckermannF(M, N - 1));
} 
//Написать программу возведения числа А в целую стень B
int Stepen (int A, int B)
{
    if (B == 0) return 1;
    else  return A * (Stepen (A, B-1));
} 
// Написать программу показывающие первые N чисел,  для которых каждое следующее равно сумме двух предыдущих. 
string FibonacciInput(int A, int B, int N)
{
    if (N == 0) return string.Empty;
    else return " " + A + FibonacciInput(B, A + B, --N);
}

Console.Clear();

//Показать натуральные числа от M до N, N и M заданы
Console.WriteLine("Показать натуральные числа от M до N, N и M заданы");
Console.WriteLine($"Hатуральные числа от M  до N :"+ NaturalNumbersMN(2, 4)+ "(N и M заданы)"); // 2 3 4   if(M<N)
Console.ReadKey();
Console.Clear();

//Найти сумму элементов от M до N, N и M заданы
Console.WriteLine("Найти сумму элементов от M до N, N и M заданы");
Console.WriteLine($"Cуммa элементов от M до N: " + SumMN(1, 4)+ "(N и M заданы)"); //10     if(M<N)
Console.ReadKey();
Console.Clear();

//Написать программу вычисления функции Аккермана
Console.WriteLine("Написать программу вычисления функции Аккермана");
int M = ReadIntegerNumber("Введите число М: ");
int N = ReadIntegerNumber("Введите число N: ");
// расчет ограничен при больших значениях
Console.WriteLine($"AckermannF({M},{N}) = {AckermannF(M, N)}"); // AckermannF(3,4) = 125
Console.ReadKey();
Console.Clear();

//Написать программу возведения числа А в целую стень B
Console.WriteLine("Написать программу возведения числа А в целую стень B");
int A = ReadIntegerNumber("Введите число A: ");
int B = ReadIntegerNumber("Введите число B: ");
Console.WriteLine($" ({A} в степени {B}) = {Stepen(A, B)}");

Console.ReadKey();
Console.Clear();

// Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем.

Console.WriteLine("Написать программу показывающие первые N чисел," 
+ "для которых каждое следующее равно сумме двух предыдущих.");

int a = ReadIntegerNumber("Введите число A: ");
int b = ReadIntegerNumber("Введите число B: ");
int n = ReadIntegerNumber("Введите число N: ");
Console.WriteLine ($"Результат:{FibonacciInput(a, b, n)}");

Console.ReadKey();
Console.Clear();
