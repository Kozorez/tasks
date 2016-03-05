/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package doubly_linked_list;

import java.util.Scanner;

/**
 *
 * @author Виктор
 */

public class Doubly_Linked_List {

    /**
     * @param args the command line arguments
     */
    
    String Surname;
    
    public Doubly_Linked_List(String _Surname)
    {   
        Surname = _Surname.toUpperCase();
    }
    
    public Doubly_Linked_List(){}
    
    Scanner sc = new Scanner(System.in);
    
    Doubly_Linked_List[][] Add_To_The_End(Doubly_Linked_List[][] linked_list, Doubly_Linked_List new_element)
    {
        Doubly_Linked_List[][] new_linked_list = new Doubly_Linked_List[linked_list.length + 1][3];
        System.arraycopy(linked_list, 0, new_linked_list, 0, linked_list.length);
        new_linked_list[linked_list.length] = new Doubly_Linked_List[3];
        new_linked_list[linked_list.length - 2][2] = new_element;
        new_linked_list[linked_list.length - 1][1] = new_element;
        new_linked_list[linked_list.length][0] = new_element;
        return new_linked_list;
    }
    
    Doubly_Linked_List[][] Add_To_The_Index(Doubly_Linked_List[][] linked_list, Doubly_Linked_List new_element, int index) 
    {
        Doubly_Linked_List[][] new_linked_list = new Doubly_Linked_List[linked_list.length + 1][3];
        System.arraycopy(linked_list, 0, new_linked_list, 0, linked_list.length);
        new_linked_list[linked_list.length] = new Doubly_Linked_List[3];
        if (index != 0)
        {
            for (int i = linked_list.length; i > index + 1; i--)
            {
                Doubly_Linked_List temp = new_linked_list[i - 2][1];
                new_linked_list[i][0] = temp;
                new_linked_list[i - 1][1] = temp;
                new_linked_list[i - 2][2] = temp;
                new_linked_list[i - 1][0] = null;
                new_linked_list[i - 2][1] = null;
                new_linked_list[i - 3][2] = null;
            }
            new_linked_list[index + 1][0] = new_element;
            new_linked_list[index][1] = new_element;
            new_linked_list[index - 1][2] = new_element;
        }
        else
        {
            for (int i = linked_list.length; i > index + 2; i--)
            {
                Doubly_Linked_List temp = new_linked_list[i - 2][1];
                new_linked_list[i][0] = temp;
                new_linked_list[i - 1][1] = temp;
                new_linked_list[i - 2][2] = temp;
                new_linked_list[i - 1][0] = null;
                new_linked_list[i - 2][1] = null;
                new_linked_list[i - 3][2] = null;
            }
            new_linked_list[index + 2][0] = linked_list[index][0];
            new_linked_list[index + 1][1] = linked_list[index][0];
            new_linked_list[index][2] = linked_list[index][0];
            new_linked_list[index + 1][0] = new_element;
            new_linked_list[index][1] = new_element;
        }
        return new_linked_list;
    }
    
    Doubly_Linked_List[][] Delete_To_The_Index(Doubly_Linked_List[][] linked_list, int index) 
    {
        Doubly_Linked_List[][] new_linked_list = new Doubly_Linked_List[linked_list.length - 1][3];
        if (index != 0)
        {
            System.arraycopy(linked_list, 0, new_linked_list, 0, new_linked_list.length);
            for (int i = index; i < new_linked_list.length - 1; i++)
            {
                Doubly_Linked_List temp = new_linked_list[i + 1][1];
                new_linked_list[i + 1][0] = temp;
                new_linked_list[i][1] = temp;
                new_linked_list[i - 1][2] = temp;
            }
            new_linked_list[new_linked_list.length - 1][1] = null;
            new_linked_list[new_linked_list.length - 2][2] = null;
        }
        else
        {
            for (int i = 0; i < new_linked_list.length; i++)
            {
                new_linked_list[i] = linked_list[i + 1];
            }
            new_linked_list[index][0] = null;
        }
        return new_linked_list;
    }
    
    void Find_By_The_Field(Doubly_Linked_List[][] linked_list)
    {
        System.out.println("Enter the value of a \"Surname\" field: ");
        String choice_value = sc.nextLine();
        boolean flag = false;
        for (int i = 0; i < linked_list.length - 1; i++)
        {
            if (choice_value.toUpperCase().compareTo(linked_list[i][1].Surname) == 0)
            {
                System.out.println("The entered string corresponds to the field \"Surname\", which value is " + choice_value + " of an object with a number " + (i + 1));
                flag = true;
            }
        }
        if (!flag)
        {
            System.out.println("Needed data wasn't found!");
        }
    }
    
    void Print_The_List(Doubly_Linked_List[][] linked_list)
    {
        for (int i = 0; i < linked_list.length - 1; i++)
        {
            System.out.println("Number of a record in the list: " + i);
            System.out.println("Surname: " + linked_list[i][1].Surname);
        }
    }
    
    public static void main(String[] args) {
        // TODO code application logic here
        
        Doubly_Linked_List obj = new Doubly_Linked_List();
        
        Scanner scan = new Scanner(System.in);
        
        Doubly_Linked_List student_1 = new Doubly_Linked_List("Smith");
        Doubly_Linked_List student_2 = new Doubly_Linked_List("Johnson");
        Doubly_Linked_List student_3 = new Doubly_Linked_List("Williams");
        Doubly_Linked_List student_4 = new Doubly_Linked_List("Jones");
        Doubly_Linked_List student_5 = new Doubly_Linked_List("Brown");
        Doubly_Linked_List student_6 = new Doubly_Linked_List("Davis");
        Doubly_Linked_List student_7 = new Doubly_Linked_List("Miller");
        Doubly_Linked_List student_8 = new Doubly_Linked_List("Wilson");
        Doubly_Linked_List student_9 = new Doubly_Linked_List("Moore");
        Doubly_Linked_List student_10 = new Doubly_Linked_List("Taylor");
        Doubly_Linked_List student_11 = new Doubly_Linked_List("Anderson");
        Doubly_Linked_List student_12 = new Doubly_Linked_List("Thomas");
        Doubly_Linked_List student_13 = new Doubly_Linked_List("Jackson");
        Doubly_Linked_List student_14 = new Doubly_Linked_List("White");
        Doubly_Linked_List student_15 = new Doubly_Linked_List("Harris");
        Doubly_Linked_List student_16 = new Doubly_Linked_List("Martin");
        Doubly_Linked_List student_17 = new Doubly_Linked_List("Thompson");
        Doubly_Linked_List student_18 = new Doubly_Linked_List("Garcia");
        Doubly_Linked_List student_19 = new Doubly_Linked_List("Martinez");
        Doubly_Linked_List student_20 = new Doubly_Linked_List("Robinson");
        Doubly_Linked_List student_21 = new Doubly_Linked_List("Clark");
        Doubly_Linked_List student_22 = new Doubly_Linked_List("Rodriguez");
        Doubly_Linked_List student_23 = new Doubly_Linked_List("Lewis");
        Doubly_Linked_List student_24 = new Doubly_Linked_List("Lee");
        Doubly_Linked_List student_25 = new Doubly_Linked_List("Walker");
        Doubly_Linked_List student_26 = new Doubly_Linked_List("Hall");
        Doubly_Linked_List student_27 = new Doubly_Linked_List("Allen");
        Doubly_Linked_List student_28 = new Doubly_Linked_List("Young");
        Doubly_Linked_List student_29 = new Doubly_Linked_List("Hernandez");
        Doubly_Linked_List student_30 = new Doubly_Linked_List("King");
        
        Doubly_Linked_List[] first_group_linked_box_1 = {null, student_1, student_2};
        Doubly_Linked_List[] first_group_linked_box_2 = {student_1, student_2, student_3};
        Doubly_Linked_List[] first_group_linked_box_3 = {student_2, student_3, student_4};
        Doubly_Linked_List[] first_group_linked_box_4 = {student_3, student_4, student_5};
        Doubly_Linked_List[] first_group_linked_box_5 = {student_4, student_5, student_6};
        Doubly_Linked_List[] first_group_linked_box_6 = {student_5, student_6, student_7};
        Doubly_Linked_List[] first_group_linked_box_7 = {student_6, student_7, student_8};
        Doubly_Linked_List[] first_group_linked_box_8 = {student_7, student_8, student_9};
        Doubly_Linked_List[] first_group_linked_box_9 = {student_8, student_9, student_10};
        Doubly_Linked_List[] first_group_linked_box_10 = {student_9, student_10, student_11};
        Doubly_Linked_List[] first_group_linked_box_11 = {student_10, student_11, student_12};
        Doubly_Linked_List[] first_group_linked_box_12 = {student_11, student_12, student_13};
        Doubly_Linked_List[] first_group_linked_box_13 = {student_12, student_13, student_14};
        Doubly_Linked_List[] first_group_linked_box_14 = {student_13, student_14, student_15};
        Doubly_Linked_List[] first_group_linked_box_15 = {student_14, student_15, student_16};
        Doubly_Linked_List[] first_group_linked_box_16 = {student_15, student_16, student_17};
        Doubly_Linked_List[] first_group_linked_box_17 = {student_16, student_17, student_18};
        Doubly_Linked_List[] first_group_linked_box_18 = {student_17, student_18, student_19};
        Doubly_Linked_List[] first_group_linked_box_19 = {student_18, student_19, student_20};
        Doubly_Linked_List[] first_group_linked_box_20 = {student_19, student_20, student_21};
        Doubly_Linked_List[] first_group_linked_box_21 = {student_20, student_21, student_22};
        Doubly_Linked_List[] first_group_linked_box_22 = {student_21, student_22, student_23};
        Doubly_Linked_List[] first_group_linked_box_23 = {student_22, student_23, student_24};
        Doubly_Linked_List[] first_group_linked_box_24 = {student_23, student_24, student_25};
        Doubly_Linked_List[] first_group_linked_box_25 = {student_24, student_25, student_26};
        Doubly_Linked_List[] first_group_linked_box_26 = {student_25, student_26, student_27};
        Doubly_Linked_List[] first_group_linked_box_27 = {student_26, student_27, student_28};
        Doubly_Linked_List[] first_group_linked_box_28 = {student_27, student_28, student_29};
        Doubly_Linked_List[] first_group_linked_box_29 = {student_28, student_29, student_30};
        Doubly_Linked_List[] first_group_linked_box_30 = {student_29, student_30, null};
        Doubly_Linked_List[] first_group_linked_box_31 = {student_30, null, null};
        
        Doubly_Linked_List[][] doubly_linked_list = {
            first_group_linked_box_1,
            first_group_linked_box_2, 
            first_group_linked_box_3, 
            first_group_linked_box_4, 
            first_group_linked_box_5, 
            first_group_linked_box_6, 
            first_group_linked_box_7, 
            first_group_linked_box_8, 
            first_group_linked_box_9, 
            first_group_linked_box_10, 
            first_group_linked_box_11, 
            first_group_linked_box_12, 
            first_group_linked_box_13, 
            first_group_linked_box_14, 
            first_group_linked_box_15, 
            first_group_linked_box_16,
            first_group_linked_box_17,
            first_group_linked_box_18,
            first_group_linked_box_19,
            first_group_linked_box_20,
            first_group_linked_box_21,
            first_group_linked_box_22,
            first_group_linked_box_23,
            first_group_linked_box_24,
            first_group_linked_box_25,
            first_group_linked_box_26,
            first_group_linked_box_27,
            first_group_linked_box_28,
            first_group_linked_box_29,
            first_group_linked_box_30,
            first_group_linked_box_31,   
        };     
        
//        Doubly_Linked_List student_1 = new Doubly_Linked_List("Smith");
//        Doubly_Linked_List student_2 = new Doubly_Linked_List("Johnson");
//        Doubly_Linked_List student_3 = new Doubly_Linked_List("Williams");
//        Doubly_Linked_List student_4 = new Doubly_Linked_List("Jones");
//        Doubly_Linked_List student_5 = new Doubly_Linked_List("Brown");
//        Doubly_Linked_List student_6 = new Doubly_Linked_List("Davis");
//        Doubly_Linked_List student_7 = new Doubly_Linked_List("Miller");
//        Doubly_Linked_List student_8 = new Doubly_Linked_List("Wilson");
//        Doubly_Linked_List student_9 = new Doubly_Linked_List("Moore");
//        Doubly_Linked_List student_10 = new Doubly_Linked_List("Taylor");
//        
//        
//        Doubly_Linked_List[] first_group_linked_box_1 = {null, student_1, student_2};
//        Doubly_Linked_List[] first_group_linked_box_2 = {student_1, student_2, student_3};
//        Doubly_Linked_List[] first_group_linked_box_3 = {student_2, student_3, student_4};
//        Doubly_Linked_List[] first_group_linked_box_4 = {student_3, student_4, student_5};
//        Doubly_Linked_List[] first_group_linked_box_5 = {student_4, student_5, student_6};
//        Doubly_Linked_List[] first_group_linked_box_6 = {student_5, student_6, student_7};
//        Doubly_Linked_List[] first_group_linked_box_7 = {student_6, student_7, student_8};
//        Doubly_Linked_List[] first_group_linked_box_8 = {student_7, student_8, student_9};
//        Doubly_Linked_List[] first_group_linked_box_9 = {student_8, student_9, student_10};
//        Doubly_Linked_List[] first_group_linked_box_10 = {student_9, student_10, null};
//        Doubly_Linked_List[] first_group_linked_box_11 = {student_10, null, null};
//        
//        Doubly_Linked_List[][] doubly_linked_list = {
//            first_group_linked_box_1,
//            first_group_linked_box_2, 
//            first_group_linked_box_3, 
//            first_group_linked_box_4, 
//            first_group_linked_box_5, 
//            first_group_linked_box_6, 
//            first_group_linked_box_7,
//            first_group_linked_box_8,
//            first_group_linked_box_9,
//            first_group_linked_box_10,
//            first_group_linked_box_11,
//        };
        
        Doubly_Linked_List student_new = new Doubly_Linked_List("Robert");
        
        System.out.println("A pointer on the first record indicates on the student with a surname: " + doubly_linked_list[0][1].Surname);
        System.out.println();
        
        for (int i = 0; i < doubly_linked_list.length / 2; i += 1)
        {
            Doubly_Linked_List temp = doubly_linked_list[i][1];
            doubly_linked_list = obj.Delete_To_The_Index(doubly_linked_list, i);
            doubly_linked_list = obj.Add_To_The_End(doubly_linked_list, temp);
        }
        obj.Print_The_List(doubly_linked_list);
        
        System.out.println();
        System.out.println("A pointer on the first record indicates now on the student with a surname: " + doubly_linked_list[0][1].Surname);
    }
    
}
