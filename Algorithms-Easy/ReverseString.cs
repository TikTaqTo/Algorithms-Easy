namespace Algorithms_Easy;

/// <summary>
/// 344. Reverse String
/// Write a function that reverses a string. The input string is given as an array of characters s.
/// You must do this by modifying the input array in-place with O(1) extra memory.
/// </summary>
public class ReverseString
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости). Решаем через 2 указателя.
    /// 1) i идёт с начало массива, j с конца.
    /// </summary>
    /// <param name="s">['t','a','p']</param>
    /// <returns>['p','a','t']</returns>
    public void ReverseStringAnswer(char[] s)
    {
        char temp;

        for (int i = 0, j = s.Length - 1; i <= j; i++, j--)
        {
            temp = s[i];
            s[i] = s[j];
            s[j] = temp;
        }
    }
}