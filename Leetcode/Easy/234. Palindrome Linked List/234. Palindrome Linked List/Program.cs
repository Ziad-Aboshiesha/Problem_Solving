namespace _234._Palindrome_Linked_List
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
        public bool IsPalindrome(ListNode head)
        {
            
            ListNode right = head;
            if (right.next != null) 
            {
                IsPalindrome(right.next);
            }
            



            return true;
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
