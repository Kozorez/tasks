/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package search_sort;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Виктор
 */
public class Search_Sort 
{

    /**
     * @param args the command line arguments
     */
    
    //
    //Search
    //
    
    //Лінійний пошук
    public static boolean Linear_Search(double[] a, double key) 
    {
        for (int i = 0; i < a.length; i++)
        {
            if (a[i] == key)
            {
                return true;
            }
        }
        return false;
    }
    
    //Лінійний пошук з бар’єром
    public static boolean LinearBarrier_Search(double[] a, double key) 
    {
        double[] array = new double[a.length + 1];
        for (int i = 0; i < a.length; i++)
        {
            array[i] = a[i];
        }
        array[array.length - 1] = key;
        int j = 0;
        while (array[j] != key)
        {
            j++;
        }
        if (j != array.length - 1)
        {
            return true;
        }
        return false;
    }
    
    //Бінарний пошук
    public static boolean Binary_Search(double[] a, double key)
    {
        int n = a.length;
	for (int i = 1; i <= n; i++) 
        {
            int k = i;
            for (int j = i + 1; j <= n; j++) 
            {
                if (a[j-1] < a[k-1]) 
                {
                    k = j;
                }
            }
            double t = a[i-1];
            a[i-1] = a[k-1];
            a[k-1] = t;
	}
        
        int i = 0;
        int j = a.length - 1;
        int m = j / 2;
        while (a[m] != key && i < j)
        {
            if (key > a[m])
            {
                i = m + 1;
            }
            else
            {
                j = m - 1;
            }
            m = (int)((i + j) / 2);
            if (a[m] == key)
            {
                return true;
            }
        }
        return false;
    }
    
    //Пошук з перестановкою в початок
    public static boolean PermuteToStart_Search(double[] a, double key)
    {
        int index = 0;
        for (int i = index; i < a.length; i++)
        {
            if (a[i] == key)
            {
                return true;
            }
            else
            {
                index++;
            }
        }
        return false;
    }
    
    //Пошук с транспозицією
    public static boolean Transpose_Search(double[] a, double key)
    {
        for (int i = 0; i < a.length; i++)
        {
            if (a[i] == key && i != 0)
            {
                double t = a[i-1];
                a[i] = a[i-1];
                a[i-1] = t;
                return true;
            }
            else if (a[i] == key && i == 0)
            {
                return true;
            }
        }
        return false;
    }
    
    //
    // SORT
    // 
    
    //Сортування вибором 
    public static void Selection_Sort(double[] a) 
    {
	int n = a.length;
	for (int i = 1; i <= n; i++) 
        {
            int k = i;
            for (int j = i + 1; j <= n; j++) 
            {
                if (a[j-1] < a[k-1]) 
                {
                    k = j;
                }
            }
            double t = a[i-1];
            a[i-1] = a[k-1];
            a[k-1] = t;
	}
    }
    
    //Бульбашкове сортування (сортування обміном) 
    public static void Bubble_Sort(double[] a)
    {
	int n = a.length;
	for (int i = 1; i <= n; i++)
        {
            boolean swapped = false;
            for (int j = n; j >= i+1; j--)
            {
                if (a[j-1] < a[j-2]) 
                { 
                    double t = a[j-1];
                    a[j-1] = a[j-2];
                    a[j-2] = t;
                    swapped = true;
                }
            }
            if (!swapped)
            {
                break;
            }
	}
    }
    
    //Сортування вставкою (включенням)
    public static void Insertion_Sort(double[] a) 
    {
        for(int i = 1; i < a.length; i++)
        {
            double currentElement = a[i];
            int previousKey = i - 1;
            while (previousKey >= 0 && a[previousKey] > currentElement)
            {
                a[previousKey + 1] = a[previousKey];
                a[previousKey] = currentElement;
                previousKey--;
            }
        }
    }
    
    //Бульбашкове сортування вставками 
    public static void BubbleWithInsertions_Sort(double[] a)
    {
        int n = a.length;
        int nonChecked = a.length;
        for (int i = 0; i < n - 1; i++)
        {
            int max = 0;
            for (int j = 1; j < nonChecked - 1; j++)
            {
                if (a[j] > a[max])
                {
                    max = j;
                }
            }
            double t = a[max];
            a[max] = a[nonChecked - 1];
            a[nonChecked - 1] = t;
            nonChecked--;
        }
    }
    
    //Швидке сортування (сортування Хоара)
    public static void Quick_Sort(double[] a) 
    {
	if (a.length < 2)
        {
            return;
        }
	class SortRange 
        {
            public void sortRange(double a[], int start, int end)
            {
                int i = start;
                int k = end;
                if (end - start >= 1) 
                {
                    double pivot = a[start];
                    while (k > i) 
                    {
                        while (a[i] <= pivot && i <= end && k > i)
                        {
                            i++;
                        }
                        while (a[k] > pivot && k >= start && k >= i)
                        {
                            k--;
                        }
                        if (k > i) 
                        {
                            double t = a[i];
                            a[i] = a[k];
                            a[k] = t;
                        }
                    }
                    double t = a[start];
                    a[start] = a[k];
                    a[k] = t;
                    sortRange(a, start, k - 1);
                    sortRange(a, k + 1, end);
                }
                else
                {
                    return;
		}
            }
        }
	new SortRange().sortRange(a, 0, a.length - 1);
    }
    
    //Сортування Шелла
    public static void Shell_Sort(double[] a)
    {
	int n = a.length;
	if (n < 2) 
        {
            return;
        }
	int h = 1;
	while (h < n)
        {
            h = 3 * h + 1;
        }
	while (h > 0) 
        {
            h = h / 3;
            for (int k = 1; k <= h; k++)
            {
                class InsertionSort 
                {
                    public void insertionSort(double[] a, int offset, int h, int n) 
                    {
                        for (int i = 2; i <= n; i++)
                        {
                            for (int k = i; k > 1 && a[offset+k*h-1] < a[offset+(k-1)*h-1]; k--) 
                            {
                                double t = a[offset+(k-1)*h-1];
                                a[offset+(k-1)*h-1] = a[offset+k*h-1];
                                a[offset+k*h-1] = t;
                            }
                        }
                    }
                }
                new InsertionSort().insertionSort(a, k-h, h, 1+(n-k)/h);
            }
	}
    }
    
    public static void main(String[] args) {
        // TODO code application logic here
        
        double[] A = new double[]{25,15,1,0,25,4,1,10};
        double[] B = new double[]{4,28,25,5,12,9,35,28};
        
        double[] result = new double[A.length + B.length];
        
        for (int i = 0; i < A.length; i++)
        {
            result[i] = A[i];
        }
        for (int j = 0; j < B.length; j++)
        {
            result[j + A.length] = B[j];
        }
        
        List numbers = new ArrayList();
        
        for(int i = 0; i < result.length; i++)
        {
            for(int j = 0; j < result.length; j++)
            {
                if ((result[i] == result[j]) && (i != j) && !numbers.contains(result[i]))
                {
                    numbers.add(result[i]);
                    System.out.println(result[i]);
                }
            }
        }  
    }
}
    
    

//Пірамідальне сортування 
class Heap 
{
    private int heapSize;
 
    public void Heap_Sort(double[] a) 
    {
        buildHeap(a);
        while (heapSize > 1) 
        {
            swap(a, 0, heapSize - 1);
            heapSize--;
            heapify(a, 0);
        }
    }
 
    private void buildHeap(double[] a) 
    {
        heapSize = a.length;
        for (int i = a.length / 2; i >= 0; i--)
        {
            heapify(a, i);
        }
    }
 
    private void heapify(double[] a, int i) 
    {
        int l = left(i);
        int r = right(i);
        int largest = i;
        if (l < heapSize && a[i] < a[l])
        {
            largest = l;
        } 
        if (r < heapSize && a[largest] < a[r])
        {
            largest = r;
        }
        if (i != largest) 
        {
            swap(a, i, largest);
            heapify(a, largest);
        }
    }
    
    private int right(int i) 
    {
        return 2 * i + 1;
    }
    
    private int left(int i) 
    {
        return 2 * i + 2;
    }
    
    private void swap(double[] a, int i, int j)
    {
        double temp = a[i];
        a[i] = a[j];
        a[j] = temp;
    }
}



//Сортування злиттям
class Merge_Sort 
{
    private double[] numbers;
    private double[] helper;
    private int number;
    
    public void Merge_Sort(double[] a) 
    {
        this.numbers = a;
        this.number = a.length;
        this.helper = new double[number];
        mergesort(0, number - 1);
    }

    private void mergesort(int low, int high) 
    {
        if (low < high) 
        {
            int middle = low + (high - low) / 2;
            mergesort(low, middle);
            mergesort(middle + 1, high);
            merge(low, middle, high);
        }
    }
    
    private void merge(int low, int middle, int high) 
    {
        for (int i = low; i <= high; i++)
        {
            helper[i] = numbers[i];
        }
        int i = low;
        int j = middle + 1;
        int k = low;
        while (i <= middle && j <= high) 
        {
            if (helper[i] <= helper[j])
            {
                numbers[k] = helper[i];
                i++;
            }
            else 
            {
                numbers[k] = helper[j];
                j++;
            }
            k++;
        }
        while (i <= middle) 
        {   
            numbers[k] = helper[i];
            k++;
            i++;
        }
    }
} 

