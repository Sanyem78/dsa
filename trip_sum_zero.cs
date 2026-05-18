// Find the unique triplets in the given array whose sum is 0

// input: [-1,0,1,2,-1,4]
// output: [-1,-1,2], [-1,0,1]

// Approach
// Sort the array, and loop for the whole array 
// skip the subsequent repeating elements
// the logic is a+b+c = 0, b+c = -a
// Now this is the two sum problem, calculate that b and c exist for each a.
// In order to find unique just skip the subsequent element if it already exists

// Time complexity : O(n^2)
// Space complexity : O(1)

int[] arr = {-1,0,1,2,-1,4};
List<List<int>> result = new List<List<int>>();
arr.Sort();
for(int i = 0; i < arr.Length-2; i++)
{
    if(i>0 && arr[i] == arr[i - 1])
    {
        continue;
    }

    int sum = -arr[i];
    int j = i+1;
    int k = arr.Length - 1;

    while (j < k)
    {
        if(arr[j]+arr[k] == sum)
        {
            result.Add(new List<int>{arr[i],arr[j],arr[k]});
            j++;
            k--;
            while(j<k && arr[j] == arr[j - 1])
            {
                j++;
            }
            while(j>=0 && arr[k] == arr[k + 1])
            {
                k--;
            }
        }
        else if (arr[j] + arr[k] > sum)
        {
            k--;
        }
        else
        {
            j++;   
        }
    }
}

foreach(var re in result)
{
    foreach(var r in re)
    {
        Console.Write($"{r},");
    }
    Console.WriteLine();
}