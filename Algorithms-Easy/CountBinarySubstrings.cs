namespace Algorithms_Easy;

/// <summary>
/// 696. Count Binary Substrings
/// Given a binary string s, return the number of non-empty substrings that have the same number of 0's and 1's,
/// and all the 0's and all the 1's in these substrings are grouped consecutively.
/// Substrings that occur multiple times are counted the number of times they occur.
/// </summary>
public class CountBinarySubstrings
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости - Жёлтый). Решение через подсчёт групп 0 и 1
    /// </summary>
    /// <param name="s">0011</param>
    /// <returns>2</returns>
    public int CountBinarySubstringsAnswer(string s) {
        int ans = 0;
        int prev = 0;
        int curr = 1;
        
        for (int i = 1; i < s.Length; i++) {
            if (s[i] == s[i - 1]) {
                curr++;
            } else {
                ans += Math.Min(prev, curr);
                prev = curr;
                curr = 1;
            }
        }
        
        ans += Math.Min(prev, curr);
        return ans;
    }
}