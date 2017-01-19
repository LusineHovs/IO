#GetAllDirectories

In this example I wrote the code, which gets all the Directories and Files of C:\.
```C#

string[] array1 = Directory.GetDirectories(@"C:\");
Console.WriteLine("---- Directories of C: Disk----");

foreach (string name in array1)
{
  Console.WriteLine(name);

}
Console.ReadKey();
Console.WriteLine("---- Files of C: Disk----");


string[] array2 = Directory.GetFiles(@"C:\");
foreach (string name in array2)
{
  Console.WriteLine(name);
}
```

