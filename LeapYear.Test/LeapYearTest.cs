using System;

using Xunit;

namespace LeapYear.Test
{
	public class LeapYearTest
	{
		[Fact]
		public void Year400_ShouldBe_LeapYear () {
			Assert.True( LeapYear.IsLeapYear( 400 ) );
		}
	}
}
