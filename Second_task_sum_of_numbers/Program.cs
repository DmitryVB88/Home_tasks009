// Найти сумму элементов от M до N, N и M заданы.

int SumOfNumbers (int m, int n)
{ 
    if(m == n) return n;
    else return m + SumOfNumbers(m+1, n); 
}

Console.WriteLine(SumOfNumbers(1, 4));
