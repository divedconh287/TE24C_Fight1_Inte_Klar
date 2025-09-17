int prohp = 100;
int anthp = 100;
string proname;
string antname;

Console.WriteLine("jag lyssnar på Mr. Prism av Psychedelic Porn Crumpets just nu.");
Console.ReadLine();
Console.WriteLine("Vad ska din protagonist heta?");
proname = Console.ReadLine().ToLower();

Console.WriteLine("Vad ska din antagonist heta?");
antname = Console.ReadLine().ToLower();

Console.WriteLine($"{proname} & {antname} ska slåss");

Console.ReadLine();