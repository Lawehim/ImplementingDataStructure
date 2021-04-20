using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecagonTask2
{
    public class StackTask
    {
        public class Node
        {
            public int data;
            public Node nextNode;
            public Node(int item)
            {
                this.data = item;
            }
        }

        private Node first = null;

        void push(Node node)
        {
            node.nextNode = first;
            first = node;
        }

        void pop()
        {
            first = first.nextNode;
        }

        void print()
        {
            Node node = first;
            while (node != null)
            {
                Console.Write("|" + node.data + "|");
                node = node.nextNode;
            }
        }

        static void Main(string[] args)
        {
            StackTask N = new StackTask();
            N.push(new Node(19));
            N.push(new Node(28));
            N.push(new Node(40));
            N.push(new Node(54));

            N.print();
        }
    }
}

