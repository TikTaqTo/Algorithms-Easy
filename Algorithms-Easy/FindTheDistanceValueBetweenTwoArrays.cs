namespace Algorithms_Easy;

/// <summary>
/// 1385. Find the Distance Value Between Two Arrays
/// Given two integer arrays arr1 and arr2, and the integer d, return the distance value between the two arrays.
/// The distance value is defined as the number of elements arr1[i] such that there is not any element arr2[j] where |arr1[i]-arr2[j]| <= d.
/// </summary>
public class FindTheDistanceValueBetweenTwoArrays
{
    /// <summary>
    /// Standart(Базовое решение). Решение через перебор всех вариантов
    /// 1) Сравниваем каждый элемент с d, если он меньше или равен d то делаем break и переходим к следующему числу
    /// </summary>
    /// <param name="arr1">[4,5,8]</param>
    /// <param name="arr2">[10,9,1,8]</param>
    /// <param name="d">2</param>
    /// <returns>2</returns>
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
    {
        int count = 0;

        foreach (int x in arr1) {
            bool isValid = true;
            foreach (int y in arr2) {
                if (Math.Abs(x - y) <= d) {
                    isValid = false;
                    break;
                }
            }
            
            if (isValid) {
                count++;
            }
        }

        return count;
    }
}