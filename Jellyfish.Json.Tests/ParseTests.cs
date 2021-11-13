using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Globalization;

namespace Jellyfish.Json.Tests;

[TestClass]
public class ParseTests
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
    public void EighteenDigitSignificantShouldParseAsDecimalWithoutPrecisionLost()
    {
        var obj = JellyfishJson.Parse<TestObject>("{\"decimal\":1200000000.00000001}");
        Assert.IsNotNull(obj);
        Assert.AreEqual(obj.Decimal.ToString(), "1200000000.00000001");
    }

    [TestMethod]
    public void TenDigitSignificantShouldParseAsDecimalWithMathOperatorsShouldNotHaveAnError()
    {
        var obj = JellyfishJson.Parse<TestObject>("{\"decimal\":1200000000}");
        Assert.IsNotNull(obj);
        Assert.AreEqual((obj.Decimal + 1).ToString(), "1200000001");
    }

    [TestMethod]
    public void EighteenDigitSignificantShouldParseAsDecimalWithMathOperatorsShouldNotHaveAnError()
    {
        var obj = JellyfishJson.Parse<TestObject>("{\"decimal\":1200000000.00000001}");
        Assert.IsNotNull(obj);
        Assert.AreEqual((obj.Decimal + 1).ToString(), "1200000001.00000001");
    }

    [TestMethod]
    public void EighteenDigitSignificantShouldParseAsDoubleWithPrecisionLost()
    {
        var obj = JellyfishJson.Parse<TestObject>("{\"double\":1200000000.00000001}");
        Assert.IsNotNull(obj);
        Assert.AreNotEqual(obj.Double.ToString(), "1200000000.00000001");
    }

    [TestMethod]
    public void TenDigitSignificantShouldParseAsDoubleWithoutPrecisionLost()
    {
        var obj = JellyfishJson.Parse<TestObject>("{\"double\":1200000000}");
        Assert.IsNotNull(obj);
        Assert.AreEqual(obj.Double.ToString(), "1200000000");
    }
}