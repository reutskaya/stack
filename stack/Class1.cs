using System;

namespace ConsoleApplication
{
    public class Stack<T>
    {
        private T[] array;
        private const int defaultCapacity = 30;
        private int size;

        public Stack()
        {
            this.size = 0;
            this.array = new T[defaultCapacity];
        }

        public bool Empty() => this.size == 0;

        public virtual int Count => this.size;

        public T Pop()
        {
            if (this.size == 0)
            {
                Console.WriteLine("Stack is empty");
                throw new Exception();
            }

            var value = this.array[this.size - 1];
            this.array[this.size - 1] = default(T);
            this.size--;
            return value;
        }

        public void Push(T element) =>
                this.array[this.size++] = element;
        
        public T TakeElement()
        {
            if (this.size == 0)
            {
                Console.WriteLine("Stack is empty");
                throw new Exception();
            }

            return this.array[this.size - 1];
        }
    }
}