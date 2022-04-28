using System.Collections;

namespace LeetCodePractice
{
    public class LinkStack
    {

        private LinkedList<int> stack;

        public LinkStack()
        {
            stack = new LinkedList<int>();
        }

        public void push(int val)
        {
            stack.AddFirst(val);
        }

        public int pop()
        {
            int val = stack.First();
            stack.Remove(stack?.First);
            return val;
        }

        public int peek()
        {
            if (isEmpty()) return stack.First();
            return -1;
        }

        public Boolean isEmpty()
        {
            return stack.Count > 0;
        }

        public void PrintStack()
        {
            IEnumerator iterator = stack.GetEnumerator();

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
        }

        public int getMin()
        {
            return stack.Min();
        }

    }
}