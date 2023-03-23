using A3EmployeeDoublyLinkedList.Entities;

namespace A3EmployeeDoublyLinkedList.DLL;

public class DoublyLinkedList
{
    private Node? head;
    private Node? tail;
    private int size;

    public DoublyLinkedList()
    {
        head = null;

        tail = null;

        size = 0;
    }

    public int Length() => size;

    public bool IsEmpty() => size == 0;

    public void AddLast(Employee element)
    {
        Node newest = new(element, default, default);

        if (IsEmpty())
        {
            head = newest;
            tail = newest;
        }
        else
        {
            tail!.Next = newest;

            newest.Previous = tail;

            tail = newest;
        }

        size++;
    }

    public void Display()
    {
        Node? p = head;

        while (p is not null)
        {
            WriteLine(p.Element + " --> ");

            p = p.Next;
        }

        WriteLine();
    }


}

