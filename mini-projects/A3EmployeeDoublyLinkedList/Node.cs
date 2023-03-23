namespace A3EmployeeDoublyLinkedList;

public class Node
{
    public int Element;

    public Node? Next;

    public Node? Previous;

    public Node(int element, Node? next, Node? previous)
    {
        Element = element;

        Next = next;

        Previous = previous;
    }

}

