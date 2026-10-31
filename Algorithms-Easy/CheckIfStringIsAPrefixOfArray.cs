using System.Text;

namespace Algorithms_Easy;

/// <summary>
/// 1961. Check If String Is a Prefix of Array
/// Given a string s and an array of strings words, determine whether s is a prefix string of words.
/// A string s is a prefix string of words if s can be made by concatenating the first k strings in words for some positive k no larger than words.length.
/// Return true if s is a prefix string of words, or false otherwise.
/// </summary>
public class CheckIfStringIsAPrefixOfArray
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости - Жёлтый). Решение через новую строку
    /// 1) Создаём новую строку которую приводим к виду непрерывной как написано в s
    /// 2) В какой то момент строка, должна прийти к точному виду s, если он пришёл то true иначе false
    /// </summary>
    /// <param name="s">"iloveleetcode"</param>
    /// <param name="words">["i","love","leetcode","apples"]</param>
    /// <returns>true</returns>
    public bool IsPrefixString(string s, string[] words)
    {
        StringBuilder currentStr = new StringBuilder();

        foreach (string word in words) {
            currentStr.Append(word);

            if (currentStr.ToString() == s) {
                return true;
            }
            if (currentStr.Length > s.Length) {
                break;
            }
        }

        return false;
    }
}