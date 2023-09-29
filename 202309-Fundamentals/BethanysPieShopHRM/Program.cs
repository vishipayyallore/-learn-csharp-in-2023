WriteLine("Welcome to Bethany's Pie Shop HRM");

ShowBasicDataTypesDemo();
ShowBasicCharDemo();

WriteLine("\n\nPress any key ...");
ReadKey();

static void ShowBasicCharDemo()
{
    char userSelection = 'a';

    char upperVersion = char.ToUpper(userSelection);
    WriteLine($"{userSelection} ToUpper: {upperVersion}");

    bool isDigit = char.IsDigit(userSelection);
    WriteLine($"{userSelection} Is Digit: {isDigit}");

    bool isLetter = char.IsLetter(userSelection);
    WriteLine($"{userSelection} Is Letter: {isLetter}");
}

static void ShowBasicDataTypesDemo()
{
    byte numberOfEmployees = 125;
    int months = 12, bonus = 1000;
    var monthlyWage = 1234;
    bool isActive = true;
    double rating = 99.25;
    int hoursWorked = 180;
    const double interestRate = 0.07;

    Write("Enter your name:");
    string? name = ReadLine();

    WriteLine($"Number of employees: {numberOfEmployees}");
    WriteLine($"Employee Name: {name}");
    WriteLine($"Number of Months: {months}");
    WriteLine($"Bonus: {bonus}");
    WriteLine($"Monthly Wage: {monthlyWage}");
    WriteLine($"Is Active: {isActive}");
    WriteLine($"Rating: {rating}");
    WriteLine($"Hours Worked: {hoursWorked}");
    WriteLine($"Interest Rate: {interestRate}");
}
