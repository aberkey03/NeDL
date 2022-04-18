String input = File.ReadAllText("restaurants.txt");

int i = 0, j = 0;
string[,] restaurants = new string[10, 10];
foreach (var row in input.Split('\n'))
{
    j = 0;
    foreach (var name in row.Trim().Split(' '))
    {
        restaurants[i, j] = string.Parse(name.Trim());
        j++;
    }
    i++;
}