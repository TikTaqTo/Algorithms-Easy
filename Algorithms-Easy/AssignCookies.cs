namespace Algorithms_Easy;

/// <summary>
/// 455. Assign Cookies
/// Assume you are an awesome parent and want to give your children some cookies. But, you should give each child at most one cookie.
/// Each child i has a greed factor g[i], which is the minimum size of a cookie that the child will be content with;
/// and each cookie j has a size s[j]. If s[j] >= g[i], we can assign the cookie j to the child i, and the child i will be content. Your goal is to maximize the number of your content children and output the maximum number.
/// </summary>
public class AssignCookies
{
    /// <summary>
    /// Standart(Базовое решение). Решение через 2 указателя и сортировку.
    /// 1) Сортируем 2 массива g и s
    /// 2) Присваиваем каждому по указателю, i двигается всегда, j только в случае если больше или равен g[i]
    /// </summary>
    /// <param name="g">[10,9,8,7]</param>
    /// <param name="s">[5,6,7,8]</param>
    /// <returns>2</returns>
    public int FindContentChildren(int[] g, int[] s)
    {
        g.Sort();
        s.Sort();
        int counter = 0;
        
        for (int i = g.Length - 1, j = s.Length - 1; i >= 0 && j >= 0;)
        {
            if (g[i] > s[j])
                i--;
            else
            {
                j--;
                i--;
                counter++;
            }

        }
        
        return counter;
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Todo: Позже разобраться как работает
    /// </summary>
    /// <param name="g">[10,9,8,7]</param>
    /// <param name="s">[5,6,7,8]</param>
    /// <returns>2</returns>
    public int FindContentChildrenBestSpeed(int[] g, int[] s) {
        if (g.Length == 0 || s.Length == 0) return 0;

        int maxLen = Math.Max(g.Length, s.Length);
        int[] aux = new int[maxLen];

        RadixSort3Pass(g, aux);
        RadixSort3Pass(s, aux);

        int child = 0;
        int cookie = 0;

        while (child < g.Length && cookie < s.Length) {
            if (s[cookie] >= g[child]) {
                child++;
            }
            cookie++;
        }

        return child;
    }
    
    private static void RadixSort3Pass(int[] arr, int[] aux) {
        int n = arr.Length;
        if (n <= 1) return;

        // 2048 int = 8 КБ (идеально помещается в L1-кэш данных)
        Span<int> count = stackalloc int[2048];

        int[] src = arr;
        int[] dst = aux;

        // Проход 1: биты 0..10 (маска 0x7FF)
        // Проход 2: биты 11..21 (маска 0x7FF)
        // Проход 3: биты 22..31 (10 бит, маска 0x3FF)
        int[] shifts = { 0, 11, 22 };
        int[] masks  = { 0x7FF, 0x7FF, 0x3FF };

        for (int p = 0; p < 3; p++) {
            int shift = shifts[p];
            int mask = masks[p];
            int buckets = mask + 1;

            count.Slice(0, buckets).Clear();

            for (int i = 0; i < n; i++) {
                count[(src[i] >> shift) & mask]++;
            }

            int sum = 0;
            for (int i = 0; i < buckets; i++) {
                int c = count[i];
                count[i] = sum;
                sum += c;
            }

            for (int i = 0; i < n; i++) {
                int val = src[i];
                dst[count[(val >> shift) & mask]++] = val;
            }

            // Ping-pong
            int[] tmp = src;
            src = dst;
            dst = tmp;
        }

        // 3 прохода — нечетное число, итоговые данные лежат в aux (src).
        // Переносим обратно в исходный arr за один быстрый memcpy.
        Array.Copy(aux, 0, arr, 0, n);
    }
}