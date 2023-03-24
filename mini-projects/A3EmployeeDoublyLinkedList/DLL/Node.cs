using A3EmployeeDoublyLinkedList.Entities;

namespace A3EmployeeDoublyLinkedList.DLL;

public class Node
{
    public Employee Element;

    public Node? Next;

    public Node? Previous;

    public Node(Employee element, Node? next, Node? previous)
    {
        Element = element;

        Next = next;

        Previous = previous;
    }

}

