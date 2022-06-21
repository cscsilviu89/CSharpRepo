// See https://aka.ms/new-console-template for more information
string songLyrics = "You say goodbye, and I say hello";


var result = songLyrics.Contains("goodbye");
result = songLyrics.StartsWith("You");
Console.WriteLine(result);

Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

