Console.Write("Введите число n:");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите 2-ое число с:");
double с = double.Parse(Console.ReadLine());

string x = n.ToString();
string k = с.ToString();


Type l = x.GetType();
Type z = n.GetType();


Console.WriteLine($" {n} {с} {x} {k} {l} {z}");









