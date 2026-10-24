namespace Algorithms_Easy;

/// <summary>
/// 1089. Duplicate Zeros
/// Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.
/// Note that elements beyond the length of the original array are not written.
/// Do the above modifications to the input array in place and do not return anything.
/// </summary>
public class DuplicateZeros
{
    /// <summary>
    /// Standart(Базовое решение). Решил через 2 цикла
    /// 1) Идём по массиву с лево на право первым циклом, если встречаем 0 переходим ко 2 циклу
    /// 2) 2 цикл идёт по массиву с право на лево и смещает массив в право
    /// </summary>
    /// <param name="arr">[1,0,2,3,0,4,5,0] => [1,0,0,2,3,0,0,4]</param>
    public void DuplicateZerosAnswer(int[] arr)
    {
        for (int i = 0; i < arr.Length;)
        {
            if (arr[i] == 0)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    arr[j] = arr[j - 1];
                }

                i += 2;
            }
            else
                i++;
        }
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Решение через 2 циклами
    /// 1) Первый цикл нужен для определения границ массива который будет двигаться: arr = [1, 0, 2, 3] => i = 2, j = 2
    /// 2) Второе условие связано с случаями когда граница массива arr[j] = 0, дублировать 2 раза мы не можем так что ставим в конец 0
    /// 3) Второй цикл нужен для заполнения массива, идём с право на лево: j <!-- < --> k 
    /// </summary>
    /// <param name="arr"></param>
    public void DuplicateZerosBestSpeed(int[] arr)
    {
        int i = 0;
        int j = arr.Length - 1;
        while(i < j)
        {
            if(arr[i] == 0)
                j--;
            i++;
        }
        int k = arr.Length - 1;
        if (i == j && arr[i] == 0)
        {
            arr[k] = 0;
            k--;
            j--;
        }
        while(j >= 0)
        {
            if(arr[j] == 0)
            {
                arr[k] = 0;
                k--;
            }
            arr[k] = arr[j];
            k--;
            j--;
        }
    }
}