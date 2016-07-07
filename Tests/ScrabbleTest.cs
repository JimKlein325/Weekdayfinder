using Xunit;
using System;

namespace WeekdayFinder
{
  public class WeekdayTest : IDisposable
  {
    [Fact]
    public void Find_Within_Different_Month()
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

    [Fact]
    public void Find_Within_Other_Year()
    {
      //Arrange
      Weekday weekday = new Weekday("10/9/2017");
      //Act
      string result = weekday.Find();
      //Assert
      Assert.Equal("Monday", result);
    }
    [Fact]
    public void Find_Within_Same_Month()
    {
      //Arrange
      Weekday weekday = new Weekday("1/22/2016");
      //Act
      string result = weekday.Find();
      //Assert
      Assert.Equal("Friday", result);
    }
    [Fact]
    public void Find_Within_DifferentYearSame_Month()
    {
      //Arrange
      Weekday weekday = new Weekday("1/22/2017");
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
