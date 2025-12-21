#include<iostream>
#include<vector>
using namespace std;
class Solution {
public:
    int minDeletionSize(vector<string>& strs) {
        int ans =0;

        int m = strs[0].size();
        int n = strs.size();
        int before = -1;
        vector<int> arr(m,INT_MAX);
        for(int j=0;j < m;j++)
        {
            for(int i =0; i < n-1 ;i++)
            {
                
                if(before!= -1 && arr[before]==1 )
                {
                    if(strs[i][before]== strs[i+1][before] &&  strs[i][j] > strs[i+1][j])
                    {
                        arr[j]=0;
                        ans++;
                        break;
                    }
                    if(strs[i][before]== strs[i+1][before] &&  strs[i][j] == strs[i+1][j])
                    {
                        arr[j]=1;
                    }
                }
                else
                {
                    if(strs[i][j] > strs[i+1][j])
                    {
                        arr[j]=0;
                        ans++;
                        break;
                    }
                    if(strs[i][j] == strs[i+1][j])
                    {
                        arr[j]=1;
                    }
                }
                
            }
            if(arr[j]==1) before=j;
            if(arr[j]==INT_MAX) break;
        }
        return ans;
    }
};
int main()
{
    Solution s ;
    
    vector<string> arr={"ffusbkyqlb","ercqbqkrhb","tjghblnrtn","soflcftrsy","afexdrmbxo","zvotdsjiyg","tosldognaf","vgrugbnqre","ohpchuqazm","lsgjitblxb","oemujbxnxm","nywzjglrug","ermokiwkdi","cnzykvhyci","fdsblgitww","esofnnmnhs","lawlnyuwwx","gijnnhtydz","lqfkqmlcnn","mchvrcovml","slatswujew","krebwrebsj","kapfwsvmvv","tzuawyxsqu","aiuqwtuzdw","ynkrxfehjc","nkuuyqsire","fktpymcvmr","xxkfygbzzv","oiaxzreocg"};
    vector<string> arrr={"brh","brt","crs"};
    cout <<s.minDeletionSize(arrr);
    return 0;
}