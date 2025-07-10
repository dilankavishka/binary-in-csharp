
int binaryValue = 1001;
string stringRepresentation = Convert.ToString(binaryValue, 2).PadLeft(32, '0');

Console.WriteLine($"Binary value: {binaryValue} (base 10)");
Console.WriteLine($"Binary Value: {stringRepresentation} (base 2)");