using System.Collections.Generic;

List<string> fruits = new List<string> { "Avocado", "Apple", "Guava" };

fruits.Add("Orange");

fruits.Remove("Apple");

Console.WriteLine("Fruits in the list:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
{
    { 1, "Avocado" },
    { 2, "Guava" },
    { 3, "Orange" }
};

fruitDictionary.Add(4, "Pineapple");

Console.WriteLine("\nFruits in the dictionary:");
foreach (var pair in fruitDictionary)
{
    Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");
}