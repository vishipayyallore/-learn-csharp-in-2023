using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3EmployeeDoublyLinkedList.Entities;

public class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public bool IsNamePalindrome => CheckPalindrome();

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
}
