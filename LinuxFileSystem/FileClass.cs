/******************************************************************************
* Filename    = FileClass.cs
*
* Author      = Sathvik
*
* Product     = LinuxFileSystem
* 
* Project     = Creating Class for file management in linux file system.
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Custom exception class is used to handle exceptions occured during usage of certain functionalities of file management 
/// like we cannot list the files in file, etc.
/// </summary>
public class CustomFileSystemException : Exception
{
    public CustomFileSystemException(string message) : base(message)
    {
    }

    public CustomFileSystemException(string message, Exception innerException) : base(message, innerException)
    {
    }
}

namespace LinuxFileSystem
{
    /// <summary>
    /// Class for file management in linux file system.
    /// </summary>
    public class FileClass : IFileSystem
    {
        readonly string _filename;
        public FileClass(string name)
        {
            _filename = name;
        }
        public string getname()
        {
            return _filename;
        }

        /// <summary>
        /// Since, we cannot list files in file, change directory from a file, add or remove a file into file. 
        /// Exception handler is called to handle such scenerios.
        /// </summary>
        public List<string> ls()
        {
            throw new CustomFileSystemException("This is not directory, It is a file");
        }

        public IFileSystem cd(string path)
        {
            throw new CustomFileSystemException("This is not directory, It is a file");
        }

        public void Add(IFileSystem filesystemobj) 
        {
            throw new CustomFileSystemException("This is not directory, It is a file");
        }
        public void Remove(IFileSystem filesystemobj) 
        {
            throw new CustomFileSystemException("This is not directory, It is a file");
        }
    }
}
