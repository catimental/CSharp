
using System;

namespace Report1
{
    public class LinkedStack : IStack
    {
        private StackNode _top;
        
        public bool IsEmpty()
        {
            return _top == null;
        }

        public void Push(char item)
        {
            StackNode newNode = new StackNode()
            {
                Data = item,
                Link = _top
            };
            _top = newNode;
        }

        public char Pop()
        {
            var topData = (char) 0;
            if (this.IsEmpty())
            {
                Console.WriteLine("Deleting fail! Linked Stack is Empty!!");
            }
            else
            {
                topData = _top.Data;
                _top = _top.Link;
            }

            return topData;
        }

        public void Delete()
        {            
            if (this.IsEmpty())
            {
                Console.WriteLine("Deleting fail! Linked Stack is empty!!");
            }
            else
            {
                _top = _top.Link;
            }
        }

        public char Peek()
        {
            if (this.IsEmpty()) {
                Console.WriteLine("Peeking fail! Linked Stack is empty!!");
                return (char)0;
            } else
                return _top.Data;
        }
        
        public void PrintStack() {
            if (this.IsEmpty())
                Console.WriteLine("Linked Stack is empty!! %n %n");
            else {
                StackNode temp = _top;
                Console.WriteLine("Linked Stack>> ");
                while (temp != null) {
                    Console.Write("\t {0} \n", temp.Data);
                    temp = temp.Link;
                }
                Console.WriteLine();
            }
        }
    }
}