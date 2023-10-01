using Dictionary;

MyDictionary<int, string> myDict = new ();

myDict.Add(1, "One");
myDict.Add(2, "Two");
myDict.Add(3, "Three");

Console.WriteLine("Does key 2 exist? " + myDict.ContainsKey(2));

bool removed = myDict.Remove(2);
Console.WriteLine("Key 2 removed? " + removed);

Console.WriteLine("Does key 2 exist after removal? " + myDict.ContainsKey(2));

Console.ReadLine(); 