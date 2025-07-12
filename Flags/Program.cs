
SystemPermissions dilanPermissions = SystemPermissions.Azure | SystemPermissions.Github;

Console.WriteLine($"{ConvertToBinary((int)dilanPermissions)} : Dilan's Permissions");
Console.WriteLine($"{(int)dilanPermissions} : Dilan's Permissions");

string ConvertToBinary(int value, int places = 8)
{
    return Convert.ToString(value, 2).PadLeft(places, '0');
}

[Flags]
enum SystemPermissions
{
    None = 0,
    SQL = 1, //00000001
    WebServer = 1 << 1, //00000010
    Reddis = 1 << 2, //00000100
    Azure = 1 << 3, //00001000
    Github = 1 << 4, //00010000
    BuidSystem = 1 <<5 //00100000
}