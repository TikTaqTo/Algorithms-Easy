namespace Algorithms_Easy;

/// <summary>
/// 1455. Check If a Word Occurs As a Prefix of Any Word in a Sentence
/// Given a sentence that consists of some words separated by a single space, and a searchWord,
/// check if searchWord is a prefix of any word in sentence.
/// Return the index of the word in sentence (1-indexed) where searchWord is a prefix of this word.
/// If searchWord is a prefix of more than one word, return the index of the first word (minimum index).
/// If there is no such word return -1.
/// A prefix of a string s is any leading contiguous substring of s.
/// </summary>
public class CheckIfAWordOccursAsAPrefixOfAnyWordInASentence
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости). Решил через вложенные циклы
    /// 1) Цикл идёт по символьно до тех пор пока не встречает ' ' или searchWord[0]
    /// 2) Если встретили искомый символ, начинаем перечисление и если совпадает j == searchWord.length то возвращаем результат.
    /// </summary>
    /// <param name="sentence">i love eating burger</param>
    /// <param name="searchWord">burg</param>
    /// <returns>3</returns>
    public int IsPrefixOfWord(string sentence, string searchWord)
    {
        int wordIndex = 1;
        int i = 0;

        while (i < sentence.Length)
        {
            int j = 0;
            int t = i;

            while (j < searchWord.Length && t < sentence.Length && sentence[t] == searchWord[j])
            {
                j++;
                t++;
            }

            if (j == searchWord.Length)
            {
                return wordIndex;
            }

            while (i < sentence.Length && sentence[i] != ' ')
            {
                i++;
            }

            if (i < sentence.Length && sentence[i] == ' ')
            {
                wordIndex++;
                i++;
            }
        }

        return -1;
    }
}