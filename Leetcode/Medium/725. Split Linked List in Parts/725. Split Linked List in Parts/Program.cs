Solution s = new Solution();
ListNode head = s.CreateStaticLinkedList();
ListNode[] ans = s.SplitListToParts(head, 5);
PrintListNodeArray(ans);
    void PrintListNodeArray(ListNode[] parts)
    {
        for (int i = 0; i < parts.Length; i++)
        {
            Console.Write($"Part {i + 1}: ");
            PrintSingleList(parts[i]);
        }
    }

    void PrintSingleList(ListNode head)
    {
        if (head == null)
        {
            Console.WriteLine("null");
            return;
        }

        while (head != null)
        {
            Console.Write(head.val + " -> ");
            head = head.next;
        }
        Console.WriteLine("null");
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
     public  ListNode CreateStaticLinkedList()
    {
        ListNode head = new ListNode(1);
        ListNode current = head;
        for (int i = 2; i <= 3; i++)
        {
            current.next = new ListNode(i);
            current = current.next;
        }
        return head;
    }
     public  void PrintLinkedList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val + " -> ");
            head = head.next;
        }
        Console.WriteLine("null");
    }
    public ListNode[] SplitListToParts(ListNode head, int k)
    {
        int length = 0;
        ListNode temp_head = head;
        while (head != null)
        {
            length++;
            head = head.next;
        }
        int single_length = length / k;
        int overflow = length % k;
        ListNode[] ans = new ListNode[k];
        int point = 0;
        while (temp_head != null)
        {
            ListNode add;
            if (single_length != 0)
            {
                add = temp_head;
                ans[point++] = add;
                for (int i = 0; i < single_length - 1; i++)
                {
                    add.next = temp_head.next;
                    add = add.next;
                    temp_head = temp_head.next;
                }
                if (overflow > 0)
                {

                    overflow--;
                    add.next = temp_head.next;
                    add = add.next;
                    temp_head = temp_head.next;

                }
                temp_head = temp_head.next;
                add.next = null;
            }
            else
            {
                if (overflow > 0)
                {
                    overflow--;
                    add = temp_head;
                    ans[point++] = add;
                    temp_head = temp_head.next;
                    add.next = null;
                }
            }
            
        }

        return ans;
    }
}