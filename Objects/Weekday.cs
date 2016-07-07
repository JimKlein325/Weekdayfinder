using System;
using System.Collections.Generic;
using System.Text;


namespace WeekdayFinder
{
  public class Weekday
  {
    private int _day;
    private int _month;
    private int _year;
    private int _numberOfDays;

    private int _baseDay = 1;
    private int _baseMonth = 1;
    private int _baseYear = 2016;

    public Weekday(string newDate)
    {
      string[] date = newDate.Split('/');
      _month = Int32.Parse(date[0]);
      _day = Int32.Parse(date[1]);
      _year = Int32.Parse(date[2]);
      _numberOfDays = Calcualte();
    }
    public int GetDay()
    {
      return _day;
    }
    public void SetDay(int newday)
    {
      _day = newday;
    }

    public int Calcualte()
    {
      int leftDays = 0;
      int[] months = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
      int[] leapYearMonths = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
      if(IsLeapYear(_year)){
        for(int i=0; i< _month-1; i++){
          leftDays += leapYearMonths[i];
        }
      }
      else{
        for(int i=0; i< _month-1; i++){
          leftDays += months[i];
        }
      }

      return leftDays + _day;
    }

    public bool IsLeapYear(int year)
    {
      if (year % 400 == 0)
      {
        return true;
      }
      else if (year % 100 == 0)
      {
        return false;
      }
      else
      {
        return year % 4 == 0;
      }
    }

    public string Find()
    {
      string[] Weekdays = {"Friday", "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday","Thursday"};
      return Weekdays[_numberOfDays%7];
    }
  }

}
