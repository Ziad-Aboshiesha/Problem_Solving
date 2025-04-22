namespace _2._Add_Two_Numbers
{
      public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
                 }
 }
    public class Solution
    {
        // time  : O(n)
        // space : O(n)
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode main = new ListNode();
            ListNode temp= main;
            int sum = 0;
            int carry = 0;
            sum = l1.val + l2.val + carry;
            if (sum > 9)
            {
                sum -= 10;
                carry = 1;
            }
            else
            {
                carry = 0;
            }
            temp.val = sum;
            while (l1.next != null && l2.next != null) 
            {
                temp.next = new ListNode();
                temp = temp.next;
                l1 = l1.next;
                l2 = l2.next;
                sum = l1.val + l2.val + carry;
                if(sum> 9)
                {
                    sum -= 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                temp.val = sum;
            
                
            }
            l1 = l1.next;
            while(l1!=null)
            {
                temp.next = new ListNode();
                temp = temp.next;
                sum = l1.val  + carry ;
                if (sum > 9)
                {
                    sum -= 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                temp.val = sum;                
                l1 = l1.next;
            }
            l2 = l2.next;
            while (l2 != null)
            {
                temp.next = new ListNode();
                temp = temp.next;
                sum = l2.val + carry;
                if (sum > 9)
                {
                    sum -= 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                temp.val = sum;
                l2 = l2.next;
            }

            
            if (carry != 0)
            {
                temp.next = new ListNode(carry);
            }

            return main;
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
