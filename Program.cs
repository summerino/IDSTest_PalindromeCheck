class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert the value: ");
        string palindromeValue = Console.ReadLine();
        Console.WriteLine(CheckPalindrome(palindromeValue));
    }

    private static bool CheckPalindrome(string value)
    {
        string cleanedString = "";
        foreach (char c in value)
        {
            if (char.IsLetterOrDigit(c))
            {
                cleanedString += char.ToLower(c);
            }
        }

        int left = 0;
        int right = cleanedString.Length - 1;
        while (left < right)
        {
            if (cleanedString[left] != cleanedString[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}