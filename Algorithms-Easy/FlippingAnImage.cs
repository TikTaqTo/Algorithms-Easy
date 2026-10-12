namespace Algorithms_Easy;

/// <summary>
/// 832. Flipping an Image
/// Given an n x n binary matrix image, flip the image horizontally, then invert it, and return the resulting image.
/// To flip an image horizontally means that each row of the image is reversed.
/// For example, flipping [1,1,0] horizontally results in [0,1,1].
/// To invert an image means that each 0 is replaced by 1, and each 1 is replaced by 0.
/// For example, inverting [0,1,1] results in [1,0,0].
/// </summary>
public class FlippingAnImage
{
    /// <summary>
    /// Standart(Базовое решение). Решил через 2 цикла и метод Reverse().
    /// </summary>
    /// <param name="image">[[1,1,0],[1,0,1],[0,0,0]]</param>
    /// <returns>[[1,0,0],[0,1,0],[1,1,1]]</returns>
    public int[][] FlipAndInvertImage(int[][] image) 
    {
        for (int i = 0; i < image.Length; i++)
        {
            Array.Reverse(image[i]);
            
            for (int j = 0; j < image[i].Length; j++)
            {
                if (image[i][j] == 0)
                    image[i][j] = 1;
                else
                    image[i][j] = 0;
            }
        }

        return image;
    }
    
    /// <summary>
    /// BestSpeed(Лучшее по скорости - Жёлтый). Решение через XOR.
    /// 1) Если image[0] = 1 и image[last] = 1 то при смене их местами мы получим 0, считайте flip и invert в одном флаконе.
    /// </summary>
    /// <param name="image"></param>
    /// <returns></returns>
    public int[][] FlipAndInvertImageBestSpeed(int[][] image) 
    {
        for(int i=0; i < image.Length; i++){

            int left = 0;
            int right = image[i].Length-1;

            while (left < right){
                int temp = image[i][left];
                image[i][left] = image[i][right];
                image[i][right] = temp;

                left++;
                right--;
            }
        }

        for(int i=0; i < image.Length; i++){
            for (int j=0; j < image[i].Length; j++){
                image[i][j] = image[i][j] == 1 ? 0: 1;
            }
        }

        return image;
    }
}