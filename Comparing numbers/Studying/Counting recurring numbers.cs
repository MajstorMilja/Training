
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
    if (numberCounts.ContainsKey(number))
    {
        numberCounts[number]++;
    }
    else
    {
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

int[] numbs = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };
int result = LongestIncreasingSubsequence(numbs);
Console.WriteLine(result);
static int LongestIncreasingSubsequence(int[] numbs)
{
    if (numbs == null || numbs.Length == 0)
        return 0;

    int n = numbs.Length;
    int[] dp = new int[n];
    int maxResult = 1;

    for (int i = 0; i < n; i++)
    {
        dp[i] = 1; 

        for (int j = 0; j < i; j++)
        {
            if (numbs[i] > numbs[j] && dp[i] < dp[j] + 1)
            {
                dp[i] = dp[j] + 1;
            }
        }

        maxResult = Math.Max(maxResult, dp[i]);
    }

    return maxResult;
}

static void bubbleSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                // Swap array[j] and array[j + 1]
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

bubbleSort(numbs);
foreach (var item in numbs)
{
    Console.WriteLine(item);
}