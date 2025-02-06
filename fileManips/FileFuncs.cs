namespace fileManips;

public class FileFuncs
{   
    //Function to create a text file
    public static void CreateAsciiFile(string filePath, string fileContent) {
        //error if filepath is null
        ArgumentNullException.ThrowIfNull(filePath);

        //error if content is null, not needed but still works
        if (fileContent == null) {
            throw new ArgumentNullException ("fileContent");
        }
        else {
            //Write fileContent to text file          
            File.WriteAllText(filePath, fileContent);
            Console.WriteLine("File Created Successfully.");

        }
    }

    //Function to create a binary file
    public static void CreateBinaryFile(string filePath, string fileContent) {
        //errors if either parameter is left empty
        ArgumentNullException.ThrowIfNull(filePath);
        ArgumentNullException.ThrowIfNull(fileContent);

        //create fs and binary writer to translate filecontent into binary
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(fileContent);
            }

        Console.WriteLine("File Created Successfully");
    }

    //Function to read ASCII file
    public static string ReadAsciiFile(string filepath)
    {
        //error if parameter is left empty
        ArgumentNullException.ThrowIfNull(filepath);

        //text from file saved into an obj
        string fileContent = File.ReadAllText(filepath);

        Console.WriteLine("File Content: " + fileContent);
        return fileContent;
    }

    //Function to read binary file
    public static byte[] ReadBinaryFile(string filepath) 
    {   
        //error if parameter is left empty
        ArgumentNullException.ThrowIfNull(filepath);  

        //bytes from file saved into obj
        byte[] fileBytes = File.ReadAllBytes(filepath);

        return fileBytes;
    }

    //function to generate a random string of any given length
    public static string GenerateString(int stringLength) 
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        Random random= new Random();


        //generates string
        return new string(Enumerable.Repeat(chars, stringLength)
                                    .Select(s => s[random.Next(s.Length)])
                                    .ToArray());
    }

    //function to compare two files with the same content
    public static void CompareFiles(string fileText)
    {   
        //create two files using given file text
        CreateAsciiFile("ASCII_File.txt", fileText);
        CreateBinaryFile("Binary_File.bin", fileText);

        //file paths
        string f1 = "ASCII_File.txt", 
        f2 = "Binary_File.bin";

        //file sizes using file path objs
        long asciiFileSize = GetFileSize(f1);
        long binaryFileSize = GetFileSize(f2);


        //comparisons for whichever is bigger
        if (asciiFileSize > binaryFileSize) {
            Console.WriteLine("ASCII File is bigger");
        }
        else if (asciiFileSize < binaryFileSize) 
        {
            Console.WriteLine("Binary File is bigger");
        }
        else 
        {
            Console.WriteLine("The files are equal size");
        }

    }
}
