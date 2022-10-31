/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
System.Console.Write("Введите M ");
int M = int.Parse(Console.ReadLine());
System.Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine());
void CreatStringMN(int M, int N, int sum = 0)
{
    if (M >= N)
    {System.Console.Write("выводим список натуральных элементов в промежутке от M до N : ");
        for(int i = N+1; i < M; i++)
        { sum = sum + N+1;
        N++;
        Console.Write($" {N}, ");
        }
    } 
    else
    {
        for(int i = M+1; i < N; i++)
        { sum = sum + M+1;
        M++;
        Console.Write($" {M}, ");
        }    
    }
System.Console.WriteLine();
System.Console.Write($"Cумма натуральных элементов в промежутке от M до N (не включая M и N) составляет : {sum}");
}
CreatStringMN(M,N);

