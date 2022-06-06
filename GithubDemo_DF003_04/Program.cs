using GithubDemo_DF003_04;
using System.Reflection;

var methods = typeof(ICalc).GetMethods();

Console.WriteLine("Choose the options from below :");
foreach (var item in methods)
{
    Console.WriteLine(item.Name);
}

Console.WriteLine("----------------------------------------------------\n");

var theOption = Console.ReadLine();

Console.WriteLine("Enter the value for x and y as comma sperated eg. 20,30");
var theValues = Console.ReadLine();
var strx = theValues.Split(',')[0];
var stry = theValues.Split(',')[1];
var x = Convert.ToInt32(strx);
var y = Convert.ToInt32(stry);
var calc = new Calc();

var methodInfo = methods.Where(m => m.Name.Normalize() == theOption.Normalize()).FirstOrDefault();
if (methodInfo is not null)
{
    var result = methodInfo.Invoke(calc, new object[] { x, y });
    Console.WriteLine("The result is {0}",result);
}
Console.ReadLine();
