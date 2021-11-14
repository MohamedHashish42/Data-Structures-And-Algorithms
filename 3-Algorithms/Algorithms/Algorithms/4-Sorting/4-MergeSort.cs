using System;

class MergeSort
{

    public static int T (int n)
    {
        if (n <= 1)
            return 0;

        return 2 * T(n / 2) + n;
        
    }

    #region  Divide Part
    public static int[] Sort(int[] array)
    {

        //As this is a recursive algorithm, we need to have a base case to 
        //avoid an infinite recursion and therfore a stackoverflow
        if (array.Length <= 1)
            return array;



        int[] left;
        int[] right;

        int midPoint = array.Length / 2;
        var leftLen = array.Length - midPoint;
        var rightLen = midPoint;
        left = new int[leftLen];
        right = new int[rightLen];


        for (int i = 0; i < leftLen; i++)
            left[i] = array[i];

        for (int i = leftLen; i < array.Length; i++)
            right[i - (leftLen)] = array[i];

        left = Sort(left);
        right = Sort(right);

        //Merge our two sorted arrays
        return Merge(left, right);

    }
    #endregion

    #region  Conquer Part
    private static int[] Merge(int[] left, int[] right)
    {
        var leftLength = left.Length;
        var rightLength = right.Length;
        int resultLength = right.Length + left.Length;
        int[] result = new int[resultLength];

        int leftindex = 0, rightIndex = 0, resultIndex = 0;


        while (leftindex < leftLength && rightIndex < rightLength)
        {
            if (left[leftindex] <= right[rightIndex])
            {
                result[resultIndex] = left[leftindex];
                leftindex++;
            }
            else
            {
                result[resultIndex] = right[rightIndex];
                rightIndex++;
            }
            resultIndex++;
        }

        // Copy remaining elements of L[] if any
        while (leftindex < leftLength)
        {
            result[resultIndex] = left[leftindex];
            leftindex++;
            resultIndex++;
        }

        // Copy remaining elements of R[] if any
        while (rightIndex < rightLength)
        {
            result[resultIndex] = right[rightIndex];
            rightIndex++;
            resultIndex++;
        }
        return result;
    }
    #endregion

}

