// See https://aka.ms/new-console-template for more information
string firstFriend = "Scott";
string secondFriend = "Kendra";
Console.WriteLine($"My first are {firstFriend} and {secondFriend}"); //string interpolation
Console.WriteLine($"Thane name {firstFriend} has {firstFriend.Length} letters"); // .Length este o proprietate a variabilei string => numarul de caractere
Console.WriteLine($"Thane name {secondFriend} has {secondFriend.Length} letters");

//manipularea spatiilor dintr-un string 

string greeting = "        Hello World!        ";
Console.WriteLine($"([{greeting}]");

string trimmmedGreeting = greeting.TrimStart();
Console.WriteLine($"([{trimmmedGreeting}]");

trimmmedGreeting = greeting.TrimEnd();
Console.WriteLine($"([{trimmmedGreeting}]");

trimmmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmmedGreeting}]");

string sayHello = "Hello world!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());