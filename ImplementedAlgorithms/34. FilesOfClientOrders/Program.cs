using System.Globalization;

string[] lines = File.ReadAllLines("../../../orders.txt");

Dictionary<string, decimal> keyValuePairs = new Dictionary<string, decimal>();

foreach (var order in lines)
{
    string[] arguments = order.Split(';');

    if (arguments.Length != 4)
        continue;

    string clientId = arguments[2];

    if(decimal.TryParse(arguments[3],CultureInfo.InvariantCulture, out decimal newAmount))
    {
        if(!keyValuePairs.ContainsKey(clientId))
            keyValuePairs.Add(clientId, 0);

        keyValuePairs[clientId] += newAmount;
    }
}

List<string> outputLines = new();

foreach (var kvp in keyValuePairs)
{
    outputLines.Add($"{kvp.Key}: {kvp.Value:f2}");
}
File.WriteAllLines("../../../report.txt", outputLines);