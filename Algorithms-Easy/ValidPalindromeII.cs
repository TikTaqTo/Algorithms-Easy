namespace Algorithms_Easy;

/// <summary>
/// 680. Valid Palindrome II
/// Given a string s, return true if the s can be palindrome after deleting at most one character from it.
/// </summary>
public class ValidPalindromeII
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости - Жёлтый). Решаем через 2 указателя.
    /// 1) Ставим по указателю с начало и конца строки.
    /// 2) При несоответсвий s[i] != s[j] проверяем i+1 ведь указатель идёт с начало строки j-1 ведь указатель идёт с конца строки.
    /// </summary>
    /// <param name="s">"abca"</param>
    /// <returns>true</returns>
    public bool ValidPalindrome(string s)
    {
        int i = 0;
        int j = s.Length - 1;

        while (i < j)
        {
            if (s[i] != s[j])
            {
                return IsPalindrome(s, i + 1, j) ||
                       IsPalindrome(s, i, j - 1);
            }

            i++;
            j--;
        }

        return true;
    }
    
    private bool IsPalindrome(string s, int i, int j)
    {
        while (i < j)
        {
            if (s[i] != s[j])
                return false;

            i++;
            j--;
        }

        return true;
    }
}