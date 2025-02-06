namespace fileManips.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        FileFuncs.CreateBinaryFile("binaryTest.bin", "This is a binary file.");
        
    }
}