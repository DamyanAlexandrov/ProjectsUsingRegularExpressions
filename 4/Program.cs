using System.Text.RegularExpressions;

string input = Console.ReadLine();

List<string> items = new List<string>();
double totalPrice = 0;

string patern = @">{2}(?<item>[A-z]+)<{2}(?<price>\d+\.?\d*)!(?<amount>\d+)";
Regex regex = new Regex(patern);

while (input != "Purchase")
{
    var matches = regex.Matches(input);

    foreach (Match match in matches)
    {
        var item = match.Groups["item"].Value;
        var price = double.Parse(match.Groups["price"].Value);
        var ammount = double.Parse(match.Groups["amount"].Value);

        items.Add(item);
        totalPrice += price * ammount;
    }

    input = Console.ReadLine();
}

Console.WriteLine("Bought furniture:");
foreach (var item in items)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Total money spent: {totalPrice:f2}");
