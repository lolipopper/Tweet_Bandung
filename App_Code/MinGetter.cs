using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class MinGetter
{
    private int result;
    private int mini;
    public MinGetter(int[] idx)
    {
        mini = idx[0];
        result = 0;
        for (int i = 1; i < idx.Count(); i++)
        {
            if (idx[i] < mini)
            {
                result = i;
                mini = idx[i];
            }
        }
    }
    public int Get()
    {
        return result;
    }
}