/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package digit_radix_sort;

import java.util.LinkedList;
import java.util.Queue;

/**
 *
 * @author Виктор
 */

public class Digit_Radix_Sort 
{
    public static void RadixSort(int[] array)
    {
        Queue<Integer>[] buckets = new Queue[10];
        
        for (int i = 0; i < 10; i++)
        {
            buckets[i] = new LinkedList<Integer>();
        }
        
        boolean sorted = false;
        int expo = 1;

        while (!sorted) 
        {
            sorted = true;
            
            for (int item : array)
            {
                int bucket = (item / expo) % 10;
                if (bucket > 0) sorted = false;
                buckets[bucket].add(item);
            }
            
            expo *= 10;
            int index = 0;
        
            for (Queue<Integer> bucket : buckets)
            {
                while (!bucket.isEmpty())
                {
                    array[index++] = bucket.remove();
                }
            }
        }
        assert IsSorted(array);
    }
    
    private static boolean IsSorted(int[] array)
    {
        for (int i = 1; i < array.length; i++)
        {
            if (array[i - 1] > array[i])
            {
                return false;
            }
        }
        
        return true;
    }
    
    private static void ShowArray(int[] array)
    {
        for (int i = 0; i < array.length; i++)
        {
            System.out.println(array[i]);
        }
    }
    
    public static void main(String[] args) 
    {
        int[] a = new int[]{44, 55, 98, 42, 11, 10, 57, 99, 49, 21, 73};
        RadixSort(a);
        ShowArray(a);
    }
}
