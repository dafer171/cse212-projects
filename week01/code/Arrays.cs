public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        /*
        Plan
        1. Create a list called 'result'
        2. If number > 0:
            2.1 Iterate from 'number' to 'number * length', adding 'number' each time
            2.2 Add each multiple to the 'result' list
        3. If number < 0:
            3.1 Iterate from 'number' to 'number * length', subtracting 'number' each time
            3.2 Add each multiple to the 'result' list
        4. Convert the list to an array and return it
        */

        // New List
        List<double> result = new();

        // If number > 0:
        if (number > 0)
        {
            // Iterate from 'number' to 'number * length', adding 'number' each time
            for (var i = number; i <= number * length; i += number)
            {
                // Add each multiple to the 'result' list
                result.Add(i);
            }
        }
        // Code didn't work for negative numbers
        else
        {
            //Iterate from 'number' to 'number * length', subtracting 'number' each time
            for (var i = number; i >= number * length; i += number)
                //Add each multiple to the 'result' list
                result.Add(i);
        }
        return result.ToArray(); // Convert the list to an array and return it
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        List<int> movedRight = new List<int>(new int[data.Count]);
        // new list is necesary to hold the new values without losing the originals ones
        for (var i = 0; i <= data.Count - 1; i++)
            movedRight[i] = data[(i - amount + data.Count) % data.Count];
        //rotating indexes
        data.Clear();
        data.AddRange(movedRight);
        return;
    }

}
