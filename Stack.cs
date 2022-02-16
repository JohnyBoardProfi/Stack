using System;

namespace Program
{
    class Stack
    {
        char[] stk;
        int tos;
        
        public Stack(int n)
        {
            stk = new char[n];
            tos = 0;
        }
        
        public void Push(char ch)
        {
            if (tos == stk.Length)
            {
                Console.Write("Stac is full!");
            }
            else
            {
                stk[tos] = ch;
                tos++;
            }
        }
        
        public bool isEmpty() => tos == 0;
        
        public char Pop()
        {
            if (isEmpty())
            {
                Console.Write("Stack is empty!");
                return (char)0;
            }
            else
            {
                tos--;
                return stk[tos];
            }
        }
        
        public bool isFull() => tos == stk.Length;
        
        public int Capacity() => stk.Length;
        
        public int GetNum() => tos;
    }
}
