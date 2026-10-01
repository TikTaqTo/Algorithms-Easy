namespace Algorithms_Easy;

/// <summary>
/// 345. Reverse Vowels of a String
/// Given a string s, reverse only all the vowels in the string and return it.
/// The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
/// </summary>
public class ReverseVowelsOfAString
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости - Жёлтый). Решение через 2 указателя которые
    /// двигаются к середине массива.
    /// </summary>
    /// <param name="s">"IceCreAm"</param>
    /// <returns>"AceCreIm"</returns>
    public string ReverseVowels(string s)
    {
        char temp;
        var vowels = new[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U', 'y', 'Y' };
        var arrayS = s.ToCharArray();
            
        for (int i = 0, j = s.Length - 1; i < j && j > i;)
        {
            if (vowels.Contains(arrayS[i]) && vowels.Contains(arrayS[j]))
            {
                temp = s[j];
                arrayS[j] = s[i];
                arrayS[i] = temp;
                i++;
                j--;
            }
            
            if (!vowels.Contains(arrayS[i]))
            {
                i++;
            }
            if (!vowels.Contains(arrayS[j]))
            {
                j--;
            }
        }

        return new string(arrayS);
    }
}