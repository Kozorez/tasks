/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package queue;

import java.util.Scanner;

/**
 *
 * @author Виктор
 */

public class Queue {

    /**
     * @param args the command line arguments
     */
    
    Scanner sc = new Scanner(System.in);
    
    double[][] Enqueue(double[][] queue, double new_number)
    {
        double[][] new_queue = new double[queue.length + 1][2];
        if (queue.length != 0)
        {
            System.arraycopy(queue, 0, new_queue, 0, queue.length);
            new_queue[queue.length] = new double[2];
            new_queue[queue.length][0] = new_number;
            new_queue[queue.length - 1][1] = new_number;
        }
        else
        {
            System.arraycopy(queue, 0, new_queue, 0, queue.length);
            new_queue[queue.length] = new double[2];
            new_queue[queue.length][0] = new_number;
        }
        return new_queue;
    }
    
    double[][] Dequeue(double[][] queue) 
    {
        double[][] new_queue = new double[queue.length - 1][2];
        for (int i = 0; i < new_queue.length; i++)
        {
            new_queue[i] = queue[i + 1];
        }
        return new_queue;
    }
    
    void Print_The_Queue(double[][] queue)
    {
        for (int i = 0; i < queue.length; i++)
        {
            System.out.println("Number of a record in the queue: " + i);
            System.out.println("Number: " + queue[i][0]);
        }
    }
    
    public static void main(String[] args) {
        // TODO code application logic here
        
        Queue obj = new Queue();
        
        Scanner scan = new Scanner(System.in);
        
        //double[] queue_box_1 = {0, 0};
        
        double[][] queue = {
            //queue_box_1,
        };
        
        double[][] new_queue = new double[queue.length][2];
        
        new_queue = obj.Enqueue(new_queue, 2.2);
        new_queue = obj.Enqueue(new_queue, 1.2);
        new_queue = obj.Enqueue(new_queue, 2.0);
        new_queue = obj.Enqueue(new_queue, 5.2);
        
        System.out.println("Queue after adding four numbers:");
        System.out.println();
        
        obj.Print_The_Queue(new_queue);
        
        new_queue = obj.Dequeue(new_queue);
        new_queue = obj.Dequeue(new_queue);
        
        new_queue = obj.Enqueue(new_queue, 2.9);
        
        System.out.println();
        System.out.println("Queue after deleting two numbers and adding one more number:");
        System.out.println();
        
        obj.Print_The_Queue(new_queue);
        
        double sum = 0;
        
        for (int i = 0; i < new_queue.length; i++)
        {
            sum += new_queue[i][0];
        }
        
        System.out.println();
        System.out.println("Sum of all of the numbers in the final queue condition: " + sum);
        System.out.println();
    }
}
