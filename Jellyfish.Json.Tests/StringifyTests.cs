using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace Jellyfish.Json.Tests;

[TestClass]
public class StringifyTests
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
    public void ShouldStringifyDoubleAsJsonNumeric()
    {
        var obj = new TestObject { Double = 1200000000 };
        var stringified = JellyfishJson.Stringify(obj);
        Assert.AreEqual(stringified, "{\"double\":1200000000}");
    }

    [TestMethod]
    public void ShouldStringifyDecimalAsJsonNumeric()
    {
        var obj = new TestObject { Decimal = 1200000000.00000001M };
        var stringified = JellyfishJson.Stringify(obj);
        Assert.AreEqual(stringified, "{\"decimal\":1200000000.00000001}");
    }
}
