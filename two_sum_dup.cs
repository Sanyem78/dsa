// Find the unique pairs of numbers whose sum is equal to the target

// input: [1,1,1,1,2,2,3,3,3], target: 4
// output: [1,3] [2,2]

// Approach
// Using two pointer, when you find the correct pair increment i and decrement j. Now try to increment i till you find the new value of i
// It means if 1,1,2. increment i till it finds the new value i.e. 2 , similar for j

int[] arr = {1,1,1,1,2,2,3,3,3};
int target = 4;

List<(int,int)> result = new List<(int, int)>();

int i = 0;
int j = arr.Length - 1;

while (i < j)
{
    if(arr[i]+arr[j] == target)
    {
        result.Add((arr[i],arr[j]));
        i++;
        j--;
        while(arr[i] == arr[i - 1])
        {
            i++;
        }
        while(arr[j] == arr[j + 1])
        {
            j--;
        }
    }
    else if (arr[i] + arr[j] > target)
    {
        j--;
    }
    else
    {
        i++;
    }
}

foreach(var r in result)
{
    Console.WriteLine(r);
}