namespace Algorithms_Easy;

/// <summary>
/// 392. Is Subsequence
/// Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
/// A subsequence of a string is a new string that is formed from the original string by deleting some (can be none)
/// of the characters without disturbing the relative positions of the remaining characters.
/// (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
/// </summary>
public class IsSubsequence
{
    /// <summary>
    /// Standart(Базовое решение). Каждому массиву по указателю, используем счётчик для результата.
    /// 1) Каждому по указателю.
    /// 2) Счётчик используем в качестве проверки на результат.
    /// </summary>
    /// <param name="s">"abc"</param>
    /// <param name="t">"ahbgdc"</param>
    /// <returns>true</returns>
    public bool IsSubsequenceAnswer(string s, string t)
    {
        int counter = 0;
        
        for (int i = 0, j = 0; i < s.Length & j < t.Length; j++)
        {
            if (s[i] == t[j])
            {
                i++;
                counter++;
            }
        }
        
        return counter == s.Length;
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости). Каждому массиву по указателю, используем счётчик для результата.
    /// 1) Каждому по указателю.
    /// 2) Счётчик используем в качестве проверки на результат.
    /// 3) Прерываем как только есть соотвествие: indexEntry == s.Length значит всю начальную строку нашли.
    /// </summary>
    /// <param name="s">"abc"</param>
    /// <param name="t">"ahbgdc"</param>
    /// <returns>true</returns>
    public bool IsSubsequenceAnswerBestSpeed(string s, string t)
    {
        int read = 0, indexEntry = 0;

        if(s.Length == 0)
            return true;

        while (read < t.Length) {
            if (t[read] == s[indexEntry]) {
                indexEntry++;
                if(indexEntry == s.Length)
                    return true;
            }
            read++;
        }
        return false;
    }
}