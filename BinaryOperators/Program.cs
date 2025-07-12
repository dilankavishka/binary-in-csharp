int value1 = 0b1001;
int value2 = 0b1010;

Console.WriteLine($"$The value 1 is {ConvertToBinary(value1)}");
Console.WriteLine($"$The value 2 is {ConvertToBinary(value2)}");

// OR Operator
int result = value1 | value2;
Console.WriteLine($"$The result is {ConvertToBinary(result)}");

// AND Operator
int result1 = value1 & value2;
Console.WriteLine($"$The result is {ConvertToBinary(result1)}");

// NOT Operator - ~
int notValue = ~value1;
Console.WriteLine($"$The result is {ConvertToBinary(notValue)}");

// XOR Operator - ^
int result2 = value1 ^ value2;
Console.WriteLine($"$The result is {ConvertToBinary(result2)}");

string ConvertToBinary(int value, int places = 8)
{
    return Convert.ToString(value, 2).PadLeft(places, '0');
}