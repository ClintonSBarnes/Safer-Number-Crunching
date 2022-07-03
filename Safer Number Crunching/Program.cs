int num = 0;
double dub = 0;
bool boo;

Console.WriteLine("Please enter a number: ");

int.TryParse(Console.ReadLine(), out num);

Console.WriteLine("Please enter a number with a decimal: ");
double.TryParse(Console.ReadLine(), out dub);

Console.WriteLine("Please enter a True or False: ");
bool.TryParse(Console.ReadLine(), out boo);


Console.WriteLine(num);
Console.WriteLine(dub);
Console.WriteLine(boo);