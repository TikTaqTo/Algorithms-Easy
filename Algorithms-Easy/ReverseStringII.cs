using System.Text;

namespace Algorithms_Easy;

/// <summary>
/// 541. Reverse String II
/// Given a string s and an integer k, reverse the first k characters for every 2k characters counting from the start of the string.
/// If there are fewer than k characters left, reverse all of them.
/// If there are less than 2k but greater than or equal to k characters,
/// then reverse the first k characters and leave the other as original.
/// </summary>
public class ReverseStringII
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости - Жёлтый). Решение через Array.Reverse()
    /// </summary>
    /// <param name="s">"abcd"</param>
    /// <param name="k">2</param>
    /// <returns>"bacd"</returns>
    public string ReverseStr(string s, int k)
    {
        char[] chars = s.ToCharArray();

        int stringLength = chars.Length;

        for (int startIndex = 0; startIndex < stringLength; startIndex += 2 * k)
        {
            int endIndex = Math.Min(startIndex + k, stringLength);

            Array.Reverse(
                chars,
                startIndex,
                endIndex - startIndex
            );
        }

        return new string(chars);
    }
}