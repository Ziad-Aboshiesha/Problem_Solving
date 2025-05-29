
    int[] arr = {0, 3, 1, 0, 4, 5, 2, 0};
        ListNode head = CreateLinkedList(arr);

        Solution sol = new Solution();
        ListNode merged = sol.MergeNodes(head);

        PrintList(merged);
    

     static ListNode CreateLinkedList(int[] arr) {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        foreach (int val in arr) {
            current.next = new ListNode(val);
            current = current.next;
        }
        return dummy.next;
    }

     static void PrintList(ListNode head) {
        while (head != null) {
            Console.Write(head.val + " ");
            head = head.next;
        }
        Console.WriteLine();
    }

  public class ListNode {
      public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }

public class Solution {
    public ListNode MergeNodes(ListNode head) {
        
        ListNode write = head;
        ListNode read = head.next;
        int sum = 0;
        while(read!=null)
        {
            if(read.val != 0)
            {
                sum+= read.val;
            }else
            {
                write.next.val = sum;
                sum = 0;
                write = write.next;
            }
            read= read.next;
        }
        write.next = null;
       
        return head.next;

    }
}