using System;

/// <summary>
/// Summary description for Class1
/// </summary>

public static class Parser
{
    public static string[] parse(string s)
    {
        char[] delimiterChars = {';',' '};
        return s.Split(delimiterChars);
    }
}