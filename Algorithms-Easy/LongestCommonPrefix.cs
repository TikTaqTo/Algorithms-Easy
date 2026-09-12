namespace Algorithms_Easy;


//TODO: Not solved problem
public class LongestCommonPrefix
{
    public string LongestCommonPrefixAnswer(string[] strs)
    {
        string result = "";

        for (int i = 0, j = strs.Length, t = 0; i != j; i++, j--)
        {
            if (strs[i][t] == strs[j][t])
            {
                result.Append(strs[i][j]);
                t++;
            }
            else
            {
                break;
            }
        }

        return result;
    }
}