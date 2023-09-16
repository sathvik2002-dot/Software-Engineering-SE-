# Software-Engineering-SE
## Composite Design Pattern
The Composite Design Pattern is used to compose objects into tree-like structures to represent part-whole hierarchies. It lets clients treat individual objects and compositions of objects uniformly. In simpler terms, it is used to create a hierarchy of objects where individual objects and groups of objects (composites) are treated in a consistent manner.
The main components of the Composite Design Pattern: Component, Leaf and Composite.
In this project, I have implemented Linux File System where we have directories and files. In a directory, you can have directories and files so it can be considered here as composite component of Composite design pattern. Whereas File cannot have either a file and directory so it can be considered as Leaf component. Interface IFileSystem is considered as Component of Composite design Pattern.
IFileSystem is interface for both DirectoryClass and FileClass.
## Files in the Repository 
### DirectoryClass.cs 
Represents the class for implementing directory class with Interface IFileSystem. Its functionality is to add, remove directories inside directories; Listing all files in directory and changing from current directory to other directory.
### FileClass.cs
Represents the class for implementing file class with Interface IFileSystem. It has custom exception class which will handle exceptions like we cannot list files in file, change directory from a file, add or remove a file into file. 
### IFileSystem.cs
Represents the Interface of Linux File System for users to do some functions.
### Program.cs
Printed the handled exception in the console(Example).
### UnitTests.cs
Represents a test class for the testing functionality such as listing all files in directory and change directory.
