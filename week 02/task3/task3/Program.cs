// Declare and initialize variables of the following types: byte, short, int, long, float, double, decimal, char, bool.
//     Convert the integer value 42 to a string and store it in a new variable.
//     Convert a string "3.14" to a double and store it in a new variable.
//     Print all variables to the console with appropriate labels showing their types and values.


byte b = 1;
short s = 2;
int i = 89;
long l = 10000000000L;
float f = 94.5f;
double d = 56.5666d;
decimal de = 49.99999999m;
char c = 'A';
bool isTrue = true;

int number = 42;
string convertedInteger = number.ToString();

string val = "3.14";
double convertedVal = double.Parse(val);

Console.WriteLine("Byte value: " + b);
Console.WriteLine("Short value: " + s);
Console.WriteLine("Int value: " + i);
Console.WriteLine("Long value: " + l);
Console.WriteLine("Float value: " + f);
Console.WriteLine("Double value: " + d);
Console.WriteLine("Decimal value: " + de);
Console.WriteLine("Char value: " + c);
Console.WriteLine("Boolean value: " + isTrue);
Console.WriteLine("Converted integer (42 -> string): " + convertedInteger);
Console.WriteLine("Converted string (\"3.14\" -> double): " + convertedVal);

