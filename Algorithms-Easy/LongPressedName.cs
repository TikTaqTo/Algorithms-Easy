namespace Algorithms_Easy;

/// <summary>
/// 925. Long Pressed Name
/// Your friend is typing his name into a keyboard.
/// Sometimes, when typing a character c, the key might get long pressed, and the character will be typed 1 or more times.
/// You examine the typed characters of the keyboard.
/// Return True if it is possible that it was your friends name, with some characters (possibly none) being long pressed.
/// </summary>
public class LongPressedName
{
    /// <summary>
    /// Standart(Базовое решение) +BestSpeed(Лучшее по скорости - Жёлтый). Решение через 2 указателя
    /// 1) nameCheckPos - указатель для name, typedCheckPos - указатель для typed
    /// 2) Цикл ходит по массиву typed, ведь он всегда будет больше чем name и засчёт чего может содержать лишние символы
    /// 3) Если символ в name не совпадает с typedCheckPos, проверяем на повторный символ, если не повтор значит лишний символ
    /// </summary>
    /// <param name="name">"leelee"</param>
    /// <param name="typed">"lleeelee"</param>
    /// <returns>true</returns>
    public bool IsLongPressedName(string name, string typed)
    {
        int nameCheckPos = 0;
        int typedCheckPos = 0;
        
        for (; typedCheckPos < typed.Length; typedCheckPos++)
        {
            if (nameCheckPos < name.Length && name[nameCheckPos] == typed[typedCheckPos])
            {
                nameCheckPos++;
            }
            else if (typedCheckPos == 0 || typed[typedCheckPos] != typed[typedCheckPos - 1])
            {
                return false;
            }
        }

        return nameCheckPos == name.Length;
    }
}