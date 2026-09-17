using System.Collections;
using System.Runtime.CompilerServices;

namespace Algorithms_Easy;

/// <summary>
/// 20. Valid Parentheses
/// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
/// An input string is valid if:
/// 1) Open brackets must be closed by the same type of brackets.
/// 2) Open brackets must be closed in the correct order.
/// 3) Every close bracket has a corresponding open bracket of the same type.
/// </summary>
public class ValidParentheses
{
    /// <summary>
    /// Standart(Базовое решение). Решение через стэк, кладём в стэк только открывающие символы а закрывающие их оттуда убирают,
    /// таким образом если ничего не осталось в стэке 
    /// </summary>
    /// <param name="s">[()]</param>
    /// <returns>true</returns>
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
            return false;

        Stack<char> openBracket = new Stack<char>();

        for (int i = 0; i <= s.Length - 1; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                openBracket.Push(s[i]);
            }
            else
            {
                if (openBracket.Count == 0)
                    return false;
                
                char openBracketChar = openBracket.Pop();

                if (openBracketChar == '(' && s[i] != ')')
                    return false;
                
                if (openBracketChar == '{' && s[i] != '}')
                    return false;

                if (openBracketChar == '[' && s[i] != ']')
                    return false;
            }
        }

        if (openBracket.Count != 0)
            return false;
        
        return true;
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Лучшее решение по скорости, человек переизобрёл stack как тип данных :D
    /// Используется дополнительный массив который дублирует входящий открывающие символы и декрементит их в случае если находит закрывающие символы
    /// </summary>
    /// <param name="s">[()]</param>
    /// <returns>true</returns>
    public bool IsValidBestSpeed(string s) {
        static char Closing(char c)
        {
            return c switch
            {
                ']' => '[',
                ')' => '(',
                '}' => '{',
                _ => char.MinValue
            };
        }

        static bool Opening(char o)
        {
            return o switch
            {
                '[' => true,
                '(' => true,
                '{' => true,
                _ => false
            };
        }

        var pos = 0;
        var comp = new char[s.Length];
        foreach (var c in s)
            if (Opening(c))
            {
                comp[pos++] = c;
            }
            else
            {
                var opp = Closing(c);
                if (pos <= 0 || comp[pos - 1] != opp)
                    return false;
                pos--;
            }

        return pos == 0;
    }
}