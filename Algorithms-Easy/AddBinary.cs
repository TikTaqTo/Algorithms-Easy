using System.Text;

namespace Algorithms_Easy;

/// <summary>
/// 67. Add Binary
/// Given two binary strings a and b, return their sum as a binary string.
/// </summary>
public class AddBinary
{
    /// <summary>
    /// Standart(Базовое решение). Решение достигнуто посредством следующих критериев:
    /// 1) Выравниваем строки по длине a и b, заполняем начало 0 потому что числа a и b могут быть только положительными.
    /// 2) Буферную зону result, размер на 1 больше для возможного переноса.
    /// 3) 0 в начале положительного числа быть не может следовательно его удаляем из Result.
    /// </summary>
    /// <param name="a">"111"</param>
    /// <param name="b">"1"</param>
    /// <returns>"1000"</returns>
    public string AddBinaryAnswer(string a, string b)
    {
        StringBuilder result = new StringBuilder();
        
        if (a.Length > b.Length)
            b = b.PadLeft(a.Length, '0');
        else if (a.Length < b.Length)
            a = a.PadLeft(b.Length, '0');

        result.Append('0', a.Length + 1);
        
        for (int i = b.Length - 1; i >= 0; i--)
        {
            int resIdx = i + 1; 

            if (a[i] == b[i])
            {
                if (a[i] == '1')
                {
                    if (result[resIdx] == '1')
                    {
                        result[resIdx] = '1';
                        result[resIdx - 1] = '1';
                    }
                    else
                    {
                        result[resIdx] = '0';
                        result[resIdx - 1] = '1';
                    }
                }
            }
            else
            {
                if (result[resIdx] == '1')
                {
                    result[resIdx] = '0';
                    result[resIdx - 1] = '1';
                }
                else
                {
                    result[resIdx] = '1';
                }
            }
        }
        
        result = result[0] == '0' ? result.Remove(0, 1) : result;
        return result.ToString();
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Решение достигнуто посредством следующих критериев:
    /// 1) Создаём 2 переменные i и j для прохождения по всем элементам массивов a и b.
    /// 2) Переводим символы a[i] и b[j] в цифры (a[i--] - '0'), складываем и получаем финальную цифру.
    /// 3) Создаём временную переменную reminder которая запоминает результат приведущего шага.
    /// </summary>
    /// <param name="a">"111"</param>
    /// <param name="b">"1"</param>
    /// <returns>"1000"</returns>
    public string AddBinaryAnswerBestSpeed(string a, string b)
    {
        var sb = new StringBuilder();
        int remainder = 0;
        int i = a.Length - 1;
        int j = b.Length - 1;
        
        while (i >= 0 || j >= 0 || remainder != 0)
        {
            int sum = remainder;

            sum += i >= 0 ? a[i--] - '0' : 0;
            sum += j >= 0 ? b[j--] - '0' : 0;

            sb.Append((char)('0' + sum % 2));
            remainder = sum / 2;
        }

        var reversedNum = sb.ToString().ToCharArray();
        Array.Reverse(reversedNum);
        return new string(reversedNum);
    }
}