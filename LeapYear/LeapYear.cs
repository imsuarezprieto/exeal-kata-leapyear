using System;

namespace LeapYear
{
	public class LeapYear
	{
		public static Boolean IsLeapYear (
				Int32 year) {
			if ((year % 100 == 0) && (year % 400 != 0)) return false;
			if (year % 4 != 0) return false;
			return true;
		}
	}
}
