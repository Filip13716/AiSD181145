using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy_dwukierunkowe
{
    internal class Lista
    {
        Node head, tail;
       
        public void Add(int value)
        {
            if(tail != null) AddAfter(tail, value);
            else
            {
                head = new Node(value);
                tail = head;
            }
        }
        public void AddAfter(Node node, int value)
        {
            Node ptr = new Node(value, node);

            ptr.next = node.next;

            if (node.next != null) node.next.prev = ptr;

            node.next = ptr;

            if(node == tail) tail = ptr;
        }
        public void AddPrev(Node node, int value)
        {
            Node ptr = new Node(value);

            ptr.prev = node.prev;
            if(ptr.prev != null) node.prev.next = ptr;

            node.prev = ptr;
            ptr.next = node;

            if(node == head) head = ptr;
        }

        public void Delete(Node node)
        {
            if (node.prev != null) node.prev.next = node.next;
            if (node.next != null) node.next.prev = node.prev;

            if(node == head) head = node.next;
            if(node == tail) tail = node.prev;

            node.prev = null;
            node.next = null;
        }

        public List<int> ToList()
        {
            List<int> list = new List<int>();

            Node ptr = head;

            while (ptr != null)
            {
                list.Add(ptr.value);
                ptr = ptr.next;
            }

            return list;
        }

        public List<Node> GetNodes()
        {
            List<Node> list = new List<Node>();

            Node ptr = head;

            while (ptr != null)
            {
                list.Add(ptr);
                ptr = ptr.next;
            }

            return list;
        }
    }
}
