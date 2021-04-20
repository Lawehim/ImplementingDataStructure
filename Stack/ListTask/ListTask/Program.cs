using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DecagonTask2
{
    public class Node
    {
        public int data;
        public Node nextNode;

        public Node(int item)
        {
            data = item;
            nextNode = null;
        }

        public void Print()
        {
            Console.Write(data + "->");
            if (nextNode != null)
            {
                nextNode.Print();
            }
        }

        public void Add(int item)
        {
            if (nextNode == null)
            {
                nextNode = new Node(item);
            }
            else
            {
                nextNode.Add(item);
            }
        }


    }

    public class SinglyLinkedList
    {
        public Node HeadNode;

        public SinglyLinkedList()
        {
            HeadNode = null;
        }

        public void Add(int item)
        {
            if (HeadNode == null)
            {
                HeadNode = new Node(item);
            }
            else
            {
                HeadNode.Add(item);
            }
        }

        public void Print()
        {
            if (HeadNode != null)
            {
                HeadNode.Print();
            }
        }
    }
    public class Programme
    {
        public static void Main(string[] args)
        {
            SinglyLinkedList L = new SinglyLinkedList();
            L.Add(44);
            L.Add(42);
            L.Add(30);
            L.Add(18);
            L.Print();
        }
    }
}