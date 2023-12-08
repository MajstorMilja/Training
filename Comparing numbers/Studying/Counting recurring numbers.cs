
Random random = new Random();
List<int> randomNumbers = new List<int>();
for (int i = 0; i < 20; i++)
{
    randomNumbers.Add(random.Next(1, 21)); 
}
Console.WriteLine("Random numbers:");
Console.WriteLine(string.Join(", ", randomNumbers));
Dictionary<int, int> numberCounts = new Dictionary<int, int>();
foreach (int number in randomNumbers)
{
    // Check if the number is already in the dictionary
    if (numberCounts.ContainsKey(number))
    {
        // Increment the count if it's already present
        numberCounts[number]++;
    }
    else
    {
        // Add the number to the dictionary with a count of 1 if it's not present
        numberCounts[number] = 1;
    }
}
Console.WriteLine("\nNumber counts:");
foreach (var kvp in numberCounts)
{
    Console.WriteLine($"Number {kvp.Key}: {kvp.Value} times");
}


//2nd way of doing the same thing
func();
static void func()
{
    Random random = new Random();
    List<int> randomNumbers = Enumerable.Range(1, 20).Select(_ => random.Next(1, 11)).ToList();

    Console.WriteLine("Generated random numbers:\n" + string.Join(", ", randomNumbers));

    var numberCounts = randomNumbers.GroupBy(num => num).ToDictionary(group => group.Key, group => group.Count());

    Console.WriteLine("\nNumber counts:");
    foreach (var kvp in numberCounts)
    {
        Console.WriteLine($"Number {kvp.Key}: {kvp.Value} times");
    }
}


//3rd way
Random rnd = new Random();
Dictionary<int, int> nums = new Dictionary<int, int>();

Console.WriteLine("Random numbers:");
for (int i = 0; i < 20; i++)
{
    int randomNumber = rnd.Next(1, 21);

    // Output the random number
    Console.Write(randomNumber + ", ");

    // Update the count in the dictionary
    if (nums.ContainsKey(randomNumber))
    {
        nums[randomNumber]++;
    }
    else
    {
        nums[randomNumber] = 1;
    }
}
Console.WriteLine("\nNumber counts:");
foreach (var kvp in nums)
{
    Console.WriteLine($"Number {kvp.Key}: {kvp.Value} times");
}
