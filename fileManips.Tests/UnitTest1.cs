namespace fileManips.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        FileFuncs.CreateAsciiFile("ASCII File Test.txt", "This is a new ASCII File");

        FileFuncs.CreateBinaryFile("Binary File Test.bin", "Binary File Tested");


        FileFuncs.ReadAsciiFile("example.txt");

        FileFuncs.ReadBinaryFile("binaryTest.bin");

    }
}