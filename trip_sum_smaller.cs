// No duplicates
// Array = [-1, 4, 2, 1, 3]        
// Target = 5

// Array = [-1, 0, 2, 3]
// Target = 3

// Time Complexity : O(N^2)
// Space Complexity: O(1)

int[] arr = { -1, 0, 2, 3 };
int target = 3;

arr.Sort();
int answer = 0;

for (int i = 0; i < arr.Length - 2; i++)
{
    int j = i + 1;
    int k = arr.Length - 1;
    int sum = target - arr[i];
    while (j < k)
    {
        int currentSum = arr[j] + arr[k];
        if (currentSum < sum)
        {
            answer = answer + (k - j);
            j++;
        }
        else
        {
            k--;   
        }
        
    }
}

Console.WriteLine(answer);
