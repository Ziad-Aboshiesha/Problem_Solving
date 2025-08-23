namespace _1122._Relative_Sort_Array
{
    internal class Program
    {
        public class Solution
        {
            public int[] RelativeSortArray(int[] arr1, int[] arr2)
            {
                Dictionary<int,int> result = new Dictionary<int,int>();
                HashSet<int> visited = arr2.ToHashSet();
                List<int> list = new List<int>();
                List<int> r = new List<int>();
                for (int i = 0; i < arr1.Length; i++)
                {
                    if(visited.Contains(arr1[i] ))
                    {
                        result.TryAdd(arr1[i], 0);    
                        result[arr1[i]]++;
                    }
                    else
                    {
                       list.Add(arr1[i]);
                    }
                }
                
                for (int i = 0; i < arr2.Length; i++)
                {
                    for (int j = 0;  j < result[arr2[i]];  j++)
                    {
                        r.Add(arr2[i]);
                    }
                }
                list.Sort();
                r.AddRange(list);
                return r.ToArray();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
