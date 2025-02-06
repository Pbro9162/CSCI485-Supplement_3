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
}
