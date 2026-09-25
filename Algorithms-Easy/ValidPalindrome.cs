using System.Text.RegularExpressions;

namespace Algorithms_Easy;

/// <summary>
/// 125. Valid Palindrome
/// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric
/// characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
/// Given a string s, return true if it is a palindrome, or false otherwise.
/// </summary>
public class ValidPalindrome
{
    
    /// <summary>
    /// Standart(Базовое решение). Удаляем спец символы, приводим строку к нижнему регистру и проверяем каждый символ с 2 сторон.
    /// </summary>
    /// <param name="s">A man, a plan, a canal: Panama</param>
    /// <returns>true</returns>
    public bool IsPalindrome(string s)
    {
        string normalizedS = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();

        for (int i = 0, j = normalizedS.Length - 1; i < j; i++, j--)
        {
            if (normalizedS[i] != normalizedS[j])
                return false;
        }

        return true;
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Не удаляем спец символы а просто проходим через них, сравнение с 2 сторон.
    /// </summary>
    /// <param name="s">A man, a plan, a canal: Panama</param>
    /// <returns>true</returns>
    public bool IsPalindromeBestSpeed(string s) {
        short left = 0;
        short right = (short)(s.Length - 1);

        while (left < right) {
            if (!char.IsLetterOrDigit(s[left])) {
                left++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[right])) {
                right--;
                continue;
            }

            if (char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right]))
                return false;
            
            left++;
            right--;
        }

        return true;
    }
}