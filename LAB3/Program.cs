
using LAB3;

RomanNumber a = new RomanNumber(12);
RomanNumber b = new RomanNumber(4);
Console.WriteLine(a.ToString());
Console.WriteLine(b.ToString());
Console.WriteLine(a+b);
Console.WriteLine(a-b);
Console.WriteLine(a*b);
Console.WriteLine(a/b);

RomanNumber c = new RomanNumber(1232);
RomanNumber d = new RomanNumber(422);

Console.WriteLine("Sort: ");
RomanNumber[] nums = { a, b, c, d };
Array.Sort(nums);
foreach (RomanNumber num in nums)
    Console.WriteLine("* " + num.ToString());



Console.WriteLine("\nCompare: \nb & b");
Console.WriteLine(b.CompareTo(b));
Console.WriteLine("\nCompare: \nc & b");
Console.WriteLine(c.CompareTo(b));
