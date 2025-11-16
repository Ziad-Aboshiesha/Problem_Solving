namespace _83._Remove_Duplicates_from_Sorted_List
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
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode slow = head;
            ListNode fast = head.next ;
            while (fast != null)
            {
                if(slow.val == fast.val)
                {
                    fast = fast.next;
                }
                else
                {
                    slow.next = fast;
                    slow = fast;
                    fast = fast.next;

                }
            }

            slow.next = null;
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
