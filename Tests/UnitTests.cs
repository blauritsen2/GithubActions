namespace GithubActionsLab;

[TestClass]
public class OperationsTests
{
    // Addition Tests
    [TestMethod]
    public void Add_Valid()
    {
        Assert.AreEqual(3, Program.Add("1", "2"));
        Assert.AreEqual(5, Program.Add("3", "2"));
        Assert.AreEqual(12, Program.Add("5", "7"));
    }

    [TestMethod]
    public void Add_Invalid()
    {
        Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
    }

    [TestMethod]
    public void Add_Null()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
    }

    // Subtraction Tests
    [TestMethod]
    public void Subtract_Valid()
    {
        Assert.AreEqual(1, Program.Subtract("3", "2"));
        Assert.AreEqual(-4, Program.Subtract("3", "7"));
    }

    [TestMethod]
    public void Subtract_Invalid()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
    }

    // Multiplication Tests
    [TestMethod]
    public void Multiply_Valid()
    {
        Assert.AreEqual(6, Program.Multiply("2", "3"));
        Assert.AreEqual(0, Program.Multiply("0", "5"));
    }

    [TestMethod]
    public void Multiply_Invalid()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("x", "3"));
    }

    // Division Tests
    [TestMethod]
    public void Divide_Valid()
    {
        Assert.AreEqual(2, Program.Divide("6", "3"));
        Assert.AreEqual(1.5, Program.Divide("3", "2"));
    }

    [TestMethod]
    public void Divide_ByZero()
    {
        Assert.ThrowsException<DivideByZeroException>(() => Program.Divide("5", "0"));
    }

    [TestMethod]
    public void Divide_Invalid()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "4"));
    }

    // Power Tests
    [TestMethod]
    public void Power_Valid()
    {
        Assert.AreEqual(8, Program.Power("2", "3"));
        Assert.AreEqual(1, Program.Power("5", "0"));
    }

    [TestMethod]
    public void Power_Invalid()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("b", "2"));
    }
}
