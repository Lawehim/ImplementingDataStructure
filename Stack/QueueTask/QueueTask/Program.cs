using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecagonTask2
{
    public class QueueTask
    {
        class Node
        {
            public int data;
            public Node nextNode;
            public Node(int item)
            {
                this.data = item;
            }
        }

        private Node first = null;
        private Node last = null;

        void enqueue(Node node)
        {
            if (last == null)
            {
                first = last = node;
            }
            else
            {
                last.nextNode = node;
                last = node;
            }
        }

        void dequeue()
        {
            first = first.nextNode;
            if (first == null)
            {
                last = null;
            }
        }

            public void print()
            {
                Node node = first;
                while (node != null)
                {
                    Console.Write(node.data + " ");
                    node = node.nextNode;
                }
            }

            static void Main(string[] args)
            {
                QueueTask d = new QueueTask();
                d.enqueue(new Node(1));
                d.enqueue(new Node(2));
                d.enqueue(new Node(4));
                d.enqueue(new Node(8));

                d.print();
            }
        }
    }

