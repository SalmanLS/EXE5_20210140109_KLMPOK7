﻿using System;

namespace Exercise
{
    class Node
    {
        public int number;
        public Node next;
    }

    class Queue
    {
        Node salman, luthfi;

        public Queue()
        {
            salman = null;
            luthfi = null;
        }

        public void addNumb()
        {
            int no;
            Console.WriteLine("Enter a number: ");
            no = Convert.ToInt32(Console.ReadLine());
            Node newnode = new Node();
            newnode.number = no;
            if(salman == null || (no <= salman.number))
            {
                if((salman != null) && (no == salman.number))
                {
                    Console.WriteLine("Duplicate number is not allowed");
                    return;
                }
                newnode.next = salman;
                newnode.next = luthfi;
                salman = luthfi = newnode;
                return;
            }
            while ((salman != null)&&(no >= luthfi.number))
            {
                if(no == luthfi.number)
                {
                    Console.WriteLine("Duplicate number is not allowed");
                    return;
                }
                luthfi.next = newnode;
                newnode = luthfi;

            }
        }
        public bool listEmpty()
        {
            if (salman == null)
                return true;
            else
                return false;
        }

        public void delNumb()
        {
            Node curr;
            curr = salman;
            salman = salman.next;
        }

        public void displayNumb()
        {
            if (listEmpty())
            {
                Console.WriteLine("List is empty. ");
            }
            else
            {
                Console.WriteLine("The numbers in the list are: ");
                Node currNode;
                for(currNode = salman; currNode != null; currNode = currNode.next)
                    Console.WriteLine(" - " + currNode.number);
                Console.WriteLine();
            }
        }
    }

}