using System.Threading.Channels;

Random rand = new Random();

string Generate()
{
    string max = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJQLMNOPQRSTUVWXYZ1234567890";
    var str = ""; 

    for (int i = 0; i < 42; i++)
    {
        str += max[(int)Math.Floor((decimal)rand.Next(0, max.Length))];
    }
    
    return str + "+";
}

while(true)
{
    var x = rand.Next(1, 20);
    Console.ResetColor();
    if (x != 5)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[-] {Generate()}: Invalid code");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"[-] {Generate()}: Success code");
    }
    Thread.Sleep(200);
}