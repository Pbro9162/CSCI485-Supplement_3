namespace fileManips.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        FileFuncs.CreateAsciiFile("example.txt", "This is an ascii file.");
    }
}