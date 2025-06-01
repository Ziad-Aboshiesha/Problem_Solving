using System.Collections;

namespace _141._Linked_List_Cycle
{
   
  
   public class ListNode 
   {
      public int val;
      public ListNode next;
      public ListNode(int x) {
          val = x;
          next = null;
      }
   }
 
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> visited = new HashSet<ListNode>();
            while (head != null) 
            {
                if(visited.Contains(head))
                {
                    return true;
                }
                else
                {
                    visited.Add(head);
                }
                head = head.next;
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
