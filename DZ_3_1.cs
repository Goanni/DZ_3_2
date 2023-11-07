using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3_2
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }

    public class Queue<T>
    {
        private Node<T> head ;
        private Node<T> tail ;
        private int count;


        public Queue()
        {
            count = 0;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public int Size()
        {
            return count;
        }

        public void Push(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = tail;
            tail = node;
            if (count == 0)
                head = tail;
            else
                tempNode.Next = tail;
            count++;
            Console.WriteLine("OK");
        }

        public T Pop ()
        {
            if (count == 0)
                Console.WriteLine("ERROR");
            Node<T> output = head;
            head = head.Next;
            count--;
            return output.Data;
        }

        public T Front()
        {
            if (IsEmpty())
                Console.WriteLine("ERROR");
            return head.Data;
        }

        public void Clear()
        {
            while (!IsEmpty()) Pop();
        }

        public void Exit()
        {
            Clear();
            Console.WriteLine("BYE!");
        }
    }
    internal class DZ_3_1
    {
        static void Main()
        {
            Queue<int> queue = new Queue<int>();
            queue.Push(1);
            queue.Push(2);
            queue.Clear();
            Console.WriteLine("OK");
            int a = queue.Front();
            Console.WriteLine(a);

            queue.Exit();



        }
    }
}
