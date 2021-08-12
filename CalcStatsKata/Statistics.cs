using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcStatsKata {
  public class Statistics {
    public List<Object> GetAllStats(string numbers) {
      var stats = new List<object> {GetMinimum(numbers), GetMaximum(numbers), GetCount(numbers), GetAverage(numbers)};

      return stats;
    }

    public int GetMinimum(string numbers) {
      return GetActualNumbers(numbers).FirstOrDefault();
    }

    public int GetMaximum(string numbers) {
      return GetActualNumbers(numbers).Last();
    }

    public int GetCount(string numbers) {
      return GetActualNumbers(numbers).Count();
    }

    public double GetAverage(string numbers) {
      return GetActualNumbers(numbers).Average();
    }

    private List<int> GetActualNumbers(string numbers) {
      var parsedNumbers = numbers.Split(new string[] {","}, StringSplitOptions.RemoveEmptyEntries).ToList();
      var actualNumbers = parsedNumbers.Select(int.Parse).ToList();

      actualNumbers.Sort();
      return actualNumbers;
    }
  }
}