namespace _2807._Insert_Greatest_Common_Divisors
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
        public ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode h = head;
            while(head.next!= null)
            {
                int res = CalcGCD(head.val, head.next.val);
                ListNode add = new ListNode(res, head.next);
                head.next = add;
                head = head.next.next;
            }


            return h;
        }
        private int CalcGCD(int a, int b)
        {
            while(b  != 0)
            {
                int temp = b;
                b = a % b;
                a= temp;
            }
            return a;
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
