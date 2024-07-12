// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello World");
MyDelegate delegateFuction = new MyDelegate(MessageClass.GetMessage);
delegateFuction("Welcome to Delegate");
Console.ReadKey();

public delegate void MyDelegate(string message);

public static class MessageClass
{
    public static void GetMessage(string message)
    {
        Console.WriteLine(message);
    }
}
