// Square the sorted array and the resulted array should also be sorted

// arr [-4,-1,0,3,10]
// output: [0,1,9,16,100]

// Approach
// Create two lists one for -ve elements and another for +ve elements
// store the square of each elements in their respective lists
// reverse the -ve list because the square of -ve will be sorted in the reverse order
// Now simply implement the merge two sorted array

// Time Complexity: O(N)
// Space Complexity: O(N)

int[] arr = { -10, -8, -1, 0 };
int[] output = new int[arr.Length];

List<int> arr1 = new List<int>();
List<int> arr2 = new List<int>();

int k = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] <= 0)
    {
        arr1.Add(arr[i]*arr[i]);
    }
    else
    {
        arr2.Add(arr[i]*arr[i]);
    }
}
arr1.Reverse();

int i = 0;
int j = 0;
int l = 0;

while (i < arr1.Count && j < arr2.Count)
{
    if (arr1[i] > arr2[j])
    {
        output[l] = arr2[j];
        j++;
    }
    else
    {
        output[l] = arr1[i];
        i++;
    }
    l++;
}

while (i < arr1.Count)
{
    output[l] = arr1[i];
    i++;
    l++;
}

while (j < arr2.Count)
{
    output[l] = arr2[j];
    j++;
    l++;
}

foreach (var i in output)
{
    Console.WriteLine(i);
}

// Second Approach
// the largest square will definietly come from either the first element or the last element
// if we find the larget from first, insert at the end of the output and increment left and again compare left with right
// if we find the largest from last, insert that element before the prev inserted element and increment right

// Time Complexity : O(N)
// Space Complexity : O(1)

int left = 0;
int right = output.Length - 1;
int pointer = output.Length - 1;

while (left < right)
{
    int first = arr[left] * arr[left];
    int last = arr[right] * arr[right];

    if (first > last)
    {
        output[pointer] = first;
        left++;
    }
    else
    {
        output[pointer] = last;
        right--;
    }
    pointer--;
}

foreach (var i in output)
{
    Console.WriteLine(i);
}