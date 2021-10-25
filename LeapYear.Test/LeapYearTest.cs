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

		[Theory]
		[InlineData( 100 )]
		[InlineData( 200 )]
		[InlineData( 300 )]
		public void YearsDivisibleBy100_AndNotBy400_ShouldNotBe_LeapYear (
				Int32 year) {
			Assert.False( LeapYear.IsLeapYear( year ) );
		}

		[Theory]
		[InlineData( 4 )]
		[InlineData( 8 )]
		[InlineData( 12 )]
		public void YearsDivisibleBy4_AndNotBy100_ShouldBe_LeapYear (
				Int32 year) {
			Assert.True( LeapYear.IsLeapYear( year ) );
		}
	}
}
