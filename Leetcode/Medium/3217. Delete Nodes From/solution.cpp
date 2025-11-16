#include<iostream>
#include<vector>
#include<unordered_set>
using namespace std;

    struct ListNode {
        int val;
        ListNode *next;
        ListNode() : val(0), next(nullptr) {}
        ListNode(int x) : val(x), next(nullptr) {}
        ListNode(int x, ListNode *next) : val(x), next(next) {}
    };

class Solution {
public:
    ListNode* modifiedList(vector<int>& nums, ListNode* head) {
        if(head == nullptr || head->next == nullptr) return head;
        unordered_set<int> set_of_nums(nums.begin(), nums.end());
        ListNode* temp = head;

        while(temp != nullptr && set_of_nums.find(temp->val)!= set_of_nums.end())
        {
            temp = temp->next;
            
        }
        head = temp;
        ListNode* current =head;
        temp = head->next;
        while(current!= nullptr)
        {
            while(temp != nullptr && set_of_nums.find(temp->val)!= set_of_nums.end())
            {
                temp = temp->next;
                
                continue;
            }
            current->next = temp;
            current= temp;
             if(temp != nullptr )
            {
                
                temp = temp->next;
            }
            
        }



        return head;
    }
};

int main()
{

    ListNode* head = new ListNode(1);
    head->next = new ListNode(2);
    head->next->next = new ListNode(1);
    head->next->next->next = new ListNode(2);
    head->next->next->next->next = new ListNode(1);
    head->next->next->next->next->next = new ListNode(2);
    Solution s ;
    vector<int> nums = {1};
    ListNode* head2 = s.modifiedList( nums , head);
    while (head2 != nullptr) {
        cout <<endl<< head2->val << " ";
        head2 = head2->next;
    }
    return 0;
}