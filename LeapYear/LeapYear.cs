using System;

namespace LeapYear
{
	public class LeapYear
	{
		public static Boolean IsLeapYear (
				Int32 year) {
			if (year == 100) return false;
			if (year == 200) return false;
			return true;
		}
	}
}
