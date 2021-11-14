using System;

class QuickSortTT
{

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    /* 
      This function takes last element as pivot, places
      the pivot element at its correct position in sorted
      array, and places all smaller (smaller than pivot)
      to left of pivot and all greater elements to right
      of pivot 
    */
    static int Partition(int[] arr, int low, int high)
    {


        int pivot = arr[high];

        //i : index of smaller element 
        //j : index of greater element 
        int i = (low - 1);

        for (int j = low; j <= high - 1; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }
        Swap(arr, i + 1, high);
        return (i + 1);
    }


    public static int[] Sort(int[] arr, int low, int high)
    {
        if (low < high)
        {

            // p is partitioning index, arr[p] is now at right place 
            int p = Partition(arr, low, high);

            // Separately sort elements before partition and after partition
            Sort(arr, low, p - 1);
            Sort(arr, p + 1, high);
        }
        return arr;
    }
}