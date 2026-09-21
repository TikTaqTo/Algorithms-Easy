namespace Algorithms_Easy;

/// <summary>
/// 69. Sqrt(x)
/// Given a non-negative integer x, return the square root of x rounded down to the nearest integer.
/// The returned integer should be non-negative as well.
/// You must not use any built-in exponent function or operator.
/// For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.
/// </summary>
public class Sqrt
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости). Решаем через формулу герона, понимаем когда значение ближе всего
    /// к результату когда разница между последними вычислениями и пред последними меньше погрешности
    /// </summary>
    /// <param name="x">4</param>
    /// <returns>2</returns>
    public int MySqrt(int x)
    {
        double current = x / 2.0;
        double previous;
        double epsilon = 1e-15; 

        do
        {
            previous = current;
            current = 0.5 * (previous + x / previous);
        }
        while (Math.Abs(current - previous) > epsilon);
        

        return (int)Math.Floor(current);
    }
}