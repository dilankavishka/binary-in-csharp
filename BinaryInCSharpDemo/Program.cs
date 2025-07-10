
int binaryValue = 0b1001;

Console.WriteLine($"The original value: {binaryValue} (base 10)");
Console.WriteLine($"The original value: {ConvertToBinary(binaryValue)} (base 2)");

binaryValue = 1 << 3;

Console.WriteLine($"The new value: {binaryValue} (base 10)");
Console.WriteLine($"The new value: {ConvertToBinary(binaryValue)} (base 2)");

binaryValue = binaryValue >> 2;

Console.WriteLine($"The new right shift value: {binaryValue} (base 2)");
Console.WriteLine($"The new right shift value: {ConvertToBinary(binaryValue)} (base 2)");

string ConvertToBinary(int Value, int places = 8)
{
    return Convert.ToString(Value, 2).PadLeft(places, '0');
}