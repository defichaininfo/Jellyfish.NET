using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace Jellyfish.Json.Tests;

[TestClass]
public class PrecisionTests
{
    private readonly CultureInfo _currentCulture = CultureInfo.CurrentCulture;

    [TestInitialize]
    public void Initialize()
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
    }

    [TestCleanup]
    public void Cleanup()
    {
        CultureInfo.CurrentCulture = _currentCulture;
    }

    [TestMethod]
    public void DoubleShouldLosePrecision()
    {
        var dfi = 1200000000.00000003;
        Assert.AreNotEqual(dfi.ToString(), "1200000000.00000003");
    }

    [TestMethod]
    public void DecimalShouldNotLosePrecision()
    {
        var dfi = 1200000000.00000003M;
        Assert.AreEqual(dfi.ToString(), "1200000000.00000003");
    }

    [TestMethod]
    public void DecimalTimesDoubleShouldBeDecimal()
    {
        var dfi = 12.00000003M;
        var product = dfi * 1000000;
        Assert.AreEqual(product, 12000000.03M);
    }
}
