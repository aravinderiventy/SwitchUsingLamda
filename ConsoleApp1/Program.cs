// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;
using System.Text;

string findCharCount = "Welcome to my blog.";

var count=findCharCount.Count(x => x.Equals('l'));


string s1 = "aa";
string s2 = "aa";
if (s1.Equals(s2))
{
    Console.WriteLine("match");
}
Emp emp = new Emp();
int[] numbers = { 4, 7, 2, 3, 4, 5, 3, 6, 7, 8, 1, 8 };
var distDupl = emp.findDistDuplNums(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (numbers[i] == numbers[j])
        {
            Console.WriteLine($"Duplicate num: {numbers[i]}");
            break;
        }
    }
}

string strWords = "aa cc aa";
string[] newStrArray = strWords.Split(' ');
StringBuilder newStr = new StringBuilder();
for (int i = newStrArray.Length - 1; i >= 0; i--)
{
    newStr.Append(newStrArray[i] + " ");
}
if (strWords == newStr.ToString().Trim())
{
    Console.WriteLine("Given name is Palindrome");
}
else
{
    Console.WriteLine("Given name is not Palindrome");
}
		
	

int a = 0, b = 1, c = 0;
Console.WriteLine(a + " " + b);
int maxValue = 50;
for (int i = 0; i < maxValue; i++)
{
    if (c < maxValue)
    {
        c = a + b;
        Console.WriteLine(c);
        a = b;
        b = c;
    }
    break;
}


string str1 = "I like programing c#";
StringBuilder reverseWords =new StringBuilder();
var strArray= str1.Split(" ");
for (int i = strArray.Length - 1; i >= 0; i--)
{
    reverseWords.Append(strArray[i] + " ");
}
Console.WriteLine(reverseWords);


StringBuilder reverseStr =new StringBuilder();
string str2 = "abc 123";
for (int i = str2.Length-1; i >=0; i--)
{
    reverseStr.Append(str2[i]);
}
Console.WriteLine(reverseStr);


int[] nums = [1, 2, 3, 3];
var repeatedNum = emp.RepeatedNTimes(nums);
Console.WriteLine(repeatedNum);


string str = "abcba";
char[] chars = str.ToCharArray();
var rev = chars.Reverse().ToArray();
if (str == new string(rev))
{
    Console.WriteLine("Palindrome.");
}
else
{
    Console.WriteLine("not pali");
}

string myStr=string.Empty;
emp.testDt = DateTime.MinValue;
myStr = emp.testDt.GetValueOrDefault().ToShortDateString();
Console.WriteLine("Hello, World!");


public class Emp
{
    public DateTime? testDt { get; set; }

    public int RepeatedNTimes(int[] nums)
    {
        
        return nums.GroupBy(x => x).FirstOrDefault(x => x.Count() > 1).Key;
    }

    public Dictionary<List<int>, List<int>> findDistDuplNums(int[] numbers)
    {
        Dictionary<List<int>, List<int>> ss = new Dictionary<List<int>, List<int>>();
        HashSet<int> distinctNumbers = new();
        HashSet<int> duplicateNumbers = new();

        foreach (int number in numbers)
        {
            if (!distinctNumbers.Add(number))
                duplicateNumbers.Add(number);
        }
        ss.Add(distinctNumbers.ToList(), duplicateNumbers.ToList());
        return ss;
    }
}
