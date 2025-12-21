#include<iostream>
#include<vector>
#include <string>
#include <cctype> 
#include <set>
using namespace std;
class Solution {
public:
    vector<string> validateCoupons(vector<string>& code, vector<string>& businessLine, vector<bool>& isActive) {
        multiset<string> res;
        multiset<string> phar;
        multiset<string> groc;
        multiset<string> elc;

        for (int i = 0; i < code.size(); i++)
        {
            bool status = true;
            if(code[i]=="")status=false;
            for(char c : code[i])
            {
                if(!isalnum(c) && c != '_')
                {
                    status = false;
                    break;
                }
            }
            if(status && isActive[i] == true ) 
            {
                // electronics", "grocery", "pharmacy", "restaurant
                if(businessLine[i]=="electronics") elc.insert(code[i]);
                if(businessLine[i]=="grocery") groc.insert(code[i]);
                if(businessLine[i]=="pharmacy") phar.insert(code[i]);
                if(businessLine[i]=="restaurant") res.insert(code[i]);
            }

        }
        vector<string> ans;
        for(string c : elc) ans.push_back(c);
        for(string c : groc) ans.push_back(c);
        for(string c : phar) ans.push_back(c);
        for(string c : res) ans.push_back(c);
        return ans;
    }
};
int main()
{
    return 0;
}