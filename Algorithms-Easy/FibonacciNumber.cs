namespace Algorithms_Easy;

public class FibonacciNumber
{
    /// <summary>
    /// Standart(Серый цвет). Простое сложение 2 приведущих индексов, решил в лоб но можно улучшить если запоминать результаты вычисления.
    /// </summary>
    /// <param name="n">Индекс в последовательности Фиббоначи, значение которого мы должны выяснить</param>
    /// <returns></returns>
    
    public int Fib(int n) {
        int sum = 0;
        
        if(n == 0)
            return 0;

        if (n == 1)
            return 1;
        
        sum += Fib(n - 1) + Fib(n - 2);
        
        return sum;
    }
 
    /// <summary>
    /// Best(Жёлтый цвет). Простое сложение 2 приведущих индексов, но теперь запоминаем результаты в переменных, что бы не вычислять значения.
    /// Условно: 3 индекс в последовательности это сложение 2 + 1 то есть можно запомнить текущий и приведущий для вычисление нового.
    /// </summary>
    /// <param name="n">Индекс в последовательности Фиббоначи, значение которого мы должны выяснить</param>
    /// <returns></returns>
    public int FibBetter(int n)
    {
        if (n <= 1)
            return n;

        int prev = 0;
        int current = 1;

        for (int i = 2; i <= n; i++)
        {
            int next = prev + current;

            prev = current;
            current = next;
        }

        return current;
    }
}