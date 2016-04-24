using System;

public class KnuthMorrisPratt : Pattern {
	private string pattern;
	private int[] failureTable;
	private const int FAIL_RETURN = 1000000001;

	public KnuthMorrisPratt(string s)
	{
		pattern = s.ToLower();
		failureTable = new int[s.Length];
		createFailureTable();
	}

	private void createFailureTable() 
	{
		int cnd = 0;
		int i = 1;
		failureTable[0] = 0;
		while (i<pattern.Length)
		{
			if (pattern[i] == pattern[cnd])
			{
				failureTable[i] = cnd + 1;
				cnd++;
				i++;
			}
			else if (cnd > 0)
			{
				cnd = failureTable[cnd-1];
			}
			else
			{
				failureTable[i] = 0;
				i++;
			}
		}
	}

	public int matchString(string s)
	{
		s = s.ToLower();

		int i = 0;
		int j = 0;
		bool found = false;
		int ret = FAIL_RETURN;
		while ((i + j < s.Length) && (!found))
		{
			if (s[i+j] == pattern[j])
			{
				if (j == pattern.Length-1)
				{
					ret = i;
					found = true;
				}
				j++;
			}
			else if (j > 0)
			{
				i = i + j - failureTable[j-1];
				j = failureTable[j-1];
			}
			else
			{
				j = 0;
				i++;
			}
		}
		return ret;
	}
}

/*
class KMPTester {
	static public void Main(string[] args) // Tester
	{
		KnuthMorrisPrattPattern pat1 = new KnuthMorrisPrattPattern("abcdefabcdefabcdeaabcdefabcdefa");
		string s = "lol";
		Console.WriteLine(s);
		Console.WriteLine(pat1.matchString(s));
	}
}
*/