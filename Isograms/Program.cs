class Program
{
    /// <summary>
    /// The method determines whether the string is an isogram.
    /// </summary>
    /// <param name="str">input string</param>
    /// <returns>true if the sting is an isogram</returns>
    public static bool IsIsogram(string str)
    {
        string lowercaseStr = str.ToLower();
        return lowercaseStr.Distinct().Count() == lowercaseStr.Length;
    }
    static void Main()
    {
        Console.WriteLine(IsIsogram("isIsogram"));
    }
}