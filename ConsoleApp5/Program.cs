using System;
using System.Collections.Generic; // Required for using List<T>

class Program
{
    public static void Main(string[] args)
    {
        // Define an array of strings where each string contains a number at the end.
        string[] arr = { "apple1", "cherry2", "banana3" };

        // Initialize a nullable string variable `constring` to null.
        // This will be used to concatenate all the strings in the array.
        string? constring = null;

        // Loop through each string in the array `arr`.
        foreach (string s in arr)
        {
            // Concatenate the current string `s` to `constring`.
            // Initially, `constring` is null, so the first concatenation will result in just the first string.
            // Subsequent iterations will keep appending the next strings.
            constring = constring + s;
        }

        // Print the concatenated string `constring`.
        // At this point, `constring` will contain: "apple1cherry2banana3".
        Console.WriteLine(constring);

        // Create a new list of integers to store the numbers found in the concatenated string.
        List<int> ae = new List<int>();

        // Loop through numbers 0 to 8 (i.e., 9 iterations).
        for (int i = 0; i < 9; i++)
        {
            // Check if the concatenated string `constring` contains the current number `i` as a string.
            // For example, if `i` is 1, it checks if "1" exists in `constring`.
            if (constring.Contains(i.ToString()))
            {
                // If the number is found, add it to the list `ae`.
                ae.Add(i);
            }
        }

        // After the loop, print the maximum value found in the list `ae`.
        // The `Max()` method returns the largest number in the list.
        Console.WriteLine($"MAX Value: {ae.Max()}");

        // Similarly, print the minimum value found in the list `ae`.
        // The `Min()` method returns the smallest number in the list.
        Console.WriteLine($"MIN Value: {ae.Min()}");
    }
}