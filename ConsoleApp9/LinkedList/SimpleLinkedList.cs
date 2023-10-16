using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.LinkedList
{
    public class SimpleLinkedList
    {
        Node head = null;
        Node tail = null;
        public void AddFirst(object item)
        {
            //Get in item and create new node with this item.

            Node newItem = new Node();
            newItem.item = item;

            //if there is no item 
            if (head == null)
            {
                
                //We have head and tail items

                //We must save this new node to head 

                head = newItem;
                
                //and to tail
                //becouse at first if there is no item
                //first item is first and last.

                tail = newItem;

                //so head and tail has one reference

            }
            else
            {
                newItem.next = head;
                
                head = newItem;
            }
        }

        public void AddLast(object item)
        {
            //Created new reference
            Node newItem = new Node();
            newItem.item = item;

            if (head == null)
            {
                //if there is not added item
                //we save this reference in head pointer and
                //into tail pointer

                head = newItem;
                tail = newItem;
            
            }
            else
            {
                // So if tail and head has same reference saved
                // in this case if tail.next will be newItem also
                // in head will have this new item because of same reference.
                tail.next = newItem;
                tail = newItem;
            }

        }

        public void ReadAll()
        {

            Node current = head;

            while (current.next != null)
            {
                Console.WriteLine(current.item);
                current = current.next;

            }
            Console.WriteLine(current.item);

        }
    }
}
