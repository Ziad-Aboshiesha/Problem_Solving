namespace _1290._Convert_Binary_Number_in_a_Linked_List_to_Integer
{

  public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) 
        {
            this.val = val;
            this.next = next;
        }
  }

    public class Solution
    {
        public int GetDecimalValue(ListNode head)
        {
            int result = 0;
            while (head != null)
            {
                result = (result << 1) | head.val;  // shift left and add bit
                head = head.next;
            }
            return result;
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
