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
        static void Main(string[] args)
        {
            DirectoryClass root = new DirectoryClass("Root");
            DirectoryClass downloads = new DirectoryClass("Downloads");
            DirectoryClass documents = new DirectoryClass("Documents");
            DirectoryClass desktop = new DirectoryClass("Desktop");
            DirectoryClass document1 = new DirectoryClass("Document1");
            FileClass document_file_1 = new FileClass("File1");
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