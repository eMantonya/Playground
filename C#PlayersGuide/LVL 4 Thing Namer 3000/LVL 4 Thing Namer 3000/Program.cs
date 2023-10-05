// See https://aka.ms/new-console-template for more information
Console.WriteLine("What kind of thing are we talking about?");
//string a contains the first user input that answers the question on line 2
string a = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Textured?");
/* string b contains the describing string input */
string b = Console.ReadLine();
//string c and d store hard coded phrases for the namer
string c = "of Doom";
string d = "3000";
Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");
