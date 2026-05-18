// Array = [-1, 2, 1, -4]
// Target = 1

// a+b+c= target, b+c = target-a

int[] arr = { -1, 2, 1, -4 };
int target = 1;

arr.Sort();

List<int> result = new List<int>();

int resSum;
int maxDiff = int.MaxValue;

for (int i = 0; i < arr.Length - 2; i++)
{
    if (i > 0 && arr[i] == arr[i - 1])
    {
        continue;
    }

    int j = i + 1;
    int k = arr.Length - 1;

    while (j < k)
    {
        int currentSum = arr[i] + arr[j] + arr[k];
        int absoluteDiff = Math.Abs(target - currentSum);

        if (absoluteDiff < maxDiff)
        {
            maxDiff = absoluteDiff;
            result = new List<int>() { arr[i], arr[j], arr[k] };
            resSum = arr[i] + arr[j] + arr[k];
        }
        if (currentSum == target)
        {
         
            break;
        }
        else if (currentSum < target)
        {
            j++;
        }
        else
        {
            k--;
        }
        
    }

    if (maxDiff == 0) break;
}

foreach (var res in result)
{
    Console.WriteLine(res);
}


Console.WriteLine($"Sum of the triplets are {resSum}");