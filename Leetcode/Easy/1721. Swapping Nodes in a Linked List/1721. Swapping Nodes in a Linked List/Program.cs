using System.Collections.Specialized;

namespace _1721._Swapping_Nodes_in_a_Linked_List
{

  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }

    public class Solution
    {
        public ListNode SwapNodes(ListNode head, int k)
        {
            ListNode curr = head;
            ListNode first = null ,second = head ;
            int count = 0;
            while (curr != null) 
            {
                count++;
                if(count==k)
                {
                    first = curr;
                }
                if(count>k)
                {
                    second = second.next;
                }



                curr = curr.next;
                
            }
            int temp = first.val;
            first.val= second.val;
            second.val= temp;

            return head;
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
