using System.Text.RegularExpressions;

string patern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<ammount>\d+)\|[^|$%.]*?(?<price>\d+\.*\d*)\$";
string input = Console.ReadLine();
Regex regex = new Regex(patern);

double sum = 0;

while (input != "end of shift")
{
    var matches = regex.Matches(input);

    foreach (Match match in matches)
    {
        var customer = match.Groups["customer"].Value;
        var product = match.Groups["product"].Value;
        var ammount = match.Groups["ammount"].Value;
        var price = match.Groups["price"].Value;

        Console.WriteLine($"{customer}: {product} - {double.Parse(ammount)*double.Parse(price):f2}");

        sum += double.Parse(ammount) * double.Parse(price);
    }

    input = Console.ReadLine();
}

Console.WriteLine($"Total income: {sum:f2}");
