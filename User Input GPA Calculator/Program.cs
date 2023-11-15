int numberOfCourses = 3;

string[] courseCodes = new string[numberOfCourses];
int[] courseUnits =  new int[ numberOfCourses];
int[] scoreInCourse = new int[numberOfCourses];

for (int i = 0; i < numberOfCourses; i++)
{
    Console.Write("Enter Course Code " + (i + 1) + ":"); // Prompt the user
    courseCodes[i] = Console.ReadLine();

    Console.Write("Enter Course Unit for " + courseCodes[i] + ": ");
    if (int.TryParse(Console.ReadLine(), out int unit))
    {
        courseUnits[i] = unit;
    }
    else
    {
        Console.WriteLine("Invalid input for course unit. Please enter a valid number.");
        i--; // Takes you back to the beginning in the case of an invalid user input.
        continue;
    }

    Console.Write("Enter Course Score for " + courseCodes[i] + ": ");
    if (int.TryParse(Console.ReadLine(), out int score))
    {
        scoreInCourse[i] = score;
    }
    else
    {
        Console.WriteLine("Invalid input for course score. Please enter a valid number.");
        i--; // Takes you back to the beginning in the case of an invalid user input.
    }
}

// The arrays courseCodes, courseUnits, and courseScores now contain their respective data.




// Calculate GPA
decimal totalGradePoints = 0;
int totalUnits = 0;

Console.WriteLine("\nSubject\t\t| Unit\t\t| Score\t\t| Grade\t\t| Grade Point");
for (int i = 0; i < numberOfCourses; i++)
{
    totalGradePoints += courseUnits[i] * CalculateGradePoint(scoreInCourse[i]);
    totalUnits += courseUnits[i];

    Console.WriteLine($"{courseCodes[i]}\t\t| {courseUnits[i]}\t\t| {scoreInCourse[i]}\t\t| {CalculateGrade(scoreInCourse[i])}\t\t| {CalculateGradePoint(scoreInCourse[i])}");
}

decimal gpa = totalGradePoints / totalUnits;

Console.WriteLine("\nYour GPA is: " + gpa);

// Function to convert score to grade.
decimal CalculateGradePoint(int score)
{
    if (score >= 70) return 5.0m;
    else if (score >= 60) return 4.0m;
    else if (score >= 50) return 3.0m;
    else if (score >= 44) return 2.0m;
    else if (score >= 40) return 1.0m; 
    else return 0.0m;
}

string CalculateGrade(int score)
{
    if (score >= 70) return "A";
    else if (score >= 60) return "B";
    else if (score >= 50) return "C";
    else if (score >= 44) return "D";
    else if (score >= 40) return "E";
    else return "F";
}


















