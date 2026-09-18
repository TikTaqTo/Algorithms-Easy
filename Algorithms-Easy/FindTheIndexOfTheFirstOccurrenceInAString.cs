namespace Algorithms_Easy;

/// <summary>
/// 28. Find the Index of the First Occurrence in a String
/// Given two strings needle and haystack, return the index of the first occurrence of needle in haystack,
/// or -1 if needle is not part of haystack.
/// </summary>
public class FindTheIndexOfTheFirstOccurrenceInAString
{
    
    /// <summary>
    /// Standart(Базовое решение). Используем метод Substring который получает ближашие needle.length
    /// символы что бы сравнить подстроки и если есть полное совпадение вернуть результат.
    /// </summary>
    /// <param name="haystack">mississippi</param>
    /// <param name="needle">issipi</param>
    /// <returns>-1</returns>
    public int StrStr(string haystack, string needle)
    {
        if (needle.Length > haystack.Length)
            return -1;
        
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0] && haystack.Length - i >= needle.Length)
            {
                string substring = haystack.Substring(i, needle.Length);

                if (substring == needle)
                    return i;
            }
        }

        return -1;
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Лучшее решение по скорости.
    /// То же что я делал в Standart только с ограничением массива на уровне цикла а не внутренней проверки, выглядит более локанично.
    /// </summary>
    /// <param name="haystack">mississippi</param>
    /// <param name="needle">issipi</param>
    /// <returns>-1</returns>
    public int StrStrBestSpeed(string haystack, string needle) {
        for (int i = 0; i <= haystack.Length - needle.Length; i++) {
            if (haystack.Substring(i, needle.Length) == needle) {
                return i;
            }
        }
        return -1;
    }
    
    /// <summary>
    /// BestMemory(Лучшее по памяти - Синий). Лучшее решение по памяти.
    /// Используются только указатели без готового метода Substring, построчное сравнение каждого элемента через индексы.
    /// </summary>
    /// <param name="haystack">mississippi</param>
    /// <param name="needle">issipi</param>
    /// <returns>-1</returns>
    public int StrBestMemory(string haystack, string needle) {
        int hLen = haystack.Length;
        int nLen = needle.Length;
        if(nLen > hLen)
            return -1;
        for(int i = 0; i <= hLen - nLen; i++)
        {
            int j = 0;
            while(j < nLen && haystack[i+j] == needle[j])
            {
                j++;
            }
            if(j == nLen)
            {
                return i;
            }
        }
        return -1;
    }
}