using NUnit.Framework;
using CalcStatsKata;

namespace CalcStatsKata.Tests {
  [TestFixture]
  public class StatisticsTests {
    private Statistics _stats = new Statistics();

    [Test]
    public void MinimumNumberIsFound() {
      Assert.AreEqual(4, _stats.GetMinimum("5,6,4,7,6,9"));
    }

    [Test]
    public void MaximumNumberIsFound() {
      Assert.AreEqual(17, _stats.GetMaximum("5, 4, 6, 7, 8, 12, 14, 17"));
    }

    [Test]
    public void NumberOfElementsIsFound() {
      Assert.AreEqual(5, _stats.GetCount("5,6,14,12,222"));
    }

    [Test]
    public void AverageOfNumbersIsFound() {
      Assert.AreEqual(10, _stats.GetAverage("10,10,10,10,10,10,10"));
    }

    [Test]
    public void AllStatsAreFound() {
      const string NUMBERS = "1,2,3,4,5,6,7,8,9,10";
      Assert.AreEqual(1, _stats.GetMinimum(NUMBERS));
      Assert.AreEqual(10, _stats.GetMaximum(NUMBERS));
      Assert.AreEqual(10, _stats.GetCount(NUMBERS));
      Assert.AreEqual(5.5, _stats.GetAverage(NUMBERS));
    }

    [Test]
    public void StatsAreCompiledInAListCorrectly() {
      const string NUMBERS = "4,5,7,14,15,17,34,55";
      var stats = _stats.GetAllStats(NUMBERS);
      Assert.AreEqual(4, stats[0]);
      Assert.AreEqual(55, stats[1]);
      Assert.AreEqual(8, stats[2]);
      Assert.AreEqual(18.875, stats[3]);
    }
  }
}