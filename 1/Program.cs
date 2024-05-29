using System.Text.RegularExpressions;

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
string names = Console.ReadLine();

Regex regex = new Regex(pattern);

MatchCollection matchedNames = regex.Matches(names);

foreach (Match match in matchedNames)
{
    Console.WriteLine(match);
}
