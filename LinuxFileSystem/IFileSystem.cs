/******************************************************************************
* Filename    = IFileSystem.cs
*
* Author      = Sathvik
*
* Product     = LinuxFileSystem
* 
* Project     = Creating Interface for Linux File System.
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinuxFileSystem
{
    /// <summary>
    /// Interface of Linux File System for users.
    /// </summary>
    public interface IFileSystem
    {
        List<string> ls();
        string getname();

        IFileSystem cd(string path);

        void Add(IFileSystem filesystemobj);
        void Remove(IFileSystem filesystemobj);

    }
}
