#include<iostream>
#include<queue>
#include<algorithm>
using namespace std;

class Solution {
public:
    int mostBooked(int n, vector<vector<int>>& meetings) {
        sort(meetings.begin(), meetings.end(),
        [](const vector<int>& a, const vector<int>& b) {
        return a[0] < b[0];
        });
        priority_queue<pair<long long, int>,
        vector<pair<long long, int>>,greater<pair<long long, int>>>         busyrooms;
        vector<int> count_rooms(n,0);
        priority_queue<int, vector<int>, greater<int>> freeRooms;

        for(int i = 0 ; i< n ; i++)
        {
            freeRooms.push(i);
        }
        //first finish time 
        //second room id 
        int maxroom =0;
        int maxmeetings = 0;
        for(int i =0 ; i< meetings.size(); i++)
        {
            while(!(busyrooms.empty() )&&  meetings[i][0]>= busyrooms.top().first)
            {
                int room =  busyrooms.top().second;
                busyrooms.pop();
                freeRooms.push(room);
            }

            if(freeRooms.empty())
            {
                int room =  busyrooms.top().second;
                long long endtime =  busyrooms.top().first;
                busyrooms.pop();

                long long totalendtime = meetings[i][1] - meetings[i][0];
                totalendtime += endtime;

                busyrooms.push({totalendtime, room});

                count_rooms[room]++;

                if(maxmeetings < count_rooms[room] || ( maxmeetings == count_rooms[room]  && maxroom > room ))
                {
                    maxmeetings = count_rooms[room];
                    maxroom = room;
                }
            }
            else
            {
                int room = freeRooms.top();
                freeRooms.pop();
                busyrooms.push({meetings[i][1], room});
                count_rooms[room]++;
                if(maxmeetings < count_rooms[room] || ( maxmeetings ==      count_rooms[room]  && maxroom > room ))
                {
                    maxmeetings = count_rooms[room];
                    maxroom = room;
                }

            }
        }
        return maxroom;
    }
};