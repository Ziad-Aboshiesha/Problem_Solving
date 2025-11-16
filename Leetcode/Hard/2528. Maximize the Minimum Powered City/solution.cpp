#include<iostream>
#include<vector>
using namespace std;



class Solution {
public:
    long long maxPower(vector<int>& stations, int r, int k) 
    {
        int n = stations.size();
        vector<long long> actual_power(n, 0);
        
        // Build actual power using sliding window
        long long sum = 0;
        int right = 0;
        for (int left = 0; left < n; left++) {
            while (right <= left + r && right < n) {
                sum += stations[right];
                right++;
            }
            if (left - r - 1 >= 0)
                sum -= stations[left - r - 1];
            actual_power[left] = sum;
        }

        long long low = *min_element(actual_power.begin(), actual_power.end());
        long long high = *max_element(actual_power.begin(), actual_power.end()) + k;
        long long ans = 0;

        // Binary search on possible minimum power
        while (low <= high) {
            long long mid = (low + high) / 2;
            long long temp_k = k;
            bool ok = true;

            vector<long long> diff(n + 1, 0); // difference array for range updates
            long long added = 0; // prefix sum of diff

            for (int i = 0; i < n; i++) {
                added += diff[i]; // current total added power
                long long current_power = actual_power[i] + added;

                if (current_power < mid) {
                    long long need = mid - current_power;
                    if (need > temp_k) { 
                        ok = false;
                        break;
                    }

                    temp_k -= need;
                    int L = i;
                    int R = min(n - 1, i + 2 * r);
                    diff[L] += need;
                    if (R + 1 < n) diff[R + 1] -= need;
                    added += need; // affect current position immediately
                }
            }

            if (ok) {
                ans = mid;
                low = mid + 1;
            } else {
                high = mid - 1;
            }
        }

        return ans;
    }
};

int main()
{
    Solution s;
    vector<int> nums = {1,2,4,5,0};
    cout<<s.maxPower(nums,1,2);
}