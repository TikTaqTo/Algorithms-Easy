using System.Runtime.InteropServices.JavaScript;

namespace Algorithms_Easy;

/// <summary>
/// 3870. Count Commas in Range
/// You are given an integer n.
/// Return the total number of commas used when writing all integers from [1, n] (inclusive) in standard number formatting.
/// In standard formatting:
/// A comma is inserted after every three digits from the right.
/// Numbers with fewer than 4 digits contain no commas.
/// </summary>
public class CountCommasinRange
{
    /// <summary>
    /// Standart(Базовое решение). Через проверку, вычитание и добавление.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int CountCommas(int n) 
    {
        if (n <= 999)
        {
            return 0;
        }

        int minValidNumber = 1000;
        int result = n - minValidNumber + 1;
        
        return result;
    }
    
    /// <summary>
    /// BestMemory(Лучшее по памяти - Синий). Лучшее решение по памяти.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int CountCommasBestMemory(int n) {
        return Math.Max(n - 999, 0);
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Лучшее решение по скорости.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns> 
    public int CountCommasBestRuntime(int n) {
        return n - 999 > 0 ? n - 999 : 0;
    }
}