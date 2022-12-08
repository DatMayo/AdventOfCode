var MatchData = File.ReadAllText("PuzzleInput.txt");

// Test Data
/*
const string dummyData = @"A Y
B X
C Z";
*/

var partOneWinCondition = new List<string>(new[]
{
    "AY",
    "BZ",
    "CX"
});
var partOneDrawCondition = new List<string>(new[]
{
    "AX",
    "BY",
    "CZ"
});

int points = 0;

string[] MatchDataSplit = MatchData.Split('\n');
foreach (var s in MatchDataSplit)
{
    int roundPoints = 0;
    var match = s.Replace(" ", "");

    if (match[1] == 'X') roundPoints += 1; // Rock = 1 Point
    if (match[1] == 'Y') roundPoints += 2; // Paper = 2 Points
    if (match[1] == 'Z') roundPoints += 3; // Scissors = 3 Points

    if (partOneWinCondition.Contains(match))
    {
        roundPoints += 6;
    }
    else if (partOneDrawCondition.Contains(match))
    {
        roundPoints += 3;
    }

    points += roundPoints;
}

Console.WriteLine($"Part 1: Du hast insgesammt {points} Punkte");
points = 0;

MatchDataSplit = MatchData.Split('\n');

foreach (var s in MatchDataSplit)
{
    int roundPoints = 0;
    var match = s.Replace(" ", "");

    // Loose
    if (match[1] == 'X')
    {
        switch (match[0])
        {
            case 'A':
                roundPoints += 3; // Er Stein, ich Schrere
                break;

            case 'B':
                roundPoints += 1; // Er Papier, ich Stein
                break;

            case 'C':
                roundPoints += 2; // Er Schere, ich Papier
                break;
        }
    }

    // Draw
    if (match[1] == 'Y')
    {
        roundPoints += 3;
        switch (match[0])
        {
            case 'A':
                roundPoints += 1; // Er Stein, ich Stein
                break;

            case 'B':
                roundPoints += 2; // Er Papier, ich Papier
                break;

            case 'C':
                roundPoints += 3; // Er Schere, ich Schere
                break;
        }
    }

    // Win
    if (match[1] == 'Z')
    {
        roundPoints += 6;
        switch (match[0])
        {
            case 'A':
                roundPoints += 2;
                break;

            case 'B':
                roundPoints += 3;
                break;

            case 'C':
                roundPoints += 1;
                break;
        }
    }
    points += roundPoints;
}
Console.WriteLine($"Part 2: Du hast insgesammt {points} Punkte");