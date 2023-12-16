using System.ComponentModel.DataAnnotations;

namespace MoneyExtension.Tests;

[TestClass]
public class MoneyTest
{
    [TestMethod]
    public void TestConversion()
    {
        decimal dec = 2089.90M;

        var result = dec.ToCents();

        Assert.AreEqual(result, 208990);
    }
}