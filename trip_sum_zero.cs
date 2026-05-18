// input: [-1,0,1,2,-1,4]

// Time complexity : O(n^2)
// Space complexity : O(k)

int[] arr = {-1,0,1,2,-1,4};
List<List<int>> result = new List<List<int>>();
arr.Sort();
for(int i = 0; i < arr.Length; i++)
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
            while(j<k && arr[k] == arr[k + 1])
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