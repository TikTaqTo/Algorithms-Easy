namespace Algorithms_Easy;

/// <summary>
/// 844. Backspace String Compare
/// Given two strings s and t, return true if they are equal when both are typed into empty text editors.
/// '#' means a backspace character.
/// Note that after backspacing an empty text, the text will continue empty.
/// </summary>
public class BackspaceStringCompare
{
    /// <summary>
    /// Standart(Базовое решение). Проходимся по символам через цикл, работаем со стэком.
    /// </summary>
    /// <param name="s">"ab#c"</param>
    /// <param name="t">"ad#c"</param>
    /// <returns>true</returns>
    public bool BackspaceCompare(string s, string t)
    {
        Stack<char> firstStack = new Stack<char>();

        foreach (char ch in s) {
            if (ch != '#') {
                firstStack.Push(ch);
            } else if (firstStack.Count > 0) {
                firstStack.Pop();
            }
        }

        string normalizedS =  new string(firstStack.ToArray());

        Stack<char> secondStack = new Stack<char>();

        foreach (char ch in t) {
            if (ch != '#') {
                secondStack.Push(ch);
            } else if (secondStack.Count > 0) {
                secondStack.Pop();
            }
        }

        string normalizedT = new string(secondStack.ToArray());
        
        return string.Equals(normalizedS, normalizedT, StringComparison.OrdinalIgnoreCase);
    }
}