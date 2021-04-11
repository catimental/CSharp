using System;

namespace Report1
{
    public interface IStack
    {
        bool IsEmpty();
        void Push(char item);
        char Pop();
        void Delete();
        char Peek();
    }
}