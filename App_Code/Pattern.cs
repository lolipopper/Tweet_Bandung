public abstract class Pattern
{
	protected string pattern;
	protected const int FAIL_RETURN = 1000000001;

	public abstract int matchString(string s);
}