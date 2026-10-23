namespace Algorithms_Easy;

/// <summary>
/// 942. DI String Match
/// A permutation perm of n + 1 integers of all the integers in the range [0, n] can be represented as a string s of length n where:
/// s[i] == 'I' if perm[i] <!--<--> perm[i + 1], and
/// s[i] == 'D' if perm[i] <!-->--> perm[i + 1].
/// Given a string s, reconstruct the permutation perm and return it. If there are multiple valid permutations perm, return any of them.
/// </summary>
public class DIStringMatch 
{
    /// <summary>
    /// Standart(Базовое решение). Решил через 2 переменных min и max
    /// 1) min это счётчик для I
    /// 2) max это счётчик для D
    /// 3) Идём по массиву с лево на право, после чего повышаем счётчик по соответсвию
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int[] DiStringMatch(string s) 
    {
        int[] result = new int[s.Length + 1];
        int min = 0;
        int max = s.Length;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'I')
            {
                result[i] = min;
                min++;
            }

            if (s[i] == 'D')
            {
                result[i] = max;
                max--;
            }
        }

        if(s[^1] == 'D')
            result[^1] = min;
        else if (s[^1] == 'I')
            result[^1] = max;

        return result;
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Решение похоже на min и max, единственное отличие тут нету if if проверок лишних
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int[] DiStringMatchBestSpeed(string s) {
        var d = s.Length;
        var l = 0;
        var result = new int[s.Length + 1];
        
        for(var i = 0; i< s.Length; i++){
            if(s[i] == 'D'){
                result[i] = d;
                d--;
            }
            else{
                result[i]=l;
                l++;
            }
        }
        result[s.Length] = d;
        return result;
    }
}