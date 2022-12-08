var RucksackData = File.ReadAllText("PuzzleInput.txt");

// Test Data
/*
const string dummyData = @"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw";
*/

var splitData = RucksackData.Split('\n');
int counter = 0;

foreach (var s in splitData)
{
    var splitStartLine = s[..(s.Length / 2)];
    var splitEndLine = s.Substring(s.Length / 2);
    char letter = new char();
    foreach (var l in splitStartLine)
    {
        if (splitEndLine.Contains(l))
        {
            letter = l;
            // Console.Write($"Found {l} in {splitEndLine} from {splitStartLine}, ");
        }
    }

    // https://stackoverflow.com/questions/20044730/convert-character-to-its-alphabet-integer-position
    var alphabetCount = ((int)letter % 32);

    if (Char.IsUpper(letter)) alphabetCount += 26;
    // Console.WriteLine($"Adding {alphabetCount} Points");
    counter += alphabetCount;
}

Console.WriteLine($"Part 1: Solution is: {counter}");
counter = 0;

for (int i = 1; i < splitData.Length / 3 + 1; i++)
{
    var firstLine = splitData[i * 3 - 3];
    var secondLine = splitData[i * 3 - 2];
    var thirdLine = splitData[i * 3 - 1];
    char letter = new char();

    foreach (var l in firstLine)
    {
        if (secondLine.Contains(l) && thirdLine.Contains(l))
        {
            letter = l;
        }
    }
    var alphabetCount = ((int)letter % 32);

    if (Char.IsUpper(letter)) alphabetCount += 26;
    // Console.WriteLine($"Adding {alphabetCount} Points");
    counter += alphabetCount;
}
Console.WriteLine($"Part 2: Solution is: {counter}");