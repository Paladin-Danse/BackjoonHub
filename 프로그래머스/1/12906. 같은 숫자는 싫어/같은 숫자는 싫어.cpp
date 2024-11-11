#include <vector>

using namespace std;

vector<int> solution(vector<int> arr) 
{
    vector<int> answer;
    int rem = -1;
    for(int i=0; i<arr.size(); i++)
    {
        if(rem != arr[i])
        {
            rem = arr[i];
            answer.push_back(arr[i]);
        }
    }

    return answer;
}