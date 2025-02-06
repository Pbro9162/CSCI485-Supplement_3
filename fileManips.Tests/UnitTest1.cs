namespace fileManips.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Create text file
        FileFuncs.CreateAsciiFile("ASCII File Test.txt", "This is a new ASCII File");
        //Create Binary file
        FileFuncs.CreateBinaryFile("Binary File Test.bin", "Binary File Tested");

        //Read text file
        FileFuncs.ReadAsciiFile("example.txt");
        //Read binary file
        FileFuncs.ReadBinaryFile("binaryTest.bin");

    }
}