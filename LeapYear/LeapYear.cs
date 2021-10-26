using System;

namespace LeapYear
{
	public static class LeapYear
	{
		public static Boolean IsLeapYear (
				Int32 year) {
			if (year.IsDivisibleBy( 100 ) && !year.IsDivisibleBy( 400 )) return false;
			if (!year.IsDivisibleBy( 4 )) return false;
			return true;
		}

		public static Boolean IsDivisibleBy (
				this Int32 dividend,
				Int32 divisor)
			=> dividend % divisor == 0;
	}
}
