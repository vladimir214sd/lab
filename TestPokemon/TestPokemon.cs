using lab;
namespace TestPokemon;

[TestClass]
public class TestPokemon
{
    [TestMethod]
    public void TestMethod1()
    {
        //Arrange
        Pokemon expected = new Pokemon(52, 232, 44);
        //Act
        Pokemon actual = new Pokemon(52, 232, 44);
        //Assert
        Assert.AreEqual(expected, actual);
 
    }
    [TestMethod]
    public void TestMethod2()
    {
        //Arrange
        Pokemon expected = new Pokemon();
        //Act
        Pokemon actual = new Pokemon(0, 0, 0);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod3()
    {
        //Arrange
        Pokemon expected = new Pokemon(5555, 55555, 5555);
        //Act
        Pokemon actual = new Pokemon(414, 396,496);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod4()
    {
        //Arrange
        Pokemon expected = new Pokemon(50, 50, 50);
        expected.IncreaseStats(1, 2, 4);
        //Act
        Pokemon actual = new Pokemon(51, 52, 54);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod5()
    {
        //Arrange
        Pokemon expected = new Pokemon(50, 50, 50);
        Pokemon.IncreaseStats(expected, 1, 2, 4);
        //Act
        Pokemon actual = new Pokemon(51, 52, 54);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod6()
    {
        //Arrange
        Pokemon expected = new Pokemon(100, 100, 100);
        --expected;
        //Act
        Pokemon actual = new Pokemon(100, 100, 99);
        //Assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod7()
    {
        Pokemon expected = new Pokemon(95, 100, 105);
        expected = ~expected;

        Assert.AreEqual(expected.CombatPower, 973.46);
    }
    [TestMethod]
    public void TestMethod8()
    {
        //Arrange
        Pokemon expected = new Pokemon(50, 60, 70);
        expected = expected >> 2;
        //Act
        Pokemon actual = new Pokemon(50, 60, 72);
        //Assert
        Assert.AreEqual(expected.Stamina, actual.Stamina);
    }





}
