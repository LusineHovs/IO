
This program deletes all the read-only files in the given **"Testing" directory**.
If there are some *Read-Only files*, which are not deleted, you will be given message.
```C#
DirectoryInfo directory = new DirectoryInfo(@"C:\Users\L.Hovsepyan\Desktop\Testing");
  foreach (FileInfo file in directory.GetFiles())
  {
      if (!file.IsReadOnly)
      {
          file.Delete();
      }
      else
      {
          Console.WriteLine("Unfortunately not all files has been deleted in this directory");
      }
  }
  ```
  
  
