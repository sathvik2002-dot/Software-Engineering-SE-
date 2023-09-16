/******************************************************************************
* Filename    = Program.cs
*
* Author      = Sathvik
*
* Product     = LinuxFileSystem
* 
* Project     = Basic Console Application Testing
*****************************************************************************/
using LinuxFileSystem;

namespace ConsoleApplication
{
    /// <summary>
    /// Represents console application for general testing purpose
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Printing the handled exception in the console.
        /// </summary>
        static void Main()
        {
            DirectoryClass root = new("Root");
            DirectoryClass downloads = new("Downloads");
            DirectoryClass documents = new("Documents");
            DirectoryClass desktop = new("Desktop");
            DirectoryClass document1 = new("Document1");
            FileClass document_file_1 = new("File1");
            root.Add(downloads);
            root.Add(documents);
            root.Add(desktop);
            documents.Add(document1);
            document1.Add(document_file_1);
            try
            {
                document_file_1.ls();
            }
            catch(CustomFileSystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
