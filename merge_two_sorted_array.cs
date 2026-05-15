// Merge two sorted array

// arr1: [1,3,5,7,9]
// arr2: [2,4,6,8]
// result: [1,2,3,4,5,6,7,8,9]

// Approach
// i at arr1[0] and j at arr2[0] now compare ith value with jth
// if ith > jth, insert ith to result and i ++, then compare new ith value with jth, 
// if jth > ith, insert jth to result and j++

// Time Complexity: O(N+M)
// Space complexity: O(N+M)

int[] arr1 = { 1, 3 };
int[] arr2 = { 2, 4, 5, 6 };
int[] result = new int[arr1.Length + arr2.Length];

int i = 0;
int j = 0;
int k = 0;

while (i < arr1.Length && j < arr2.Length)
{
    if (arr1[i] > arr2[j])
    {
        result[k] = arr2[j];
        j++;
    }
    else
    {
        result[k] = arr1[i];
        i++;
    }
    k++;
}

while (i < arr1.Length)
{
    result[k] = arr1[i];
    k++;
    i++;
}


while (j < arr2.Length)
{
    result[k] = arr2[j];
    k++;
    j++;
}

foreach (var i in result)
{
    Console.WriteLine(i);
}