using System;

using Xunit;

namespace LeapYear.Test
{
	public class LeapYearTest
	{
		[Theory]
		[InlineData( 400 )]
		[InlineData( 800 )]
		[InlineData( 1200 )]
		public void YearsDivisibleBy400_ShouldBe_LeapYears (
				Int32 year) {
			Assert.True( LeapYear.IsLeapYear( year ) );
		}

		[Fact]
		public void Year100_ShouldNotBe_LeapYear () {
			Assert.False( LeapYear.IsLeapYear( 100 ) );
		}

		[Fact]
		public void Year200_ShouldNotBe_LeapYear () {
			Assert.False( LeapYear.IsLeapYear( 200 ) );
		}
	}
}
