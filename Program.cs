using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //스택 사이즈 입력받기
            Console.Write("스택 사이즈를 입력하세요 : ");
            int size = int.Parse(Console.ReadLine());
            stack stack = new stack(size);
            //1번을 입력하면 데이터 입력 2번을 데이터 삭제 3번을 입력하면 데이터 출력 4번을 입력하면 종료
            while (true)
            {
                Console.WriteLine("1. 데이터 입력 2. 데이터 삭제 3. 데이터 출력 4. 종료");
                Console.Write("메뉴를 선택하세요 : ");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        if (stack.isFull())
                        {
                            Console.WriteLine("스택이 가득 찼습니다.");
                        }
                        else
                        {
                            Console.Write("데이터를 입력하세요 : ");
                            int data = int.Parse(Console.ReadLine());
                            stack.push(data);
                        }
                        break;
                    case 2:
                        if (stack.isEmpty())
                        {
                            Console.WriteLine("스택이 비어있습니다.");
                        }
                        else
                        {
                            //삭제될 데이터를 출력
                            Console.WriteLine(stack.peek() + "가 삭제되었습니다.");
                            stack.pop();
                        }
                        break;
                    case 3:
                        if (stack.isEmpty())
                        {
                            Console.WriteLine("스택이 비어있습니다.");
                        }
                        else
                        {
                            stack.print();
                        }
                        break;
                    case 4:
                        Console.WriteLine("프로그램을 종료합니다.");
                        return;
                }
            }
        }
    }
    //스택 클래스
    class stack
    {
        private int[] stackArray;
        private int top;

        public stack(int size)
        {
            stackArray = new int[size];
            top = -1;
        }

        public void push(int item)
        {
            //만약 스택이 가득 차있으면
            if (isFull())
            {
                Console.WriteLine("스택이 가득 찼습니다.");
            }
            else
            {
                stackArray[++top] = item;
            }
        }

        public int peek()
        {
            return stackArray[top];
        }

        public int pop()
        {
            //만약 스택이 비어있으면
            if (isEmpty())
            {
                Console.WriteLine("스택이 비어있습니다.");
                return -1;
            }
            else
            {
                stackArray[top] = 0;
                return stackArray[top--];
            }
        }



        public bool isEmpty()
        {
            return (top == -1);
        }

        public bool isFull()
        {
            return (top == stackArray.Length - 1);
        }
        public void print()
        {
            //스택이 비어있으면
            if (isEmpty())
            {
                Console.WriteLine("스택이 비어있습니다.");
            }
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stackArray[i]);
                }
            }
        }
    }
}