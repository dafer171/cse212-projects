public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        {
            if (value == Data)
                return;
            if (value < Data)
            {
                // Insert to the left
                if (Left is null)
                    Left = new Node(value);
                else
                    Left.Insert(value);
            }
            else
            {
                // Insert to the right
                if (Right is null)
                    Right = new Node(value);
                else
                    Right.Insert(value);
            }
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
            return true;

        if (value < Data)
        {
            if (Left != null)
            {
                return Left.Contains(value);
            }
            return false;
        }

        if (value > Data)
        {
            if (Right != null)
            {
                return Right.Contains(value);
            }
            return false;
        }

        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        if (Left is null & Right is null)
            return 1;

        int leftHeight = 0;
        int rightHeight = 0;

        if (Left != null)
        {
            leftHeight = Left.GetHeight();
        }

        if (Right != null)
        {
            rightHeight = Right.GetHeight();
        }
        return 1 + Math.Max(leftHeight, rightHeight); // Replace this line with the correct return statement(s)
    }
}