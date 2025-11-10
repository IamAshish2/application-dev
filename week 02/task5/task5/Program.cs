// Task 5: Date Time and Time Span [10 minutes]
// Creates a DateTime variable representing your birthdate.
//     Creates another DateTime variable representing the current date and time.
//     Calculates your age using TimeSpan (you'll need to subtract the two DateTime values).
// Prints your birthdate, the current date, and your age in years.
//     Adds 10 days to your birthdate and prints the resulting date.

DateTime birthDate = new DateTime(2005,08,05);
DateTime now = DateTime.Now;

TimeSpan ageDifference = now - birthDate;
int ageInYears = (int)(ageDifference.TotalDays / 365.25);

Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
Console.WriteLine($"Current Date: {now.ToShortDateString()}");
Console.WriteLine($"You are approximately {ageInYears} years old.");

DateTime newDate = birthDate.AddDays(10);
Console.WriteLine($"Your birthdate plus 10 days is: {newDate.ToShortDateString()}");

