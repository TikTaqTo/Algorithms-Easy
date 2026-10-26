namespace Algorithms_Easy;

/// <summary>
/// 1346. Check If N and Its Double Exist
/// Given an array arr of integers, check if there exist two indices i and j such that :
/// i != j
/// 0 <!--<=--> i, j <!--<--> arr.length
/// arr[i] == 2 * arr[j]
/// </summary>
public class CheckIfNAndItsDoubleExist
{
    /// <summary>
    /// Standart(Базовое решение). Решение через структуру HashSet
    /// 1) Добавляем в HashSet значение arr
    /// 2) Проверяем есть ли значение arr[i] в HashSet
    /// 3) Если значение arr[i] чётное число, проверяем дополнительно arr[i] / 2 есть ли в HashSet
    /// </summary>
    /// <param name="arr">[-20,-10,-8,12,15]</param>
    /// <returns>true</returns>
    public bool CheckIfExist(int[] arr)
    {
        HashSet<int> checker = new HashSet<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (checker.Contains(arr[i] * 2))
                return true;

            if (arr[i] % 2 == 0)
            {
                if (checker.Contains(arr[i] / 2))
                    return true;
            }
            
            checker.Add(arr[i]);
        }

        return false;
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости). Решение через структуру Dictionary
    /// 1) Добавляем в Dictionary, ключ i значение arr[i] * 2
    /// 2) Проверяем и умноженное на 2 и делённое на 2 значение arr[i]
    /// </summary>
    /// <param name="arr">[-20,-10,-8,12,15]</param>
    /// <returns>true</returns>
    public bool CheckIfExistBestSpeed(int[] arr)
    {
        Dictionary<int,int> di = new();
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(di.ContainsKey(arr[i] * 2) || (di.ContainsKey(arr[i] / 2) && arr[i] % 2 == 0))
                return true;
            
            di[arr[i]] = arr[i] * 2;
        }
        
        return false;
    }
}