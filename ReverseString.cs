public class ReverseString
{
    public string Reverse(string strInput)
    {
        string result = string.Empty;
        char[] charArray = strInput.ToCharArray();
        int length = strInput.Length;
        for (int i = length - 1; i >= 0; i--)
        {
            result += charArray[i];
            //result = result + charArray[i];
        }
        return result;
    }

    public bool IsPalindrome(string strInput)
    {
        string reverse = Reverse(strInput);
        return strInput.Equals(reverse);
    }
}
}
