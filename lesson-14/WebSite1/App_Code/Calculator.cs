using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Kalk
/// </summary>
public class Calculator
{
	public Calculator()
	{
	}
	public string Square(string numString)
	{
		if (double.TryParse(numString, out double r))
		{
			return (r * r).ToString();
		}
		return "Error";
	}

	public string SQRT(string numString)
	{
		if (double.TryParse(numString, out double r))
		{
			if (r >= 0)
			{
				return Math.Sqrt(r).ToString();
			}
			else
            {
				return "Error";
			}
		}
		return "Error";
	}
}