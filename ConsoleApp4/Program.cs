// See https://aka.ms/new-console-template for more information

int num = 6;
int count = 0;
for (int i = 1; i <= num; i++)
{
    if(num % i == 0)
    {
        count++;
    }
}
if(count == 2)
{
    Console.WriteLine("Prime Number");
}
else
{
    Console.WriteLine("Not a Prime");
}

var memoryBeforeAllocation = GC.GetTotalMemory(false);
Console.WriteLine($"memory Before Allocation:{memoryBeforeAllocation} Bytes");
xyz ss=new xyz();
ss.GetResult();

var y = Math.Round(6.6);


List<int> numList = new List<int>();
Random random = new Random();
for (int i = 0; i < 1000; i++)
{
    numList.Add(random.Next(1000));
}

//Memory Allocation before and after
var memoryAfterAllocation = GC.GetTotalMemory(false);
Console.WriteLine($"memory After Allocation:{memoryAfterAllocation} Bytes");
GC.Collect();
Console.WriteLine($"memory After Allocation:{memoryAfterAllocation} Bytes");


Console.WriteLine(String.Join(",", numList));

var maxList = numList.OrderByDescending(x => x).Take(3).ToList();
Console.WriteLine(string.Join(",", maxList));

string strMessage = "Welcome to my Blog";
int charCount = strMessage.Count(x => x.Equals('l'));
Console.WriteLine(charCount.ToString());

List<int> nums = new List<int> { 1, 2, 3, 3 };
var repeatedNum = RepeatedNTimes(nums);
Console.WriteLine(repeatedNum);

int RepeatedNTimes(List<int> nums)
{
    return nums.GroupBy(x => x).FirstOrDefault(x => x.Count() > 1).Key;
}

public class abc
{
    public int GetSum(int x, int y, string? z)
    {
        return x + y;
    }
    public int GetSum1(int x, int y, string z = "")
    {
        return x + y;
    }
}

public class xyz
{
    delegate void PrintMessage(string  message);

    public static void WriteText(string message) => Console.WriteLine(message);

    public void GetResult()
    {
        var delegate1 = new PrintMessage(WriteText);
        delegate1.Invoke("Go Ahead! make my day..");
        delegate1("Another way to call");

        PrintMessage delegate2 = text => { Console.WriteLine($"Reverse: {ReverseString(text)}"); };
        delegate2("Go Ahead delegate2");

        //Multi cast Delegate
        var multiCastDelegate = delegate1 + delegate2;
        multiCastDelegate("Invoke multicast delegate");
        //or
        multiCastDelegate = delegate1;
        multiCastDelegate += delegate2;
        multiCastDelegate("Another way to call multicast");


        abc objAbc = new abc();
        var res = objAbc.GetSum(1, 2, null);
        var res1 = objAbc.GetSum1(1, 2);
    }
    public string ReverseString(string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}

