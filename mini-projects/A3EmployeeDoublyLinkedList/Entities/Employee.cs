namespace A3EmployeeDoublyLinkedList.Entities;

public class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public bool IsNamePalindrome => CheckPalindrome();

    public int SingleDigitSumOfId => GetSingleDigitSumOfId();

    public override string ToString()
    {
        return $"{Id} => {SingleDigitSumOfId} | {Name} => {IsNamePalindrome}";
    }

    private bool CheckPalindrome()
    {
        bool isPalindrome = true;

        for (int i = 0; i < Name.Length / 2; i++)
        {
            if (Name[i] != Name[Name.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        return isPalindrome;
    }

    private int GetSingleDigitSumOfId()
    {
        int sum = Id;

        while (Id > 9)
        {
            sum = 0;

            while (Id > 0)
            {
                sum += Id % 10;
                Id /= 10;
            }

            Id = sum;
        }

        return sum;
    }
}
