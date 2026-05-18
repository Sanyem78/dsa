// Array unsorted
// Two numbers sum should be equal to target, Return the index not number

// [2,7,5,1,9] target = 7

// Approach
// We cannot sort the array because the index will lost, so two pointer cant be used
// We can use Dictionary/HashMap to store theeach element from the array and will check
// if Target - array[i] exist in the Dictionary or not

// Time Complexity: O(N)
// Space Complexity: O(N)

int[] array = { 2, 7, 5, 1, 9 };
int target = 7;

Dictionary<int, int> dict = new Dictionary<int, int>();

int j = -1;
int i = 0;
for (i = 0; i < array.Length; i++)
{
    if (dict.ContainsKey(target - array[i]))
    {
        j = i;
        i = dict[target - array[i]];
        break;
    }
    else
    {
        dict[array[i]] = i;
    }
}

if (j == -1) Console.WriteLine("Numbers doesnot exist");
else Console.WriteLine($"Indexes of the numbers are {i} and {j}");