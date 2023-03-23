using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int value)
        {
            data = value;
            next = null;
        }
    }
    public class Stack
    {
        private Node top;
        public Stack()
        {
            top = null;
        }

        public void Push(int value)
        {
            Node newNode = new Node(value);
            newNode.next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (top == null)
            {
                Console.WriteLine("스택이  비어있습니다.");
                return -1;
            }
            int value = top.data;
            top = top.next;
            return value;
        }

        public int Peek()
        {
            if (top == null)
            {
                Console.WriteLine("스택이 비어있습니다.");
                return -1;
            }
            return top.data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void PrintStack()
        {
            if (top == null)
            {
                Console.WriteLine("스택이 비어있습니다.");
                return;
            }
            Node current = top;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack stack = new Stack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            stack.PrintStack();

            Console.WriteLine(stack.Pop()+"이 제거 되었습니다."); // 30
            Console.WriteLine(stack.Pop()+ "이 제거 되었습니다."); // 20

            stack.Push(40);

            Console.WriteLine(stack.Peek()); // 40

            stack.PrintStack();

            Console.WriteLine(stack.IsEmpty()); // False

        }
    }

}