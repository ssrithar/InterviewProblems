namespace LeetCode.Questions
{
    public class LRUCacheShell
    {
        public LRUCacheShell() 
        {
            LRUCache lruCache = new LRUCache(2);

            /*
            ["LRUCache", "put", "put", "get", "put", "get", "put", "get", "get", "get"]
            [[2], [1, 1], [2, 2], [1], [3, 3], [2], [4, 4], [1], [3], [4]]
            */

            lruCache.Put(1, 1);
            lruCache.PrintCache(2);
            lruCache.Put(2, 2);
            lruCache.PrintCache(2);
            Console.WriteLine($"Get Cache Value 1 {lruCache.Get(1)}");
            lruCache.Put(3, 3);
            lruCache.PrintCache(2);
            Console.WriteLine($"Get Cache Value 2 {lruCache.Get(2)}");
            lruCache.Put(4, 4);
            lruCache.PrintCache(2);
            Console.WriteLine($"Get Cache Value 1 {lruCache.Get(1)}");
            Console.WriteLine($"Get Cache Value 3 {lruCache.Get(3)}");
            Console.WriteLine($"Get Cache Value 4 {lruCache.Get(4)}");
        }
    }

    internal class LRUCache
    {
        private Dictionary<int, int> cache;
        private Dictionary<int, int> keyUsage = new Dictionary<int, int>();
        private int cacheCapacity;

        public LRUCache(int capacity)
        {
            this.cacheCapacity = capacity;
            this.cache = new Dictionary<int, int>(cacheCapacity);
        }

        public int Get(int key)
        {
            int keyValue = -1;

            if (this.cache.TryGetValue(key, out int value))
            {
                keyValue = value;

                if (!this.keyUsage.TryGetValue(key, out int count))
                {
                    this.keyUsage.Add(key, 1);
                }
                else
                {
                    this.keyUsage[key] += 1;
                }
            }

            return keyValue;
        }

        public void Put(int key, int value)
        {
            if (this.cache.Keys.Count == this.cacheCapacity)
            {
                int keyToRemove = this.cache.Select(item => item.Key).ToList().Except(this.keyUsage.Select(item => item.Key)).First();
                //this.keyUsage.OrderBy(item => item.Value).First().Key;
                this.cache.Remove(keyToRemove);
                this.keyUsage.Remove(keyToRemove);
            }
            this.cache.Add(key, value);

            //if (!this.keyUsage.TryGetValue(key, out int cacheUsageValue))
            //{
            //	this.keyUsage[key] = 0;
            //}
        }

        public void PrintCache(Int16 cacheId)
        {
            switch (cacheId)
            {
                case 0:
                    Console.WriteLine("Cache");
                    PrintCacheLocal(this.cache);
                    Console.WriteLine("Cache");
                    break;
                case 1:
                    Console.WriteLine("KeyUsage");
                    PrintCacheLocal(this.keyUsage);
                    Console.WriteLine("KeyUsage");
                    break;
                case 2:
                    Console.WriteLine("Cache");
                    PrintCacheLocal(this.cache);
                    Console.WriteLine("Cache");
                    Console.WriteLine("KeyUsage");
                    PrintCacheLocal(this.keyUsage);
                    Console.WriteLine("KeyUsage");
                    break;
            }
        }

        private void PrintCacheLocal(Dictionary<int, int> cacheToPrint)
        {
            foreach (var item in cacheToPrint)
            {
                Console.Write($"[{item.Key},{item.Value}]");
            }
            Console.WriteLine();
        }
    }
}
