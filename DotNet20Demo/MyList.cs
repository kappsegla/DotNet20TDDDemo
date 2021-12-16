namespace DotNet20Demo
{
    public class MyList
    {
        private int count;
        private int[] items = new int[2];

        public int Size()
        {
            return count;
        }

        public void Add(int v)
        {
            items[count++] = v;
        }

        public int Get(int v)
        {
            return items[v];
        }
    }
}