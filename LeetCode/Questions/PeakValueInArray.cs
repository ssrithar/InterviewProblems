public class PeakValueInArray
{
    public PeakValueInArray()
    {
        int[] arr = { 1, 2, 3, 5, 6, 7, 2, 1 };

        int peakValue = FindPeakValue(arr, 0, arr.Length - 1);
        Console.WriteLine($"The peak value is: {peakValue}");
    }

    public int FindPeakValue(int[] arr, int left, int right)
    {
        if (left == right) return arr[left];

        int mid = left + (right - left) / 2;

        if (arr[mid] < arr[mid + 1])
        {
            return FindPeakValue(arr, mid + 1, right);
        }
        else
        {
            return FindPeakValue(arr, left, mid);
        }
    }
}