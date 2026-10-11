using System.Security.AccessControl;

namespace Algorithms_Easy;

/// <summary>
/// 821. Shortest Distance to a Character
/// Given a string s and a character c that occurs in s, return an array of integers answer where answer.
/// length == s.length and answer[i] is the distance from index i to the closest occurrence of character c in s.
/// The distance between two indices i and j is abs(i - j), where abs is the absolute value function.
/// </summary>
public class ShortestDistanceToACharacter
{
    /// <summary>
    /// Standart(Базовое решение). Проходимся с 2 частей 2 циклами, после получаем минимальное расстояние.
    /// </summary>
    /// <param name="s">"loveleetcode"</param>
    /// <param name="c">'e'</param>
    /// <returns>[3,2,1,0,1,0,0,1,2,2,1,0]</returns>
    public int[] ShortestToChar(string s, char c)
    {
        int n = s.Length;
        int[] res = new int[n];

        int distance = n;

        for (int i = 0; i < n; i++)
        {
            if (s[i] == c)
                distance = 0;
            else
                distance++;

            res[i] = distance;
        }

        distance = n;

        for (int i = n - 1; i >= 0; i--)
        {
            if (s[i] == c)
                distance = 0;
            else
                distance++;

            res[i] = Math.Min(res[i], distance);
        }

        return res;
    }
}