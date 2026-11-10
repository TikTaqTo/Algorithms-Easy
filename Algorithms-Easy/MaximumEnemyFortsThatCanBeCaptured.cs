namespace Algorithms_Easy;

/// <summary>
/// 2511. Maximum Enemy Forts That Can Be Captured
/// You are given a 0-indexed integer array forts of length n representing the positions of several forts.
/// forts[i] can be -1, 0, or 1 where:
/// -1 represents there is no fort at the ith position.
/// 0 indicates there is an enemy fort at the ith position.
/// 1 indicates the fort at the ith the position is under your command.
/// Now you have decided to move your army from one of your forts at position i to an empty position j such that:
/// 0 <!--<=--> i, j <!--<=--> n - 1
/// The army travels over enemy forts only. Formally, for all k where min(i,j) <!--<--> k <!--<--> max(i,j), forts[k] == 0.
/// While moving the army, all the enemy forts that come in the way are captured.
/// Return the maximum number of enemy forts that can be captured. In case it is impossible to move your army, or you do not have any fort under your command, return 0.*/
/// </summary>
public class MaximumEnemyFortsThatCanBeCaptured
{
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Решение через 2 указателя
    /// 1) Проходимся по массиву, выделяем область и проверяем максимальное значение
    /// </summary>
    /// <param name="forts">[1,0,0,-1,0,0,-1,0,0,1]</param>
    /// <returns>2</returns>
    public int CaptureForts(int[] forts)
    {
        int res = 0;
        for (int i = 0, j = 0; i < forts.Length ; ++i)
            if (forts[i] != 0)
            {
                if (forts[j] == -forts[i])
                    res = int.Max(res, i - j - 1);
                j = i;
            }
        return res;
    }
}