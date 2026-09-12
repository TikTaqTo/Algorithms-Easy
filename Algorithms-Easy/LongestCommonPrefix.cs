namespace Algorithms_Easy;


/// <summary>
/// 14. Longest Common Prefix
/// Write a function to find the longest common prefix string amongst an array of strings.
/// If there is no common prefix, return an empty string "".
/// </summary>
public class LongestCommonPrefix
{
    /// <summary>
    /// Standart(Базовое решение). Получаем самое короткое слово, после проходимся по остальным элементам и ищем префикс.
    /// </summary>
    /// <param name="strs">["flower","flight","flow"] => "fl"</param>
    /// <returns>"fl"</returns>
    public string LongestCommonPrefixAnswer(string[] strs)
    {
        string[] sortedStrs = strs.OrderBy(w => w.Length).ToArray();
        string result = sortedStrs[0];
        
        for (int i = sortedStrs.Length-1; i > 0; i--)
        {
            for (int j = 0; j < sortedStrs[i].Length; j++)
            {
                if (j > result.Length-1 || sortedStrs[i][j] != result[j])
                {
                    result = result.Substring(0, j);
                    break;
                }
            }
        }

        return result;
    }
}