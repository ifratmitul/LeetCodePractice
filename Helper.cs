namespace LeetCodePractice
{
    public class NestedIterator
    {

        IList<NestedInteger> data = new List<NestedInteger>();
        Queue<int> myStack = new();

        public NestedIterator(IList<NestedInteger> nestedList)
        {
            foreach (var item in nestedList)
            {
                iterator(item);
            }
        }

        public bool HasNext()
        {
            return myStack.Count > 0;
        }

        public int Next()
        {
            return myStack.Dequeue();
        }

        private void iterator(NestedInteger nested)
        {
            if (nested.IsInteger())
            {
                myStack.Enqueue(nested.GetInteger());
            }
            else
            {
                IList<NestedInteger> nestedData = nested.GetList();
                foreach (NestedInteger item in nestedData)
                {
                    iterator(item);
                }

            }
        }


    }
}