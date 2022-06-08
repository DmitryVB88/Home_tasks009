// Показать натуральные числа от M до N, N и M заданы.

Console.Clear();
Console.Write("Введите число M: ");
void Numbers (int n, int m)
{
    if(n < m) Console.Write($"{n}, ");
    if(n == m) Console.Write($"{n}.");
    if(n > m) return;
    Numbers(n + 1, m);
}
Numbers (-5, 18);


