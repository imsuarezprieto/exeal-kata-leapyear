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

		[Fact]
		public void Year4_ShouldBe_LeapYear () {
			Assert.True( LeapYear.IsLeapYear( 4 ) );
		}

		[Fact]
		public void Year8_ShouldBe_LeapYear () {
			Assert.True( LeapYear.IsLeapYear( 8 ) );
		}

		[Fact]
		public void Year12_ShouldBe_LeapYear () {
			Assert.True( LeapYear.IsLeapYear( 12 ) );
		}
	}
}
