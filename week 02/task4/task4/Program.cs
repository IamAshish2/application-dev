// Creates a single-dimensional integer array containing 5 of your favorite numbers.
//     Uses Array.Sort() to sort the array in ascending order.
//     Uses Array.Reverse() to reverse the sorted array.
//     Prints each element of the array using a for loop.
//     Uses Array.IndexOf() to find the position of a specific number in the array.



int[] favoriteNumbers = { 42, 7, 89, 23, 15 };

Array.Sort(favoriteNumbers);

Array.Reverse(favoriteNumbers);

Console.WriteLine("Favorite numbers (sorted in descending order):");
for (int i = 0; i < favoriteNumbers.Length; i++)
{
    Console.WriteLine($"Element {i}: {favoriteNumbers[i]}");
}

int numberToFind = 23;
int position = Array.IndexOf(favoriteNumbers, numberToFind);

if (position != -1)
{
    Console.WriteLine($"\nThe number {numberToFind} is found at index position {position}.");
}
else
{
    Console.WriteLine($"\nThe number {numberToFind} is not found in the array.");
}