using System;

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
        }
    }
}