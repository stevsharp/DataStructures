
namespace DataStructures.Stack
{
    public class StacksArray
    {
        protected int[] data;
        protected int top;

        public StacksArray(int n)
        {
            data = new int[n];
            top = 0;
        }

        public int Length() => top;

        public bool IsEmpty() => top == 0;

        public bool IsFull() => top == data.Length;

        public void Push(int e)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack if Full/Overflow");
                return;
            }
            else
            {
                data[top] = e;
                top++;
            }
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty/UnderFlow");
                return -1;
            }
            int e = data[top - 1];
            top--;
            return e;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            return data[top - 1];
        }

        public void Display()
        {
            for (int i = 0; i < top; i++)
                Console.Write(data[i] + "--");
            Console.WriteLine();
        }

        public void Test()
        {
            StacksArray s = new(10);
            
            s.Push(5);
            s.Push(3);
            s.Display();

            Console.WriteLine("Size: " + s.Length());
            Console.WriteLine("Element Popped: " + s.Pop());
            Console.WriteLine("IsEmpty: " + s.IsEmpty());
            Console.WriteLine("Element Popped: " + s.Pop());
            Console.WriteLine("IsEmpty: " + s.IsEmpty());

            s.Push(7);
            s.Push(9);
            s.Display();
            Console.WriteLine("Element Top: " + s.Peek());
            s.Display();
        }
    }

}
