var calorieList = File.ReadAllText("PuzzleInput.txt");

// Test Data
/*
const string dummyData = @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";
*/

var calorieListSplit = calorieList.Split('\n');

var calorieSum = new List<int>();
var currentCalories = 0;

foreach (var s in calorieListSplit)
{
    if (s != string.Empty)
    {
        currentCalories += int.Parse(s);
    }
    else
    {
        calorieSum.Add(currentCalories);
        currentCalories = 0;
    }
}

if (currentCalories > 0)
{
    calorieSum.Add(currentCalories);
}

calorieSum.Sort();
int topmostThree = calorieSum[^1] + calorieSum[^2] + calorieSum[^3];

Console.WriteLine($"Part 1: Die Elve trägt insegsammt {calorieSum[^1]} Kalorieren");
Console.WriteLine($"Part 2: Die 3 fleißigsten Elven tragen insgesammt {topmostThree} Kalorieren");