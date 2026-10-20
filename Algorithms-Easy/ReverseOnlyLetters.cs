namespace Algorithms_Easy;

/// <summary>
/// 917. Reverse Only Letters
/// Given a string s, reverse the string according to the following rules:
/// All the characters that are not English letters remain in the same position.
/// All the English letters (lowercase or uppercase) should be reversed.
/// Return s after reversing it.
/// </summary>
public class ReverseOnlyLetters
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости - Жёлтый). Решение через 2 указаетля и пропуск символов
    /// 1) Ставим 2 указателя и двигаем их в направлений друг друга
    /// 2) Если символ является буквой, то мы меняем местами, если нет то пропускаем
    /// </summary>
    /// <param name="s">"ab-cd"</param>
    /// <returns>"dc-ba"</returns>
    public string ReverseOnlyLettersAnswer(string s)
    {
        char[] chars = s.ToCharArray();
        int left = 0;
        int right = chars.Length - 1;

        while (left < right)
        {
            if (!char.IsAsciiLetter(chars[left]))
            {
                left++;
            }
            else if (!char.IsAsciiLetter(chars[right]))
            {
                right--;
            }
            else
            {
                (chars[left], chars[right]) = (chars[right], chars[left]);

                left++;
                right--;
            }
        }

        return new string(chars);
    }
}