using lab;
namespace TestPokemon;

[TestClass]
public class TestArena
{
    [TestMethod]
    public void TestMethod1()
    {
        //Arrange
        Arena expected = new Arena(4);
        //Act
        Arena actual = new Arena(4);
        //Assert   
        Assert.AreEqual(expected[0], actual[0]);
        Assert.AreEqual(expected[1], actual[1]);
        Assert.AreEqual(expected[2], actual[2]);
        Assert.AreEqual(expected[3], actual[3]);
    }
    [TestMethod]
    public void TestMethod2()
    {
        //Arrange
        Arena expected = new Arena(2);
        //Act
        Arena actual = new Arena(2, false);
        //Assert   
        Assert.AreEqual(expected[0], actual[0]);
        Assert.AreEqual(expected[1], actual[1]);
    }
    [TestMethod]
    public void TestMethod3()
    {
        //Arrange
        Arena expected = new Arena(2);
        //Assert   
        Assert.AreEqual(expected.Length, 2);
    }
    [TestMethod]
    public void TestMethod4()
    {
        //Arrange
        Arena expected = new Arena(2);
        expected[0] = new Pokemon(52, 56, 63);
        //Act
        Arena actual = new Arena(expected);
        //Assert   
        Assert.AreEqual(expected[0], actual[0]);
        Assert.AreEqual(expected[1], actual[1]);
    }
    [TestMethod]
    public void TestMethod5()
    {
        //Arrange
        Arena expected = new Arena(5, true);
        expected[0] = new Pokemon(24, 52, 496);
        expected[1] = new Pokemon(54, 232, 4496);
        expected[2] = new Pokemon(72, 112, 496);
        expected[3] = new Pokemon(245, 26, 232);
        expected[4] = new Pokemon(133, 312, 44);
        //Act
        int actual = 496;
        //Assert   
        Assert.AreEqual(Arena.Moda(expected), 496);
    }
}
