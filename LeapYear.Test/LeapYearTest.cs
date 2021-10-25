using System;

using Xunit;

namespace LeapYear.Test
{
	public class LeapYearTest
	{
		[Theory]
		[InlineData(400)]
		[InlineData(800)]
		[InlineData(1200)]
		public void YearsDivisibleBy400_ShouldBe_LeapYears (
				Int32 year) {
			Assert.True( LeapYear.IsLeapYear( year ) );
		}
	}
}
