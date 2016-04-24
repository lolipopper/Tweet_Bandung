using System;

/// <summary>
/// Summary description for Class1
/// </summary>

public class BoyerMoore : Pattern
{
    private int[] lastOccurenceTable;

    public BoyerMoore(string s)
    {
        pattern = s.ToLower();
        lastOccurenceTable = new int[256];
        createLastOccurenceTable();
    }

    private void createLastOccurenceTable()
    {
        for (int i = 0; i < 256; i++)
        {
            lastOccurenceTable[i] = -1;
        }

        for (int i = 0; i < pattern.Length; i++)
        {
            lastOccurenceTable[pattern[i]] = i;
        }
    }

    public override int matchString(string s)
    {
        s = s.ToLower();

        if (s.Length < pattern.Length)
        {
            return FAIL_RETURN;
        }

        int i = pattern.Length - 1;
        int j = pattern.Length - 1;
        bool found = false;
        int ret = FAIL_RETURN;

        do
        {
            if (s[i] == pattern[j])
            {
                if (j == 0)
                {
                    ret = i;
                    found = true;
                }
                i--;
                j--;
            }
            else
            {
                int lastOccurence = lastOccurenceTable[s[i]];
                i = i + pattern.Length - Math.Min(j, lastOccurence + 1);
                j = pattern.Length - 1;
            }
        }
        while ((i <= s.Length - 1) && (!found));

        return ret;
    }
}

/*
class BoyerMooreTester
{
    static public void Main(string[] args) // Tester
    {
        BoyerMoorePattern pat1 = new BoyerMoorePattern("fas");
        string s = "asdfasdfafdsf";
        Console.WriteLine(s);
        Console.WriteLine(pat1.matchString(s));
    }
}
*/