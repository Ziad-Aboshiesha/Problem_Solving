namespace _876._Middle_of_the_Linked_List
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
        public ListNode MiddleNode(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null) 
            {
                slow = slow.next;
                fast = fast.next.next;

            }
            return slow;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1,
                 new ListNode(2,
                     new ListNode(3,
                         new ListNode(4,
                             new ListNode(5)
                         )
                     )
                 )
             );
            Solution s = new Solution();
            s.MiddleNode( head );

        }
    }
}
