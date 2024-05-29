using System.Text.RegularExpressions;

string inputNumbers = Console.ReadLine();
string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
Regex regex = new Regex(pattern);

MatchCollection validNumbers = regex.Matches(inputNumbers);

Console.WriteLine(string.Join(", ", validNumbers));
