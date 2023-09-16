
WriteLine("Welcome to Bethany's Pie Shop HRM");

ShowBasicDataTypesDemo();

WriteLine("\n\nPress any key ...");
ReadKey();

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