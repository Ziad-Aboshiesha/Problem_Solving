namespace _21._Merge_Two_Sorted_Lists
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
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;
            ListNode current , newHead, first = list1 , second = list2;
            if(first.val > second.val)
            {
                newHead = new ListNode(second.val);
                current = newHead;
                second = second.next;
            }
            else
            {
                newHead = new ListNode(first.val);
                current = newHead;
                first = first.next;
            }
            while (first != null && second != null) 
            {
                if (first.val > second.val)
                {
                   
                    current.next = new ListNode(second.val);
                    second = second.next;
                }
                else
                {
                    current.next = new ListNode(first.val);
                    first = first.next;
                }
                current = current.next;
            }
            while (first != null) 
            {
                current.next = new ListNode(first.val);
                first = first.next;
                current = current.next;
            }
            while (second != null)
            {
                current.next = new ListNode(second.val);
                second = second.next;
                current = current.next;
            }

            return newHead;
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
