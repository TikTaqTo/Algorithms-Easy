using System.Text;

namespace Algorithms_Easy;

/// <summary>
/// 1768. Merge Strings Alternately
/// You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1.
/// If a string is longer than the other, append the additional letters onto the end of the merged string.
/// Return the merged string.
/// </summary>
public class MergeStringsAlternately
{
    /// <summary>
    /// Standart(Базовое решение). Решаем через 2 переменные и оператор ||
    /// 1) Используем 2 переменные: i для word1 и j для word2
    /// 2) Оператором || проверяем что оба счётчика прошлись по всему слову
    /// </summary>
    /// <param name="word1">"abc"</param>
    /// <param name="word2">"pqr"</param>
    /// <returns>"apbqcr"</returns>
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder result = new StringBuilder();
        int i = 0;
        int j = 0;

        while (i < word1.Length || j < word2.Length)
        {
            if (i < word1.Length)
            {
                result.Append(word1[i]);
                i++;
            }

            if (j < word2.Length)
            {
                result.Append(word2[j]);
                j++;
            }
        }
        
        return result.ToString();
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Решение через вычисление короткого и длинного
    /// 1) Узнаём какой больше а какой меньше: minLength и maxLength
    /// 2) Проверка на случай пустых строк
    /// 3) Проверяем дошёл ли указатель до минимальной границы, после добавляем то что осталось.
    /// </summary>
    /// <remarks>
    /// Странно что LeetCode считает это решение быстрее моего, ведь условий тут больше :(
    /// Так же + используется обычная строка которая не резервирует память под новые символы из за чего с каждым символом пересоздаётся.
    /// </remarks>
    /// <param name="word1">"abc"</param>
    /// <param name="word2">"pqr"</param>
    /// <returns>"apbqcr"</returns>
    public string MergeAlternatelyBestSpeed(string word1, string word2) {
        var z = "";
        int maxLength = Math.Max(word1.Length, word2.Length);
        int minLength = Math.Min(word1.Length, word2.Length);
        if(word1 == "" && word2 == ""){return "";}
        for(int i = 0; i<maxLength; i++){
            if(i < word1.Length){z+=word1[i];}
            if(i < word2.Length){z+=word2[i];}

            if(i == minLength){
                if(word1.Length > minLength){
                    z+=word1.Substring(i+1);
                }
                if(word2.Length > minLength){
                    z+=word2.Substring(i+1);
                }
                break;
            }
        }
        return z;
    }
}