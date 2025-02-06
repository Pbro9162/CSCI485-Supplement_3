namespace fileManips;

public class FileFuncs
{
    public static void CreateAsciiFile(string filePath, string fileContent) {

        ArgumentNullException.ThrowIfNull(filePath);

        if (fileContent == null) {
            throw new ArgumentNullException ("fileContent");
        }
        else {
            if (filePath.Length == 0) {
                Console.WriteLine("Invalid FilePath, try again.");
            } else {
                
                File.WriteAllText(filePath, fileContent);
                Console.WriteLine("File Created Successfully.");


            }
        }
    }

    public static void CreateBinaryFile(string filePath, string fileContent) {
        ArgumentNullException.ThrowIfNull(filePath);
        ArgumentNullException.ThrowIfNull(fileContent);

        using (FileStream fs = new FileStream(filePath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(fileContent);
            }

        Console.WriteLine("File Created Successfully");
    }

    public static string ReadAsciiFile(string filepath)
    {
        ArgumentNullException.ThrowIfNull(filepath);
        string fileContent = File.ReadAllText(filepath);

        Console.WriteLine("File Content: " + fileContent);
        return fileContent;
    }

    public static byte[] ReadBinaryFile(string filepath) 
    {
        ArgumentNullException.ThrowIfNull(filepath);    
        byte[] fileBytes = File.ReadAllBytes(filepath);

        return fileBytes;
    }
}
