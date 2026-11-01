using System.Text;

namespace Algorithms_Easy;

/// <summary>
/// 2000. Reverse Prefix of Word
/// Given a 0-indexed string word and a character ch, reverse the segment of word that starts at index 0 and ends
/// at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
/// For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive).
/// The resulting string will be "dcbaefd".
/// Return the resulting string.
/// </summary>
public class ReversePrefixOfWord
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости - Жёлтый). Решение через вложенный цикл
    /// 1) Ищём букву первым циклом, если нашли начинаем добавлять в новую строку в обратном порядке
    /// 2) Отсавшиеся символы добавляем через Substring
    /// </summary>
    /// <param name="word">"abcdefd"</param>
    /// <param name="ch">"d"</param>
    /// <returns>"dcbaefd"</returns>
    public string ReversePrefix(string word, char ch)
    {
        StringBuilder result = new StringBuilder();
        int findedIndex = -1;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == ch)
            {
                for (int j = i; j >= 0; j--)
                {
                    result.Append(word[j]);
                }

                findedIndex = i;
                break;
            }
        }

        if (findedIndex == -1)
            return word;
        

        result.Append(word.Substring(findedIndex + 1));

        return result.ToString();
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Решение через готовые методы C#
    /// </summary>
    /// <param name="word">"abcdefd"</param>
    /// <param name="ch">"d"</param>
    /// <returns>"dcbaefd"</returns>
    public string ReversePrefixBestSpeed(string word, char ch)
    {
        int index = word.IndexOf(ch);
        if(index == -1) 
            return word;

        char[] arr = word.ToCharArray();
        Array.Reverse(arr,0,index+1);

        return new string(arr);
    }
}