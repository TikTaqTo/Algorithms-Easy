namespace Algorithms_Easy;

/// <summary>
/// 58. Length of Last Word
/// Given a string s consisting of words and spaces, return the length of the last word in the string.
/// A word is a maximal substring consisting of non-space characters only.
/// </summary>
public class LengthOfLastWord
{
    
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости). Проходимся с конца строки до тех пор пока не встретим ' '.
    /// </summary>
    /// <param name="s">"   fly me   to   the moon  "</param>
    /// <returns></returns>
    public int LengthOfLastWordAnswer(string s)
    {
        int result = 0;

        for (int i = s.Length-1; i >= 0; i--)
        {
            if (s[i] == ' ' && result == 0)
                continue;

            if (s[i] == ' ' && result > 0)
                return result;

            result++;
        }
        
        return result;
    }
}