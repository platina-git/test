// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var counter = 0;
var defaultMaxValue = 5;
var max = defaultMaxValue;
if (args.Length is not 0)
{
Console.WriteLine("args : {0} (for max value)", args[0]);
max = Convert.ToInt32(args[0]);
}
else
{
Console.WriteLine("args is empty.");
}
Console.WriteLine($"max : {max}");
while (max is -1 || counter < max)
{
Console.WriteLine($"Counter: {++counter}");
await Task.Delay(TimeSpan.FromMilliseconds(1_000));
}
