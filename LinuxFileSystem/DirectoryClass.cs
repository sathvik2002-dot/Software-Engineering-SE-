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
        readonly string _directoryname;
        readonly List<IFileSystem> _filesystemlist;

        /// <summary>
        /// Initialise the current directory with a given name and also allocating certain space for list of files in current directory.
        /// </summary>
        public DirectoryClass( string name )
        {
            _directoryname = name;
            _filesystemlist = new List<IFileSystem>();
        }

        /// <summary>
        /// Retrieve the name of current directory.
        /// </summary>
        public string getname()
        {
            return _directoryname;
        }

        /// <summary>
        /// Add file or directory in current directory.
        /// </summary>
        public void Add(IFileSystem filesystemobj)
        {
            _filesystemlist.Add(filesystemobj);
        }

        /// <summary>
        /// Remove file or directory in current directory.
        /// </summary>
        public void Remove(IFileSystem filesystemobj)
        {
            _filesystemlist.Remove(filesystemobj);
        }

        /// <summary>
        /// List all the files in current directory.
        /// </summary>
        /// <returns> Returns List of file names .</returns>
        public List<string> ls()
        {
            List<string> listofstrings = new();
            if (_filesystemlist != null)
            {
                foreach (IFileSystem obj in _filesystemlist)
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
                IFileSystem subdirectory = _filesystemlist.FirstOrDefault(obj => obj.getname() == subpath)!;

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
