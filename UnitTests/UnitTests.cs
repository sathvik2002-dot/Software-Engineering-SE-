/******************************************************************************
* Filename    = UnitTests.cs
*
* Author      = Sathvik
*
* Product     = LinuxFileSystem
* 
* Project     = UnitTesting
*
* Description = unit tests for the LinuxFileSystem
*****************************************************************************/

using LinuxFileSystem;
namespace UnitTests
{
    [TestClass]
    /// <summary>
    /// Represents a test class for the testing functionality such as listing all files in directory and change directory.
    /// </summary>
    public class UnitTests
    {
        [TestMethod]
        /// <summary>
        /// TestMethod for the testing functionality of both listing all files in directory and change directory.
        /// </summary>
        public void TestMethod1()
        {
            DirectoryClass root = new DirectoryClass("Root");
            DirectoryClass downloads = new DirectoryClass("Downloads");
            DirectoryClass documents = new DirectoryClass("Documents");
            DirectoryClass desktop = new DirectoryClass("Desktop");
            FileClass download_file_1 = new FileClass("File1");
            root.Add(downloads);
            root.Add(documents);
            root.Add(desktop);
            downloads.Add(download_file_1);
            List<string> downloadfiles = new List<string>();
            downloadfiles.Add("File1");
            Assert.IsTrue(Enumerable.SequenceEqual(downloadfiles, root.cd("Downloads").ls()));
        }

        [TestMethod]
        /// <summary>
        /// TestMethod for the testing functionality of listing all files in directory.
        /// </summary>
        public void TestMethod2()
        {
            DirectoryClass root = new DirectoryClass("Root");
            DirectoryClass downloads = new DirectoryClass("Downloads");
            DirectoryClass documents = new DirectoryClass("Documents");
            DirectoryClass desktop = new DirectoryClass("Desktop");
            root.Add(downloads);
            root.Add(documents);
            root.Add(desktop);
            List<string> rootfiles = new List<string>();
            rootfiles.Add("Downloads");
            rootfiles.Add("Documents");
            rootfiles.Add("Desktop");
            Assert.IsTrue(Enumerable.SequenceEqual(rootfiles, root.ls()));
        }
    }
}