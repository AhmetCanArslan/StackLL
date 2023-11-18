
public class Node
{
    public int data;
    public Node next;
    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}
public class Stack
{
    private Node ust;
    public Stack() { ust = null; }

    public void Push(int data)
    {
        Node newNode = new Node(data);
        newNode.next = ust;
        ust = newNode;
    }

    public void Pop()
    {
        if (ust == null)
        { 
            Console.WriteLine("Stack is empty");
            return;
        }
        ust = ust.next;
    }
    public int Peek()
    {
        if (ust == null)
            return -1;
        return ust.data;
    }
}

class Hello
{
    public static void Main()
    {
        Stack stack = new Stack();
        stack.Push(10);
        stack.Push(21);
        stack.Push(90);
        Console.WriteLine(stack.Peek());
        stack.Pop();
        stack.Pop();
        Console.WriteLine(stack.Peek());
        
    }
}