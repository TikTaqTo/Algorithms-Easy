using System.Text;

namespace Algorithms_Easy;

/// <summary>
/// 2108. Find First Palindromic String in the Array
/// Given an array of strings words, return the first palindromic string in the array. If there is no such string, return an empty string "".
/// A string is palindromic if it reads the same forward and backward.
/// </summary>
public class FindFirstPalindromicStringInTheArray
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости - Жёлтый). Решил через 2 переменные и цикл в цикле
    /// 1) Создаём 2 переменные i и j для проверки слов на палиндром
    /// 2) Циклом проходимся по массиву слов, каждое слово проверяем через 2 указателя от начала и конца
    /// 3) Если указатели ровны или левый указатель i > указателя j (для чётного колл символов) говорим что это палиндром
    /// </summary>
    /// <param name="words">["abc","car","ada","racecar","cool"]</param>
    /// <returns>"ada"</returns>
    public string FirstPalindrome(string[] words)
    {
        int i = 0;
        int j = 0;
        
        foreach (var word in words)
        {
            for (i = 0, j = word.Length - 1; i < j; i++, j--)
            {
                if (word[i] != word[j])
                    break;
            }

            if (i == j)
                return word;
        }
        
        return "";
    }
}