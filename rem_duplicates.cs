// Remove duplicates from the sorted array using No extra space

// [1,1,1,1,2,2,2,2,2,3,3,4,5,5,6]
// [1,2,3,4,5,6,....]

// Approach
// i should be placed at 0 and j at 1, compare ith value and jthe value if they are equal increment j
// if not equal increment i and insert jth value to new ith value

// Time Complexity: O(N)
// Space Complexity: O(1)

int[] array = { 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 4, 5, 5, 6 };

int i = 0;
int j = 1;
int uniqueElementCounter = 1;

while (j != array.Length)
{
    if (array[i] == array[j])
    {
        j++;
    }
    else
    {
        i++;
        array[i] = array[j];
        j++;
        uniqueElementCounter++;
    }
}

Console.WriteLine($"Unique elements in this array are: {uniqueElementCounter}");

foreach (var i in array)
{
    Console.WriteLine(i);
}