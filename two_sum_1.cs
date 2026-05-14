// Array unsorted
// Two numbers sum should be equal to target, Return the number not index   
// Do no use extra space

// [2,7,5,1,9] target = 7

// Approach
// Sort the array [1,2,5,7,9] as we need numbers not index
// keep i on front and j on end, if sum of i and j is greater than target then dec j (1+9>7, 1+7>7, 1+5<7),
// if sum of i and j is smaller than the target then inc i (1+5<7, 2+5==7)

// Time Complexity: O(nlogn)
// Space Complexity: O(1)

int[] array = { 2, 7, 5, 1, 9 };
int target = 7;
array.Sort();

int j = array.Length - 1;
int i = 0;
while (i < j)
{
    if (array[i] + array[j] == target)
    {
        break;
    }
    else if (array[i] + array[j] > target)
    {
        j--;
    }
    else
    {
        i++;
    }
}

if (i >= j)
{
    Console.WriteLine("Numbers do not exist");
}
else
{
    Console.WriteLine($"Numbers are {array[i]} and {array[j]}");
}