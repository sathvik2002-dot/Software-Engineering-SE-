/******************************************************************************
* Filename    = DirectoryClass.cs
*
* Author      = Sathvik
*
* Product     = LinuxFileSystem
* 
* Project     = Directory in FileSystem
*
* Description = Represents the class for implementing directory class with Interface IFileSystem. It functionality is to add, remove directories inside directories; 
*               Listing all files in directory and changing from current directory to other directory.
*****************************************************************************/

namespace LinuxFileSystem
{
    /// <summary>
    /// Class for directory management in linux file system.
    /// </summary>
    public class DirectoryClass : IFileSystem
    {
        string directoryname;
        List<IFileSystem> filesystemlist;

        /// <summary>
        /// Initialise the current directory with a given name and also allocating certain space for list of files in current directory.
        /// </summary>
        public DirectoryClass(String name)
        {
            this.directoryname = name;
            filesystemlist = new List<IFileSystem>();
        }

        /// <summary>
        /// Retrieve the name of current directory.
        /// </summary>
        public string getname()
        {
            return directoryname;
        }

        /// <summary>
        /// Add file or directory in current directory.
        /// </summary>
        public void Add(IFileSystem filesystemobj)
        {
            filesystemlist.Add(filesystemobj);
        }

        /// <summary>
        /// Remove file or directory in current directory.
        /// </summary>
        public void Remove(IFileSystem filesystemobj)
        {
            filesystemlist.Remove(filesystemobj);
        }

        /// <summary>
        /// List all the files in current directory.
        /// </summary>
        /// <returns> Returns List of file names .</returns>
        public List<string> ls()
        {
            List<string> listofstrings = new List<string>();
            if (filesystemlist != null)
            {
                foreach (IFileSystem obj in filesystemlist)
                {
                    listofstrings.Add(obj.getname());
                }
            }
            return listofstrings;
        }
        /// <summary>
        /// Change directory from current directory according to path given in input.
        /// </summary>
        /// <returns>Return Interface of changed directory.</returns>
        public IFileSystem cd(string path)
        {
            char delimiter = '/';
            string[] subpaths = path.Split(delimiter);

            IFileSystem currentDirectory = this;

            foreach (string subpath in subpaths)
            {
                // Find the subdirectory with the specified name
                IFileSystem subdirectory = filesystemlist.FirstOrDefault(obj => obj.getname() == subpath)!;

                if (subdirectory != null && subdirectory is DirectoryClass)
                {
                    currentDirectory = subdirectory;
                }
                else
                {
                    return this;
                }
            }
            return currentDirectory;
        }
    }
}