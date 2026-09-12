namespace Algorithms_Easy;

public class PlusOne
{
    /// <summary>
    /// You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer.
    /// The digits are ordered from most significant to least significant in left-to-right order.
    /// The large integer does not contain any leading 0's.
    /// Increment the large integer by one and return the resulting array of digits.
    /// </summary>
    /// <param name="digits"></param>
    /// <returns></returns>
    public int[] PlusOneAnswer(int[] digits)
    {
        List<int> result = new List<int>();
        int additionDigit = 1;
        int sum = 0;
        
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            sum = digits[i] + additionDigit;
            
            if (sum > 9)
            {
                additionDigit = sum / 10;
                int secondNumber = sum % 10;
                
                result.Add(secondNumber);
            }
            else
            {
                result.Add(sum);
                additionDigit = 0;
            }
        }

        if (additionDigit != 0)
        {
            result.Add(additionDigit);
        }

        result.Reverse();
        
        return result.ToArray();
    }
}