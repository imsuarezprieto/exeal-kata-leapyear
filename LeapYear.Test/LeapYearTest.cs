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

		[Fact]
		public void Year800_ShouldBe_LeapYear () {
			Assert.True( LeapYear.IsLeapYear( 800 ) );
		}

		[Fact]
		public void Year1200_ShouldBe_LeapYear () {
			Assert.True( LeapYear.IsLeapYear( 1200 ) );
		}
	}
}
