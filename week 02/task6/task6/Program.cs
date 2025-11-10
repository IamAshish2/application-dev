List<string> fruits = new List<string> { "Mango", "Strawberry", "Apple" };

fruits.Add("Pineapple");

fruits.Remove("Apple");

Console.WriteLine("List of favorite fruits:");
foreach (string fruit in fruits)
{
    Console.WriteLine($"- {fruit}");
}

Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
{
    { 1, "Mango" },
    { 2, "Strawberry" },
    { 3, "Pineapple" }
};

fruitDictionary.Add(4, "Banana");

Console.WriteLine("\nFruit Dictionary (ID -> Name):");
foreach (KeyValuePair<int, string> entry in fruitDictionary)
{
    Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
}
