using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.LinkedList
{
    public class SimpleLinkedList<T>
    {
        Node<T> head = null;
        Node<T> tail = null;
        public void AddFirst(T item)
        {
            //Get in item and create new node with this item.

            Node<T> newItem = new Node<T>();
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

        public void AddLast(T item)
        {
            //Created new reference
            Node<T> newItem = new Node<T>();
            newItem.item = item;

            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                tail.next = newItem;
                tail = newItem;
            }

        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                tail = null;
                return;
            }

            head = head.next;
        }

        public void RemoveLast()
        {
            if (head == null)
                return;

            Node<T> current = head;
            Node<T> beforeLast = null;

            beforeLast = head;

            while (current.next != null)
            {
                beforeLast = current;
                current = current.next;
            }

            if (beforeLast != null && beforeLast.next == null)
                head = null;
            else
            {
                tail = beforeLast;
                beforeLast.next = null;
            }
        }
        public void ReadAll()
        {
            if (head == null)
                return;

            Node<T> current = head;

            while (current.next != null)
            {
                Console.WriteLine(current.item);
                current = current.next;

            }
            Console.WriteLine(current.item);

        }
    }
}
