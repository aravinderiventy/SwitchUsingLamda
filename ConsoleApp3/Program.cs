// See https://aka.ms/new-console-template for more information
using ConsoleApp3;

Console.WriteLine("Hello, World!");
var myObj = ActionFactory.GetActionType("Close");
if (myObj is not null)
    myObj.Execute();

var myObj2 = ActionFactory.GetActionType("Complete");
if (myObj2 is not null)
    myObj2.Execute();

Console.WriteLine("Done");

