DateTime birthDate = new DateTime(2004, 7, 23);

DateTime currentDate = DateTime.Now;

TimeSpan ageSpan = currentDate - birthDate;
int ageInYears = (int)(ageSpan.TotalDays / 365.25);

DateTime newDate = birthDate.AddDays(10);

Console.WriteLine($"Your Birthdate: {birthDate.ToShortDateString()}");
Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
Console.WriteLine($"Your Age: {ageInYears} years");
Console.WriteLine($"Birthdate after adding 10 days: {newDate.ToShortDateString()}");