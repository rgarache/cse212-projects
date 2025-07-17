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
        // Plan:
        // 1. Create an array of doubles with the specified length
        // 2. Use a loop to fill the array with multiples of the input number
        // 3. For each index i (0-based), the value will be number * (i + 1)
        //    because:
        //    - index 0: number * 1
        //    - index 1: number * 2
        //    - ...
        //    - index length-1: number * length
        // 4. Return the filled array

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
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
        // Plan:
        // 1. Calculate the effective rotation amount 
        // 2. Find the split point: data.Count - amount
        // 3. Get the right part that needs to be moved to the front 
        // 4. Get the left part that needs to be moved after the right part
        // 5. Combine them by:
        //    a) First removing the right part from the list
        //    b) Then inserting it at the beginning
        // OR:
        //    a) Create a new list by combining the right part and left part
        //    b) Clear the original list
        //    c) Add all items from the new list to the original list

        // Implementation option 1:
        int splitIndex = data.Count - amount;
        List<int> rightPart = data.GetRange(splitIndex, amount);
        List<int> leftPart = data.GetRange(0, splitIndex);

        data.Clear();
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}
