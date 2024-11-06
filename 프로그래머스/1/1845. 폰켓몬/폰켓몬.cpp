#include <vector>
#include <unordered_map>
using namespace std;

int solution(vector<int> nums)
{
    unordered_map<int, int> ponketmon;
    int take_value = nums.size() / 2;
    int answer;
    
    for(auto& i : nums) ponketmon[i]++;
    ponketmon.size() > take_value ? answer = take_value : answer = ponketmon.size();
    return answer;
}