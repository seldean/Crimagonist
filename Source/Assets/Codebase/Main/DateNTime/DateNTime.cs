using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using OutputController;

#region Rules
public static class GameDateSettings {
    public const byte DEFAULT_STARTING_HOUR = 0;
    public const short DEFAULT_STARTING_YEAR = 2010;
    public const byte DEFAULT_STARTING_MONTH = 1;
    public const byte DEFAULT_STARTING_DAY = 1;
}
#endregion

#region GameDate Class
public class GameDate {
    System.DateTime CurrentDate { get; set; }

    public GameDate(byte startHour = GameDateSettings.DEFAULT_STARTING_HOUR, short startYear = GameDateSettings.DEFAULT_STARTING_YEAR, byte startMonth = GameDateSettings.DEFAULT_STARTING_MONTH, byte startDay = GameDateSettings.DEFAULT_STARTING_DAY) {
        CurrentDate = new System.DateTime(startYear, startMonth, startDay, startHour, 0, 0);
    }

    public string GetDateString() {
        return CurrentDate.ToString("g");
    }

    public void AddMinute(int minuteAmount = 1) {
        CurrentDate = CurrentDate.AddMinutes(minuteAmount);
    }
    public void AddHour(int hourAmount = 1) {
        CurrentDate = CurrentDate.AddHours(hourAmount);
    }
    public void AddDay(int dayAmount = 1) {
        CurrentDate = CurrentDate.AddDays(dayAmount);
    }
    public void AddMonth(int monthAmount = 1) {
        CurrentDate = CurrentDate.AddMonths(monthAmount);
    }
    public void AddYear(int yearAmount = 1) {
        CurrentDate = CurrentDate.AddYears(yearAmount);
    }
}
#endregion
