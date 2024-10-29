namespace Linq;

class Program
{
    static void Main(string[] args)
    {
        //1.
        // var numbers = Enumerable.Range(1, 10).ToList(); // = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // var result = numbers.Where(n => n > 5);

        // foreach (int number in result)
        // {
        //     Console.WriteLine(number);
        // }

        //2.
        // var words = new List<string>() {"apple", "banana", "cherry"};

        // var wordLength = words.Select(word => word.Length);

        // foreach (var word in wordLength)
        // {
        //     Console.WriteLine(word);
        // }

        //3.
        // var words = new List<string>() {"John", "Alice", "Bob"};

        // var orderedWords = words.OrderBy(n => n);

        // foreach(var word in orderedWords)
        // {
        //     Console.WriteLine(word);
        // }

        //4.
        // var numbers = Enumerable.Range(1, 10).ToList();

        // var filteredNumbers = numbers.Where(n => n%2 == 0);

        // foreach (var number in filteredNumbers)
        // {
        //     Console.WriteLine(number);
        // }

        //5.
        // var numbers = Enumerable.Range(1, 10).ToList();

        // var sum = numbers.Sum();

        // Console.WriteLine(sum);

        //6.
        // var numbers = new List<int>() { 85, 90, 78, 92, 88 };

        // var averageOfNumbers = numbers.Average();

        // Console.WriteLine(averageOfNumbers);

        //7.
        // var cities = new List<string>() { "Los Santos", "New York", "Los Angeles", "Chicago" };

        // var city = cities.FirstOrDefault(c => c.StartsWith('L'));

        // Console.WriteLine(city ?? "No match");

        //8. 
        // var fruits = new List<string>() {"apple", "banana", "cherry"};

        // var fruitExists = fruits.Any(f => f.StartsWith('b'));

        // Console.WriteLine(fruitExists);

        //9.
        // var numbers = Enumerable.Range(1, 10).ToList();

        // var evenNumbers = numbers.Count(n => n % 2 == 0);

        // Console.WriteLine($"There are {evenNumbers} even numbers in this list.");

        //10.
        // var animals = new List<string>() {"cat", "dog", "elephant", "cow", "duck"};

        // var groupByFirstLetter = animals.GroupBy(animal => animal[0]);

        // foreach(var group in groupByFirstLetter)
        // {
        //     Console.WriteLine($"Animals that starts with '{group.Key}'");
        //     foreach(var animal in group)
        //     {
        //         Console.WriteLine($"🌟 {animal}");
        //     }
        // }
    }
}