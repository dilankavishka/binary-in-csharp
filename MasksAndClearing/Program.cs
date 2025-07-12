int value = 0b1101;
int mask = 0b0101;
int result = value & ~mask;

Console.WriteLine($"{ConvertToBinary(value, 32)}: value");
Console.WriteLine($"{ConvertToBinary(mask, 32)}: mask");
Console.WriteLine($"{ConvertToBinary(~mask, 32)}: ~mask");
Console.WriteLine($"{ConvertToBinary(result, 32)}: result");

string ConvertToBinary(int value, int places = 8)
{
    return Convert.ToString(value, 2).PadLeft(places, '0');
}