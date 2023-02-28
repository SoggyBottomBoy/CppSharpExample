
using CppLibrary;

var example = new Example(1);
var added = example.Add(new Example(2));

Console.WriteLine(added.Value);
Console.ReadLine();
