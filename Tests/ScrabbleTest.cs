using Xunit;
using System;

namespace WeekdayFinder
{
  public class WeekdayTest : IDisposable
  {
    [Fact]
    public void Find_Within_Same_Month()
    {
      //Arrange
      Weekday weekday = new Weekday("7/9/2016");
      //Act
      string result = weekday.Find();
      //Assert
      Assert.Equal("Saturday", result);
    }
    [Fact]
    public void Find_Within_Same_Year()
    {
      //Arrange
      Weekday weekday = new Weekday("10/9/2016");
      //Act
      string result = weekday.Find();
      //Assert
      Assert.Equal("Sunday", result);
    }

    public void Dispose()
    {

    }
  }
}
