namespace Algorithms_Easy;

public class ReverseWordsinaStringIII
{
    public string ReverseWords(string s) {
        string[] mystring = s.Split(' ');

        char[] first = mystring.First().ToCharArray();

        Array.Reverse(first);

        string result = new string(first);

        if(mystring.Length > 1) 
        {
            for(int i = 1; i < mystring.Length; i++)
            {
                char[] arr = mystring[i].ToCharArray();
                Array.Reverse(arr);
                result += " " + new string(arr);
            }
        }
        
        return result;
    }
}