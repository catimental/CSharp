using System;

namespace A096_LinkedList
{

    class Node
    {
        internal int data;
        internal Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
    

    class LinkedList 
    {
        private Node head;

        internal void InsertFront(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
        }

        internal void InsertLast(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = node;
            }
        }

        internal Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null) temp = temp.next;
            return temp;
        }

        internal void InsertAfter(int prev, int data)
        {
            Node prevNode = null;

            for(Node temp = head; temp != null; temp = temp.next)
                if (temp.data == prev)
                    prevNode = temp;

            if (prevNode == null)
            {
                Console.WriteLine("{0} data is not in the list");
                return;
            }
            Node node = new Node(data);
            node.next = prevNode.next;
            prevNode.next = node;

        }

        internal void DeleteNode(int key)
        {
            Node temp = head;
            Node prev = null;
            if (temp != null && temp.data == key)
            {
                head = temp.next;
                return;
            }

            while (temp.next != null)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
            {
                return;
            }

            prev.next = temp.next;
        }

        internal void Reverse()
        {
            Node prev = null;
            Node current = head;
            Node temp = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev; // 지금노드의 다음노드를 이전노드를 가르킴
                prev = current; //current Node가 prev가됨
                current = temp; //현재를 한칸 앞으로 밀음
            }

            head = prev;
            
        }
        internal void Print()
        {
            for (Node node = head; node != null; node = node.next)
                Console.Write(node.data + " -> ");
            Console.WriteLine();
        }

    }
        
    
    
}