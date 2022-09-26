//task 1

Random rnd = new Random();
int[] nums = new int[10];
int max = 0;
int min = 100;
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = rnd.Next() % 100;
    Console.Write(nums[i]+" ");
    if (nums[i] < min)
    {
        min = nums[i];
    }
    if (nums[i] > max)
    {
        max = nums[i];
    }
}
Console.WriteLine('\n'+ "max = " + max + '\n' + "min = " + min);
int temp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
for (int i = 0; i < nums.Length; i++)
{
    Console.Write(nums[i]+" ");
}