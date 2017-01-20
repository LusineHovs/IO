#DesktopFilesCleaning
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
  
  <img src="https://cloud.githubusercontent.com/assets/24455176/22147689/3d32d354-df23-11e6-9854-5f61cb9e3fd0.gif" align="left"  />
